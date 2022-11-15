
namespace TestRunner
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BatFileContent = new System.Windows.Forms.TabPage();
            this.richTextBoxBatFileContent = new System.Windows.Forms.RichTextBox();
            this.Logs = new System.Windows.Forms.TabPage();
            this.treeViewLogs = new System.Windows.Forms.TreeView();
            this.treeViewConfigs = new System.Windows.Forms.TreeView();
            this.treeViewRepo = new System.Windows.Forms.TreeView();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.openFileDialogBat = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogBat = new System.Windows.Forms.SaveFileDialog();
            this.imageListRepo = new System.Windows.Forms.ImageList(this.components);
            this.imageListConfigs = new System.Windows.Forms.ImageList(this.components);
            this.checkBoxHtmlOnly = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.BatFileContent.SuspendLayout();
            this.Logs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BatFileContent);
            this.tabControl1.Controls.Add(this.Logs);
            this.tabControl1.Location = new System.Drawing.Point(855, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 567);
            this.tabControl1.TabIndex = 0;
            // 
            // BatFileContent
            // 
            this.BatFileContent.Controls.Add(this.richTextBoxBatFileContent);
            this.BatFileContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatFileContent.Location = new System.Drawing.Point(4, 29);
            this.BatFileContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BatFileContent.Name = "BatFileContent";
            this.BatFileContent.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BatFileContent.Size = new System.Drawing.Size(402, 534);
            this.BatFileContent.TabIndex = 0;
            this.BatFileContent.Text = ".bat";
            this.BatFileContent.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBatFileContent
            // 
            this.richTextBoxBatFileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxBatFileContent.Location = new System.Drawing.Point(4, 5);
            this.richTextBoxBatFileContent.Name = "richTextBoxBatFileContent";
            this.richTextBoxBatFileContent.Size = new System.Drawing.Size(394, 524);
            this.richTextBoxBatFileContent.TabIndex = 0;
            this.richTextBoxBatFileContent.Text = "";
            // 
            // Logs
            // 
            this.Logs.Controls.Add(this.treeViewLogs);
            this.Logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs.Location = new System.Drawing.Point(4, 29);
            this.Logs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logs.Name = "Logs";
            this.Logs.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logs.Size = new System.Drawing.Size(402, 534);
            this.Logs.TabIndex = 1;
            this.Logs.Text = "Logs";
            this.Logs.UseVisualStyleBackColor = true;
            // 
            // treeViewLogs
            // 
            this.treeViewLogs.CheckBoxes = true;
            this.treeViewLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewLogs.Location = new System.Drawing.Point(4, 5);
            this.treeViewLogs.Name = "treeViewLogs";
            this.treeViewLogs.Size = new System.Drawing.Size(394, 524);
            this.treeViewLogs.TabIndex = 3;
            this.treeViewLogs.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewLogs_NodeMouseDoubleClick);
            // 
            // treeViewConfigs
            // 
            this.treeViewConfigs.CheckBoxes = true;
            this.treeViewConfigs.Location = new System.Drawing.Point(437, 18);
            this.treeViewConfigs.Name = "treeViewConfigs";
            this.treeViewConfigs.Size = new System.Drawing.Size(402, 567);
            this.treeViewConfigs.TabIndex = 1;
            this.treeViewConfigs.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewConfigs_AfterCheck);
            this.treeViewConfigs.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewConfigs_NodeMouseDoubleClick);
            // 
            // treeViewRepo
            // 
            this.treeViewRepo.CheckBoxes = true;
            this.treeViewRepo.Location = new System.Drawing.Point(19, 18);
            this.treeViewRepo.Name = "treeViewRepo";
            this.treeViewRepo.Size = new System.Drawing.Size(402, 567);
            this.treeViewRepo.TabIndex = 2;
            this.treeViewRepo.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewRepo_AfterCheck);
            this.treeViewRepo.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewRepo_NodeMouseDoubleClick);
            this.treeViewRepo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeViewRepo_MouseDown);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.DarkGray;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(855, 607);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(30, 30);
            this.buttonHelp.TabIndex = 12;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.White;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(891, 606);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(80, 30);
            this.buttonLoad.TabIndex = 14;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.BackColor = System.Drawing.Color.White;
            this.buttonSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveAs.Location = new System.Drawing.Point(988, 607);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(80, 30);
            this.buttonSaveAs.TabIndex = 25;
            this.buttonSaveAs.Text = "SaveAs";
            this.buttonSaveAs.UseVisualStyleBackColor = false;
            this.buttonSaveAs.Click += new System.EventHandler(this.ButtonSaveAs_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.White;
            this.buttonClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClean.Location = new System.Drawing.Point(1085, 607);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(80, 30);
            this.buttonClean.TabIndex = 26;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.ButtonClean_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Location = new System.Drawing.Point(1181, 607);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(80, 30);
            this.buttonRun.TabIndex = 27;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.White;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Location = new System.Drawing.Point(744, 607);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(80, 30);
            this.buttonSettings.TabIndex = 28;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // openFileDialogBat
            // 
            this.openFileDialogBat.DefaultExt = "bat";
            this.openFileDialogBat.FileName = "openFileDialogBat";
            this.openFileDialogBat.Filter = "bat files (*.bat)|*.bat";
            this.openFileDialogBat.InitialDirectory = "C:\\";
            // 
            // saveFileDialogBat
            // 
            this.saveFileDialogBat.CheckPathExists = false;
            this.saveFileDialogBat.CreatePrompt = true;
            this.saveFileDialogBat.FileName = "123";
            this.saveFileDialogBat.Filter = "bat files (*.bat)|*.bat";
            this.saveFileDialogBat.InitialDirectory = "C:\\";
            this.saveFileDialogBat.RestoreDirectory = true;
            // 
            // imageListRepo
            // 
            this.imageListRepo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListRepo.ImageStream")));
            this.imageListRepo.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListRepo.Images.SetKeyName(0, "icon-24-folder.png");
            this.imageListRepo.Images.SetKeyName(1, "icon-24-file.png");
            // 
            // imageListConfigs
            // 
            this.imageListConfigs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListConfigs.ImageStream")));
            this.imageListConfigs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListConfigs.Images.SetKeyName(0, "icon-24-folder.png");
            this.imageListConfigs.Images.SetKeyName(1, "icon-24-file.png");
            // 
            // checkBoxHtmlOnly
            // 
            this.checkBoxHtmlOnly.AutoSize = true;
            this.checkBoxHtmlOnly.Location = new System.Drawing.Point(618, 610);
            this.checkBoxHtmlOnly.Name = "checkBoxHtmlOnly";
            this.checkBoxHtmlOnly.Size = new System.Drawing.Size(90, 24);
            this.checkBoxHtmlOnly.TabIndex = 29;
            this.checkBoxHtmlOnly.Text = "html only";
            this.checkBoxHtmlOnly.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 649);
            this.Controls.Add(this.checkBoxHtmlOnly);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.treeViewRepo);
            this.Controls.Add(this.treeViewConfigs);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "TestRunnerGUI";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.BatFileContent.ResumeLayout(false);
            this.Logs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BatFileContent;
        private System.Windows.Forms.TabPage Logs;
        public System.Windows.Forms.TreeView treeViewLogs;
        public System.Windows.Forms.TreeView treeViewConfigs;
        public System.Windows.Forms.TreeView treeViewRepo;
        public System.Windows.Forms.RichTextBox richTextBoxBatFileContent;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.OpenFileDialog openFileDialogBat;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBat;
        private System.Windows.Forms.ImageList imageListRepo;
        private System.Windows.Forms.ImageList imageListConfigs;
        private System.Windows.Forms.CheckBox checkBoxHtmlOnly;
    }
}

