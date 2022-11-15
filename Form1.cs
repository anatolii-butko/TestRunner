namespace TestRunner
{
    #region Using

    using System;
    using System.Windows.Forms;
    using System.IO;
    using System.Drawing;
    using System.Diagnostics;

    #endregion

    public partial class FormMain : Form
    {
        #region Fields and Constants

        protected bool isAnyNodeInTreeviwRepoChecked; //A flag indicating whether any tree node has been checked.
        protected bool isAnyNodeInTreeviwConfigsChecked; //A flag indicating whether any tree node has been checked.
        protected string listOfTests; //A variable that stores a list of tests of marked nodes of the config tree. A list is formed from it (variable).
        protected string listOfConfigs; //A variable that stores the list of configs of the doubleclicked node of the config tree. A list is formed from it (variable).
        protected string listOfTestsWithoutConfigs; //A variable that stores a list of tests wothout configs of double clicked node and all children of the repo tree. A list is formed from it (variable).
        protected string testProject;//A the variable is required to generate the terminal command for each test. Stores the test project path.
        protected string testName; //A variable is required to generate the terminal command for each test. Stores the full test file path without the project path.
        protected string testConfig; //A variable is required to generate the terminal command for each test. Stores the path of the all configuration files with which to run the test.
        protected string configName; //A variable that stores the name of config file.
        protected string batFileName; //A variable that stores the name of .bat file.
        protected string batFilePath; //A variable that stores the full path of .bat file.
        protected bool batWasSaved; //A flag indicating was been .bat file saved.
        protected string command; //A variable containing a formatted list of commands (also as a single command).
        protected string readMeFileName;
        protected string readMeFilePath;
        protected bool readMeFileWasSaved; //A flag indicating was been ReadMe.txt file generated.
        protected string directoryFromWichTestRunnerWasLaunched;

        #endregion

        #region Constructors and Deconstructors

        public static FormMain instance;
        FormSettings formS = new FormSettings();

        #endregion

        #region Properties



        #endregion

        #region Protected methods

        public void PopulateTreeView(string path, TreeView tree, params string[] fileExtensions)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path); // Specify the directories you want to manipulate.
            {
                tree.Nodes.Clear();
                tree.Nodes.Add(LoadDirectory(directoryInfo, fileExtensions)); //Adds the main тode of the tree at the specified path
                //and calls a function that reads the folder and forms its contents as tree elements.
            }
        }

        protected TreeNode LoadDirectory(DirectoryInfo dir, params string[] fileExtensions)
        {
            if (!dir.Exists)
                return null;

            TreeNode output = new TreeNode(dir.Name, 0, 0);


            foreach (var subDir in dir.GetDirectories())
            {
                output.Nodes.Add(LoadDirectory(subDir, fileExtensions));
            }

            foreach (var file in dir.GetFiles())
            {
                if (file.Exists) //&& file.Extension == fileExtension)
                {
                    output.Nodes.Add(file.Name);
                    output.Nodes[output.Nodes.Count - 1].ImageIndex = 1;
                    output.Nodes[output.Nodes.Count - 1].SelectedImageIndex = 1;
                }
            }

            return output;
        }

        protected void CheckItems(TreeNode node)
        {
            node.Checked = true;
            foreach (TreeNode childNode in node.Nodes)
            {
                childNode.Checked = true;
                CheckItems(childNode);
            }
        }
        protected void UnCheckItems(TreeNode node)
        {
            node.Checked = false;
            foreach (TreeNode childNode in node.Nodes)
            {
                childNode.Checked = false;
                UnCheckItems(childNode);
            }
        }

        public void AppendText(RichTextBox box, string text, Color color, bool AddNewLine = false)
        {
            if (AddNewLine)
            {
                text += Environment.NewLine;
            }

            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
        protected void CreateReadMe()
        {
            readMeFileName = "ReadMe.txt";
            readMeFilePath = directoryFromWichTestRunnerWasLaunched + "\\" + readMeFileName;
            ReadMe readMe = new ReadMe();
            if (!File.Exists(readMeFilePath))
            {
                File.Create(readMeFilePath).Close();
                File.WriteAllText(readMeFilePath, readMe.readMeFileContent);
                readMeFileWasSaved = true;
                MessageBox.Show("ReadMe.txt file genereted in: " + directoryFromWichTestRunnerWasLaunched);
                return;
            }
            else
            {
                File.WriteAllText(readMeFilePath, readMe.readMeFileContent);
                readMeFileWasSaved = true;
                MessageBox.Show("Existed ReadMe.txt file overrided in: " + directoryFromWichTestRunnerWasLaunched);
                return;
            }
        }
        protected void FindTestsInDoubleClickedNodeAndAllChildren(TreeNode node)
        {
            if (node.ImageIndex == 1) // if clicked test file
            {
                listOfTestsWithoutConfigs += "\n" + node.FullPath;
                listOfTestsWithoutConfigs.TrimStart('\n');
                return;
            }
            else // clicked dictionary
            {
                if (node.Nodes.Count > 0)
                {
                    foreach (TreeNode childNode in node.Nodes)
                    {
                        FindTestsInDoubleClickedNodeAndAllChildren(childNode);
                    }
                    return;
                }
                else // clicked dictionary is empty(no test files)
                {
                    MessageBox.Show("You have doubleclicked an empty folder. Doubleclick another folder or file");
                    return;
                }
            }
        }
        protected void FindTestsInCheckedNodeAndAllChildren(TreeNode node)
        {
            if (node.ImageIndex == 1 && node.Checked == true)
            {
                listOfTests += "\n" + node.FullPath;
                listOfTests.TrimStart('\n');
            }
            foreach (TreeNode childNode in node.Nodes)
            {
                FindTestsInCheckedNodeAndAllChildren(childNode);
            }
            //if (testWasCheched == false) MessageBox.Show("Choose an other folder, no tests here.");
        }
        protected void FindConfigsInCheckedNodeAndAllChildren(TreeNode node)
        {
            if (node.ImageIndex == 1 && node.Checked == true)
            {
                listOfConfigs += "\n" + node.FullPath;
                listOfConfigs.TrimStart('\n');
            }
            foreach (TreeNode childNode in node.Nodes)
            {
                FindConfigsInCheckedNodeAndAllChildren(childNode);
            }
        }

        #endregion

        #region Private methods

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void TreeViewRepo_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (isAnyNodeInTreeviwRepoChecked == true)
            {
                tabControl1.SelectedTab = BatFileContent;
                FindTestsInDoubleClickedNodeAndAllChildren(e.Node);
                foreach (string test in listOfTestsWithoutConfigs.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    testProject = test.Substring(test.IndexOf('\\') + 1).Substring(0, test.Substring(test.IndexOf('\\') + 1).IndexOf('\\'));
                    testName = test.Substring(test.LastIndexOf('\\') + 1).Substring(0, test.Substring(test.LastIndexOf('\\') + 1).Length - 3);
                    // formed a sigle comand for test.
                    // single command = "tool name" + " -p " + "test project" + " -n " + "test name" 
                    AppendText(richTextBoxBatFileContent, FormSettings.instance.toolName, Color.DarkBlue); // highlight toolName.
                    AppendText(richTextBoxBatFileContent, " -p ", Color.Black);
                    AppendText(richTextBoxBatFileContent, testProject, Color.Blue); // highlights test project.
                    AppendText(richTextBoxBatFileContent, " -n ", Color.Black);
                    AppendText(richTextBoxBatFileContent, testName, Color.RoyalBlue, true); // highlights test name.
                }
                listOfTestsWithoutConfigs = string.Empty;
            }
            else
            {
                MessageBox.Show("No one test was cheked. Check the test.");
                return;
            }
        }

        private void TreeViewRepo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string testPath = treeViewRepo.SelectedNode.FullPath;
                string testName = testPath.Substring(testPath.LastIndexOf('\\') + 1).Substring(0, testPath.Substring(testPath.LastIndexOf('\\') + 1).Length - 3);
                string temp = testPath.Substring(testPath.IndexOf('\\'));
                string testLogsFolder = FormSettings.instance.pathToLogs + temp;
                
                testLogsFolder = testLogsFolder.Substring(0, testLogsFolder.Length - 3);
                DirectoryInfo directoryInfo = new DirectoryInfo(testLogsFolder);
                //if (!directoryInfo.Exists)
                {
                    //MessageBox.Show("The selected test did not run.\nThe logs do not exist or were not found.\nTry to run the test so that a folder with logs is created.");
                    //return;
                }
                //else
                {
                    tabControl1.SelectedTab = Logs;
                    //treeViewLogs.Nodes.Clear();
                    //treeViewLogs.Nodes.Add(LoadDirectory(directoryInfo, ".html", ".file", ".failed", ".warning"));
                }
                tabControl1.SelectedTab.Text = testName;
                instance.PopulateTreeView(testLogsFolder, instance.treeViewLogs, ".html", ".file", ".failed", ".warning");
                //Logs.Name = treeViewRepo.SelectedNode.FullPath;
                // Display context menu for eg:
                //ContextMenu1.Show();
            }
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialogBat.ShowDialog() == DialogResult.Cancel)
                return;
            batFileName = openFileDialogBat.FileName;
            richTextBoxBatFileContent.Text = File.ReadAllText(batFileName);
            MessageBox.Show(batFileName + ".bat loaded.");
            return;
        }

        private void ButtonSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialogBat.FileName = "TestRunner_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".bat"; // by default for autosave 
            if (saveFileDialogBat.ShowDialog() == DialogResult.Cancel)
                return;
            batFileName = saveFileDialogBat.FileName;
            File.WriteAllText(batFileName, richTextBoxBatFileContent.Text);
            batWasSaved = true;
            MessageBox.Show(batFileName + ".bat saved as");
            //richTextBoxCommandLine.Text = presetText;
            return;
        }

        private void ButtonClean_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == BatFileContent)
            {
                richTextBoxBatFileContent.Clear();
                AppendText(richTextBoxBatFileContent, "cd ", Color.Blue);
                AppendText(richTextBoxBatFileContent, FormSettings.instance.toolFolder, Color.Black, true);
            }
            //else richTextBoxLogs.Clear();
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            if (FormSettings.instance.pathToRepo != null && FormSettings.instance.repoFolder != null
                                                         && FormSettings.instance.pathToConfigs != null && FormSettings.instance.configsFolder != null
                                                         && FormSettings.instance.pathToTool != null && FormSettings.instance.toolFolder != null
                                                         && FormSettings.instance.pathToLogs != null && FormSettings.instance.logsFolder != null == true)
            {
                FindDuplicates();
                AutoSaveBat();
                ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/k arp -d")
                {
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Normal,
                    UseShellExecute = true,
                    Verb = "runas",
                    WorkingDirectory = FormSettings.instance.toolFolder,
                    FileName = batFilePath

                };

                //tests = string.Empty;
                ///File.WriteAllText("C:\\TestRunner\\Bat_runer.bat", "command1\n" +"command2\n");
                ///Process.Start("C:\\TestRunner\\Bat_runer.bat");

                command = richTextBoxBatFileContent.Text;
                Process.Start(processStartInfo);
                return;
            }
            else
            {
                MessageBox.Show("Something is wrong. Specify the path or select folders for the repository, configurations, framework/tool and logs.");
                return;
            }
        }

        private void FindDuplicates()
        {

            return;
        }

        private void AutoSaveBat()
        {
            batFileName = "TestRunner.bat";
            //batFileName = "TestRunner_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".bat";
            batFilePath = directoryFromWichTestRunnerWasLaunched + "\\" + batFileName;
            if (!File.Exists(batFilePath))
            {
                File.Create(batFilePath).Close();
                File.WriteAllText(batFilePath, richTextBoxBatFileContent.Text);
                batWasSaved = true;
                MessageBox.Show("New TestRunner.bat file genereted in: " + directoryFromWichTestRunnerWasLaunched);
                return;
            }
            else
            {
                File.WriteAllText(batFilePath, richTextBoxBatFileContent.Text);
                batWasSaved = true;
                MessageBox.Show("Existed TestRunner.bat file overrided in: " + directoryFromWichTestRunnerWasLaunched);
                return;
            }

        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            if (readMeFileWasSaved == false)
            {
                DialogResult createReadMe = MessageBox.Show("A ReadMe.txt file will be created. Continue?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (createReadMe == DialogResult.Cancel)
                {
                    return;
                }
                CreateReadMe();
                DialogResult openReadMe = MessageBox.Show("A ReadMe.txt file created. Open file?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (openReadMe == DialogResult.Cancel)
                {
                    return;
                }
                Process.Start(readMeFilePath);
                //Process.Start("notepad.exe", readMeFilePath);
                return;
            }
            else
            {
                DialogResult openReadMe = MessageBox.Show("A ReadMe.txt file created. Open file?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (openReadMe == DialogResult.Cancel)
                {
                    return;
                }
                Process.Start(readMeFilePath);
                //Process.Start("notepad.exe", readMeFilePath);
                return;
            }
        }

        private void TreeViewRepo_AfterCheck(object sender, TreeViewEventArgs e)
        {
            isAnyNodeInTreeviwRepoChecked = e.Node.Checked;
            if (isAnyNodeInTreeviwRepoChecked == true)
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = true;
                    CheckItems(node);
                }
                isAnyNodeInTreeviwRepoChecked = true;
                return;
            }
            else
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = false;
                    UnCheckItems(node);
                }
                isAnyNodeInTreeviwRepoChecked = false;
                return;
            }
        }

        private void TreeViewConfigs_AfterCheck(object sender, TreeViewEventArgs e)
        {
            isAnyNodeInTreeviwConfigsChecked = e.Node.Checked;
            if (isAnyNodeInTreeviwConfigsChecked == true)
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = true;
                    CheckItems(node);
                }
                isAnyNodeInTreeviwConfigsChecked = true;
                return;
            }
            else
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = false;
                    UnCheckItems(node);
                }
                isAnyNodeInTreeviwConfigsChecked = false;
                return;
            }
        }

        private void TreeViewConfigs_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (isAnyNodeInTreeviwRepoChecked == true)
            {
                if (isAnyNodeInTreeviwConfigsChecked == true)
                {
                    tabControl1.SelectedTab = BatFileContent;
                    foreach (TreeNode node in treeViewRepo.Nodes)
                    {
                        FindTestsInCheckedNodeAndAllChildren(node);
                    }
                    foreach (TreeNode node in treeViewConfigs.Nodes)
                    {
                        FindConfigsInCheckedNodeAndAllChildren(node);
                    }
                    foreach (string test in listOfTests.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        testProject = test.Substring(test.IndexOf('\\') + 1).Substring(0, test.Substring(test.IndexOf('\\') + 1).IndexOf('\\'));
                        testName = test.Substring(test.LastIndexOf('\\') + 1).Substring(0, test.Substring(test.LastIndexOf('\\') + 1).Length - 3);

                        // formed a sigle comand for each test and each config.
                        // single command = "tool name" + " -p " + "test project" + " -n " + "testName" + " -c " + "first test config" + " -c " + "second test config"...etc
                        AppendText(richTextBoxBatFileContent, FormSettings.instance.toolName, Color.DarkBlue); // highlight toolName.
                        AppendText(richTextBoxBatFileContent, " -p ", Color.Black);
                        AppendText(richTextBoxBatFileContent, testProject, Color.Blue); // highlights test project.
                        AppendText(richTextBoxBatFileContent, " -n ", Color.Black);
                        AppendText(richTextBoxBatFileContent, testName, Color.RoyalBlue); // highlights test name.
                        foreach (string config in listOfConfigs.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                        {
                            testConfig = FormSettings.instance.pathToConfigs + config.Substring(config.IndexOf('\\'));
                            configName = testConfig.Substring(testConfig.LastIndexOf('\\') + 1);
                            AppendText(richTextBoxBatFileContent, " -c ", Color.Black);
                            AppendText(richTextBoxBatFileContent, testConfig.Substring(0, testConfig.LastIndexOf("\\") + 1), Color.Black);
                            AppendText(richTextBoxBatFileContent, configName, Color.BlueViolet); // highlights test config name.
                        }
                        richTextBoxBatFileContent.AppendText(Environment.NewLine); // moves the carriage to the next line for convenience.
                    }
                    listOfTests = string.Empty;
                    listOfConfigs = string.Empty;
                    return;
                }
                else
                {
                    MessageBox.Show("No one config was cheked. Check the config.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("No one test was cheked. Check the test.");
                return;
            }
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            
            if (formS.Visible == true)
            {
                FormSettings.instance.Hide();
                return;
            }
            else
            {
                FormSettings.instance.Show();
                return;
            }
        }

        private void TreeViewLogs_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!e.Node.Name.Contains(".html")) return;
            else
            {
                try
                {
                    System.Diagnostics.Process.Start("chrome", e.Node.FullPath);
                    //Process.Start(textBox1.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Chrome is not installed probably");
                }
            }
        }

        #endregion

        #region Public methods

        public FormMain()
        {
            InitializeComponent();
            instance = this;
            isAnyNodeInTreeviwRepoChecked = false;
            isAnyNodeInTreeviwConfigsChecked = false;
            testProject = string.Empty;
            testName = string.Empty;
            testConfig = string.Empty;
            listOfTests = string.Empty;
            listOfConfigs = string.Empty;
            batFileName = string.Empty;
            batWasSaved = false;
            readMeFileName = string.Empty;
            readMeFileWasSaved = false;
            directoryFromWichTestRunnerWasLaunched = Environment.CurrentDirectory;
        }

        #endregion

        
    }
}
