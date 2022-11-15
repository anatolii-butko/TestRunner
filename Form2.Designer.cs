
namespace TestRunner
{
    partial class FormSettings
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
            this.pictureBoxConfigsFolder = new System.Windows.Forms.PictureBox();
            this.textBoxPathToConfigs = new System.Windows.Forms.TextBox();
            this.labelPathToConfigs = new System.Windows.Forms.Label();
            this.pictureBoxRepoFolder = new System.Windows.Forms.PictureBox();
            this.textBoxPathToRepo = new System.Windows.Forms.TextBox();
            this.labelToRepo = new System.Windows.Forms.Label();
            this.pictureBoxToolFolder = new System.Windows.Forms.PictureBox();
            this.textBoxPathToTool = new System.Windows.Forms.TextBox();
            this.labelPathToTool = new System.Windows.Forms.Label();
            this.pictureBoxLogsFolder = new System.Windows.Forms.PictureBox();
            this.textBoxPathToLogs = new System.Windows.Forms.TextBox();
            this.labelPathToLogs = new System.Windows.Forms.Label();
            this.openFileDialogTool = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogRepo = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogConfigs = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogLogs = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfigsFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepoFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToolFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogsFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxConfigsFolder
            // 
            this.pictureBoxConfigsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxConfigsFolder.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxConfigsFolder.Image = global::TestRunner.Properties.Resources.icon_24_folder;
            this.pictureBoxConfigsFolder.Location = new System.Drawing.Point(737, 97);
            this.pictureBoxConfigsFolder.MaximumSize = new System.Drawing.Size(24, 24);
            this.pictureBoxConfigsFolder.MinimumSize = new System.Drawing.Size(24, 24);
            this.pictureBoxConfigsFolder.Name = "pictureBoxConfigsFolder";
            this.pictureBoxConfigsFolder.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxConfigsFolder.TabIndex = 58;
            this.pictureBoxConfigsFolder.TabStop = false;
            this.pictureBoxConfigsFolder.Click += new System.EventHandler(this.PictureBoxConfigsFolder_Click);
            // 
            // textBoxPathToConfigs
            // 
            this.textBoxPathToConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPathToConfigs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathToConfigs.Location = new System.Drawing.Point(199, 96);
            this.textBoxPathToConfigs.Name = "textBoxPathToConfigs";
            this.textBoxPathToConfigs.Size = new System.Drawing.Size(530, 26);
            this.textBoxPathToConfigs.TabIndex = 57;
            this.textBoxPathToConfigs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPathToConfigs_KeyDown);
            // 
            // labelPathToConfigs
            // 
            this.labelPathToConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPathToConfigs.AutoSize = true;
            this.labelPathToConfigs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPathToConfigs.Location = new System.Drawing.Point(12, 99);
            this.labelPathToConfigs.Name = "labelPathToConfigs";
            this.labelPathToConfigs.Size = new System.Drawing.Size(172, 20);
            this.labelPathToConfigs.TabIndex = 56;
            this.labelPathToConfigs.Text = "The path to the configs";
            // 
            // pictureBoxRepoFolder
            // 
            this.pictureBoxRepoFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRepoFolder.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRepoFolder.Image = global::TestRunner.Properties.Resources.icon_24_folder;
            this.pictureBoxRepoFolder.Location = new System.Drawing.Point(737, 57);
            this.pictureBoxRepoFolder.MaximumSize = new System.Drawing.Size(24, 24);
            this.pictureBoxRepoFolder.MinimumSize = new System.Drawing.Size(24, 24);
            this.pictureBoxRepoFolder.Name = "pictureBoxRepoFolder";
            this.pictureBoxRepoFolder.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxRepoFolder.TabIndex = 55;
            this.pictureBoxRepoFolder.TabStop = false;
            this.pictureBoxRepoFolder.Click += new System.EventHandler(this.PictureBoxRepoFolder_Click);
            // 
            // textBoxPathToRepo
            // 
            this.textBoxPathToRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPathToRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathToRepo.Location = new System.Drawing.Point(199, 56);
            this.textBoxPathToRepo.Name = "textBoxPathToRepo";
            this.textBoxPathToRepo.Size = new System.Drawing.Size(530, 26);
            this.textBoxPathToRepo.TabIndex = 54;
            this.textBoxPathToRepo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPathToRepo_KeyDown);
            // 
            // labelToRepo
            // 
            this.labelToRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelToRepo.AutoSize = true;
            this.labelToRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToRepo.Location = new System.Drawing.Point(12, 59);
            this.labelToRepo.Name = "labelToRepo";
            this.labelToRepo.Size = new System.Drawing.Size(153, 20);
            this.labelToRepo.TabIndex = 53;
            this.labelToRepo.Text = "The path to the repo";
            // 
            // pictureBoxToolFolder
            // 
            this.pictureBoxToolFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxToolFolder.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxToolFolder.Image = global::TestRunner.Properties.Resources.icon_24_folder;
            this.pictureBoxToolFolder.Location = new System.Drawing.Point(737, 17);
            this.pictureBoxToolFolder.MaximumSize = new System.Drawing.Size(24, 24);
            this.pictureBoxToolFolder.MinimumSize = new System.Drawing.Size(24, 24);
            this.pictureBoxToolFolder.Name = "pictureBoxToolFolder";
            this.pictureBoxToolFolder.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxToolFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxToolFolder.TabIndex = 52;
            this.pictureBoxToolFolder.TabStop = false;
            this.pictureBoxToolFolder.Click += new System.EventHandler(this.PictureBoxToolFolder_Click);
            // 
            // textBoxPathToTool
            // 
            this.textBoxPathToTool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPathToTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathToTool.Location = new System.Drawing.Point(199, 16);
            this.textBoxPathToTool.Name = "textBoxPathToTool";
            this.textBoxPathToTool.Size = new System.Drawing.Size(530, 26);
            this.textBoxPathToTool.TabIndex = 51;
            this.textBoxPathToTool.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPathToTool_KeyDown);
            // 
            // labelPathToTool
            // 
            this.labelPathToTool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPathToTool.AutoSize = true;
            this.labelPathToTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPathToTool.Location = new System.Drawing.Point(12, 19);
            this.labelPathToTool.Name = "labelPathToTool";
            this.labelPathToTool.Size = new System.Drawing.Size(147, 20);
            this.labelPathToTool.TabIndex = 50;
            this.labelPathToTool.Text = "The path to the tool";
            // 
            // pictureBoxLogsFolder
            // 
            this.pictureBoxLogsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogsFolder.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogsFolder.Image = global::TestRunner.Properties.Resources.icon_24_folder;
            this.pictureBoxLogsFolder.Location = new System.Drawing.Point(737, 137);
            this.pictureBoxLogsFolder.MaximumSize = new System.Drawing.Size(24, 24);
            this.pictureBoxLogsFolder.MinimumSize = new System.Drawing.Size(24, 24);
            this.pictureBoxLogsFolder.Name = "pictureBoxLogsFolder";
            this.pictureBoxLogsFolder.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxLogsFolder.TabIndex = 49;
            this.pictureBoxLogsFolder.TabStop = false;
            this.pictureBoxLogsFolder.Click += new System.EventHandler(this.PictureBoxLogsFolder_Click);
            // 
            // textBoxPathToLogs
            // 
            this.textBoxPathToLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPathToLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathToLogs.Location = new System.Drawing.Point(199, 136);
            this.textBoxPathToLogs.Name = "textBoxPathToLogs";
            this.textBoxPathToLogs.Size = new System.Drawing.Size(530, 26);
            this.textBoxPathToLogs.TabIndex = 48;
            this.textBoxPathToLogs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPathToLogs_KeyDown);
            // 
            // labelPathToLogs
            // 
            this.labelPathToLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPathToLogs.AutoSize = true;
            this.labelPathToLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPathToLogs.Location = new System.Drawing.Point(12, 139);
            this.labelPathToLogs.Name = "labelPathToLogs";
            this.labelPathToLogs.Size = new System.Drawing.Size(150, 20);
            this.labelPathToLogs.TabIndex = 47;
            this.labelPathToLogs.Text = "The path to the logs";
            // 
            // openFileDialogTool
            // 
            this.openFileDialogTool.DefaultExt = "exe";
            this.openFileDialogTool.FileName = "openFileDialogTool";
            this.openFileDialogTool.Filter = "exe files (*.exe)|*.exe";
            this.openFileDialogTool.InitialDirectory = "C:\\";
            this.openFileDialogTool.RestoreDirectory = true;
            // 
            // folderBrowserDialogRepo
            // 
            this.folderBrowserDialogRepo.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialogRepo.ShowNewFolderButton = false;
            // 
            // folderBrowserDialogConfigs
            // 
            this.folderBrowserDialogConfigs.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialogConfigs.ShowNewFolderButton = false;
            // 
            // folderBrowserDialogLogs
            // 
            this.folderBrowserDialogLogs.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 181);
            this.Controls.Add(this.pictureBoxConfigsFolder);
            this.Controls.Add(this.textBoxPathToConfigs);
            this.Controls.Add(this.labelPathToConfigs);
            this.Controls.Add(this.pictureBoxRepoFolder);
            this.Controls.Add(this.textBoxPathToRepo);
            this.Controls.Add(this.labelToRepo);
            this.Controls.Add(this.pictureBoxToolFolder);
            this.Controls.Add(this.textBoxPathToTool);
            this.Controls.Add(this.labelPathToTool);
            this.Controls.Add(this.pictureBoxLogsFolder);
            this.Controls.Add(this.textBoxPathToLogs);
            this.Controls.Add(this.labelPathToLogs);
            this.Name = "FormSettings";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfigsFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepoFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToolFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogsFolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxConfigsFolder;
        public System.Windows.Forms.TextBox textBoxPathToConfigs;
        public System.Windows.Forms.Label labelPathToConfigs;
        public System.Windows.Forms.PictureBox pictureBoxRepoFolder;
        public System.Windows.Forms.TextBox textBoxPathToRepo;
        public System.Windows.Forms.Label labelToRepo;
        public System.Windows.Forms.PictureBox pictureBoxToolFolder;
        public System.Windows.Forms.TextBox textBoxPathToTool;
        public System.Windows.Forms.Label labelPathToTool;
        public System.Windows.Forms.PictureBox pictureBoxLogsFolder;
        public System.Windows.Forms.TextBox textBoxPathToLogs;
        public System.Windows.Forms.Label labelPathToLogs;
        private System.Windows.Forms.OpenFileDialog openFileDialogTool;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogRepo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogConfigs;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogLogs;
    }
}