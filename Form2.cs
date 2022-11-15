namespace TestRunner
{
    #region Using
    
    using System.Windows.Forms;
    using System.IO;
    using System.Drawing;

    #endregion

    public partial class FormSettings : Form
    {
        #region Fields and Constants

        public string pathToRepo; //A variable that stores the full path to the test repository.
        public string repoFolder; //A variable that stores the address of the repo folder. Required as an argument to launch the terminal.
        public string pathToConfigs; //A variable that stores the full path to the configuration files for the tests.
        public string configsFolder; //A variable that stores the address of the configs folder. Required as an argument to launch the terminal.
        public string pathToTool; //A variable that stores the full path to the tool/framework that runs the tests.
        public string toolFolder; //A variable that stores the address of the toolbox folder. Required as an argument to launch the terminal.
        public string toolName; // A variable that stores the name of tool file.
        public string pathToLogs; //A variable that stores the full path to the test log files.
        public string logsFolder; // A variable that stores the address of the logs folder. Required as an argument to launch the terminal.
        
        #endregion

        #region Constructors and Deconstructors

        public static FormSettings instance;

        #endregion

        #region Properties

        

        #endregion

        #region Protected methods



        #endregion

        #region Private methods

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void TextBoxPathToTool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxPathToTool.Text != null && textBoxPathToTool.Text.Length > 0)
                {
                    pathToTool = textBoxPathToTool.Text;
                    if (!File.Exists(pathToTool))
                    {
                        MessageBox.Show("Invalid file path or name. Try again");
                        textBoxPathToTool.Text = pathToTool;
                        return;
                    }
                    else
                    {
                        toolFolder = pathToTool.Substring(0, pathToTool.LastIndexOf('\\'));
                        toolName = pathToTool.Substring(pathToTool.LastIndexOf('\\') + 1);
                        FormMain.instance.AppendText(FormMain.instance.richTextBoxBatFileContent, "cd ", Color.Blue);
                        FormMain.instance.AppendText(FormMain.instance.richTextBoxBatFileContent, toolFolder, Color.Black, true);
                        MessageBox.Show("Path to tool/framework accepted.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid file path or name. Try again");
                    textBoxPathToTool.Text = pathToTool;
                    return;
                }
            }
        }

        private void TextBoxPathToRepo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxPathToRepo.Text != null && textBoxPathToRepo.Text.Length > 0)
                {
                    pathToRepo = textBoxPathToRepo.Text;
                    if (!Directory.Exists(pathToRepo))
                    {
                        MessageBox.Show("Invalid directory path or name. Try again");
                        textBoxPathToRepo.Text = pathToRepo;
                        return;
                    }
                    else
                    {
                        repoFolder = pathToRepo.Substring(0, pathToRepo.LastIndexOf('\\'));
                        MessageBox.Show("Path to repo/tests accepted.");
                        FormMain.instance.PopulateTreeView(pathToRepo, FormMain.instance.treeViewRepo, ".cs");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid directory path or name. Try again");
                    textBoxPathToRepo.Text = pathToRepo;
                    return;
                }
            }
        }

        private void TextBoxPathToConfigs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxPathToConfigs.Text != null && textBoxPathToConfigs.Text.Length > 0)
                {
                    pathToConfigs = textBoxPathToConfigs.Text;
                    if (!Directory.Exists(pathToConfigs))
                    {
                        MessageBox.Show("Invalid directory path or name. Try again");
                        textBoxPathToConfigs.Text = pathToConfigs;
                        return;
                    }
                    else
                    {
                        configsFolder = pathToConfigs.Substring(0, pathToConfigs.LastIndexOf('\\'));
                        MessageBox.Show("Path to tests configs accepted.");
                        FormMain.instance.PopulateTreeView(pathToConfigs, FormMain.instance.treeViewConfigs, ".xml");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid directory path or name. Try again");
                    textBoxPathToConfigs.Text = pathToConfigs;
                    return;
                }
            }
        }

        private void TextBoxPathToLogs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxPathToLogs.Text != null && textBoxPathToLogs.Text.Length > 0)
                {
                    pathToLogs = textBoxPathToLogs.Text;
                    if (!Directory.Exists(pathToLogs))
                    {
                        MessageBox.Show("Invalid directory path or name. Try again");
                        textBoxPathToLogs.Text = pathToLogs;
                        return;
                    }
                    else
                    {
                        logsFolder = pathToLogs.Substring(0, pathToLogs.LastIndexOf('\\'));
                        MessageBox.Show("Path to test logs accepted.");
                        //FormMain.instance.PopulateTreeView(pathToRepo, FormMain.instance.treeViewRepo, ".html");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid directory path or name. Try again");
                    textBoxPathToLogs.Text = pathToLogs;
                    return;
                }
            }
        }

        private void PictureBoxToolFolder_Click(object sender, System.EventArgs e)
        {
            if (openFileDialogTool.ShowDialog() == DialogResult.Cancel)
                return;
            pathToTool = openFileDialogTool.FileName;
            textBoxPathToTool.Text = pathToTool;
            toolFolder = pathToTool.Substring(0, pathToTool.LastIndexOf('\\'));
            toolName = pathToTool.Substring(pathToTool.LastIndexOf('\\') + 1);
            FormMain.instance.AppendText(FormMain.instance.richTextBoxBatFileContent, "cd ", Color.Blue);
            FormMain.instance.AppendText(FormMain.instance.richTextBoxBatFileContent, toolFolder, Color.Black, true);
            MessageBox.Show("Path to tool/framework accepted.");
            return;
        }

        private void PictureBoxRepoFolder_Click(object sender, System.EventArgs e)
        {
            if (folderBrowserDialogRepo.ShowDialog() == DialogResult.Cancel)
                return;
            pathToRepo = folderBrowserDialogRepo.SelectedPath;
            textBoxPathToRepo.Text = pathToRepo;
            repoFolder = pathToRepo.Substring(0, pathToRepo.LastIndexOf('\\'));
            MessageBox.Show("Path to repo/tests accepted.");
            FormMain.instance.PopulateTreeView(pathToRepo, FormMain.instance.treeViewRepo, ".cs");
            FormMain.instance.treeViewRepo.ExpandAll();
            return;
        }

        private void PictureBoxConfigsFolder_Click(object sender, System.EventArgs e)
        {
            if (folderBrowserDialogConfigs.ShowDialog() == DialogResult.Cancel)
                return;
            pathToConfigs = folderBrowserDialogConfigs.SelectedPath;
            textBoxPathToConfigs.Text = pathToConfigs;
            configsFolder = pathToConfigs.Substring(0, pathToConfigs.LastIndexOf('\\'));
            MessageBox.Show("Path to configs accepted.");
            FormMain.instance.PopulateTreeView(pathToConfigs, FormMain.instance.treeViewConfigs, ".xml");
            FormMain.instance.treeViewConfigs.ExpandAll();
            return;
        }

        private void PictureBoxLogsFolder_Click(object sender, System.EventArgs e)
        {
            if (folderBrowserDialogLogs.ShowDialog() == DialogResult.Cancel)
                return;
            pathToLogs = folderBrowserDialogLogs.SelectedPath;
            textBoxPathToLogs.Text = pathToLogs;
            logsFolder = pathToLogs.Substring(0, pathToLogs.LastIndexOf('\\'));
            MessageBox.Show("Path to test logs accepted.");
            FormMain.instance.tabControl1.SelectedTab = FormMain.instance.tabControl1.TabPages[1];
            FormMain.instance.tabControl1.SelectedTab.Text = "Logs";
            FormMain.instance.PopulateTreeView(pathToLogs, FormMain.instance.treeViewLogs, ".html", ".failed", ".warning");
            FormMain.instance.treeViewLogs.ExpandAll();
            return;
        }

        #endregion

        #region Public methods

        public FormSettings()
        {
            InitializeComponent();
            instance = this;
        }




        #endregion

        
    }
}
