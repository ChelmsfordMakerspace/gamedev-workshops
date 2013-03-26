namespace Setup
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("MonoDevelop");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Mono Game");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Software", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.tableLayoutPanel_Master = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Header = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.button_Install = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.splitContainer_Install = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.treeView_Software = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_CurrentItemInstalling = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox_locations = new System.Windows.Forms.GroupBox();
            this.checkBox_Keep = new System.Windows.Forms.CheckBox();
            this.checkBox_FilesFromInternet = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.installerWorker = new System.ComponentModel.BackgroundWorker();
            this.checkBox_dataonly = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel_Master.SuspendLayout();
            this.tableLayoutPanel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.tableLayoutPanel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Install)).BeginInit();
            this.splitContainer_Install.Panel1.SuspendLayout();
            this.splitContainer_Install.Panel2.SuspendLayout();
            this.splitContainer_Install.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_locations.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Master
            // 
            this.tableLayoutPanel_Master.ColumnCount = 1;
            this.tableLayoutPanel_Master.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Master.Controls.Add(this.tableLayoutPanel_Header, 0, 0);
            this.tableLayoutPanel_Master.Controls.Add(this.tableLayoutPanel_Buttons, 0, 2);
            this.tableLayoutPanel_Master.Controls.Add(this.splitContainer_Install, 0, 1);
            this.tableLayoutPanel_Master.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Master.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Master.Name = "tableLayoutPanel_Master";
            this.tableLayoutPanel_Master.RowCount = 3;
            this.tableLayoutPanel_Master.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.66376F));
            this.tableLayoutPanel_Master.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.33624F));
            this.tableLayoutPanel_Master.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel_Master.Size = new System.Drawing.Size(787, 479);
            this.tableLayoutPanel_Master.TabIndex = 0;
            // 
            // tableLayoutPanel_Header
            // 
            this.tableLayoutPanel_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel_Header.ColumnCount = 2;
            this.tableLayoutPanel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 597F));
            this.tableLayoutPanel_Header.Controls.Add(this.pictureBox_Logo, 0, 0);
            this.tableLayoutPanel_Header.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Header.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Header.Name = "tableLayoutPanel_Header";
            this.tableLayoutPanel_Header.RowCount = 1;
            this.tableLayoutPanel_Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Header.Size = new System.Drawing.Size(781, 48);
            this.tableLayoutPanel_Header.TabIndex = 0;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = global::Setup.Properties.Resources.logo1;
            this.pictureBox_Logo.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(178, 42);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chelmsford Makerspace - Game Development Workshop Prerequsites";
            // 
            // tableLayoutPanel_Buttons
            // 
            this.tableLayoutPanel_Buttons.ColumnCount = 3;
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.67213F));
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.32787F));
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel_Buttons.Controls.Add(this.button_Install, 2, 1);
            this.tableLayoutPanel_Buttons.Controls.Add(this.button_Cancel, 1, 1);
            this.tableLayoutPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Buttons.Location = new System.Drawing.Point(3, 435);
            this.tableLayoutPanel_Buttons.Name = "tableLayoutPanel_Buttons";
            this.tableLayoutPanel_Buttons.RowCount = 2;
            this.tableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.82927F));
            this.tableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.17073F));
            this.tableLayoutPanel_Buttons.Size = new System.Drawing.Size(781, 41);
            this.tableLayoutPanel_Buttons.TabIndex = 1;
            // 
            // button_Install
            // 
            this.button_Install.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Install.Location = new System.Drawing.Point(688, 14);
            this.button_Install.Name = "button_Install";
            this.button_Install.Size = new System.Drawing.Size(75, 23);
            this.button_Install.TabIndex = 0;
            this.button_Install.Text = "Install";
            this.button_Install.UseVisualStyleBackColor = true;
            this.button_Install.Click += new System.EventHandler(this.button_Install_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(618, 14);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(64, 23);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // splitContainer_Install
            // 
            this.splitContainer_Install.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Install.Location = new System.Drawing.Point(3, 57);
            this.splitContainer_Install.Name = "splitContainer_Install";
            // 
            // splitContainer_Install.Panel1
            // 
            this.splitContainer_Install.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer_Install.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer_Install.Panel2
            // 
            this.splitContainer_Install.Panel2.Controls.Add(this.treeView_Software);
            this.splitContainer_Install.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer_Install.Panel2.Controls.Add(this.groupBox_locations);
            this.splitContainer_Install.Size = new System.Drawing.Size(781, 372);
            this.splitContainer_Install.SplitterDistance = 242;
            this.splitContainer_Install.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 208);
            this.label6.TabIndex = 0;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // treeView_Software
            // 
            this.treeView_Software.CheckBoxes = true;
            this.treeView_Software.Location = new System.Drawing.Point(3, 3);
            this.treeView_Software.Name = "treeView_Software";
            treeNode1.Checked = true;
            treeNode1.Name = "Node_MNODV";
            treeNode1.Tag = "MONODEV";
            treeNode1.Text = "MonoDevelop";
            treeNode2.Checked = true;
            treeNode2.Name = "Node_GME";
            treeNode2.Tag = "GAME";
            treeNode2.Text = "Mono Game";
            treeNode3.Name = "Node_Software";
            treeNode3.Text = "Software";
            this.treeView_Software.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView_Software.Size = new System.Drawing.Size(528, 199);
            this.treeView_Software.TabIndex = 10;
            this.treeView_Software.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Software_NodeMouseClick);
            this.treeView_Software.Layout += new System.Windows.Forms.LayoutEventHandler(this.treeView_Software_Layout);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_CurrentItemInstalling);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.progressBar);
            this.groupBox2.Location = new System.Drawing.Point(3, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 62);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Progress";
            // 
            // label_CurrentItemInstalling
            // 
            this.label_CurrentItemInstalling.AutoSize = true;
            this.label_CurrentItemInstalling.Location = new System.Drawing.Point(79, 16);
            this.label_CurrentItemInstalling.Name = "label_CurrentItemInstalling";
            this.label_CurrentItemInstalling.Size = new System.Drawing.Size(33, 13);
            this.label_CurrentItemInstalling.TabIndex = 2;
            this.label_CurrentItemInstalling.Text = "None";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Item:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(9, 32);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(508, 23);
            this.progressBar.TabIndex = 0;
            // 
            // groupBox_locations
            // 
            this.groupBox_locations.Controls.Add(this.checkBox_dataonly);
            this.groupBox_locations.Controls.Add(this.checkBox_Keep);
            this.groupBox_locations.Controls.Add(this.checkBox_FilesFromInternet);
            this.groupBox_locations.Location = new System.Drawing.Point(3, 208);
            this.groupBox_locations.Name = "groupBox_locations";
            this.groupBox_locations.Size = new System.Drawing.Size(523, 93);
            this.groupBox_locations.TabIndex = 8;
            this.groupBox_locations.TabStop = false;
            this.groupBox_locations.Text = "Locations";
            // 
            // checkBox_Keep
            // 
            this.checkBox_Keep.AutoSize = true;
            this.checkBox_Keep.Enabled = false;
            this.checkBox_Keep.Location = new System.Drawing.Point(9, 42);
            this.checkBox_Keep.Name = "checkBox_Keep";
            this.checkBox_Keep.Size = new System.Drawing.Size(159, 17);
            this.checkBox_Keep.TabIndex = 9;
            this.checkBox_Keep.Text = "Keep files after downloading";
            this.checkBox_Keep.UseVisualStyleBackColor = true;
            // 
            // checkBox_FilesFromInternet
            // 
            this.checkBox_FilesFromInternet.AutoSize = true;
            this.checkBox_FilesFromInternet.Location = new System.Drawing.Point(9, 19);
            this.checkBox_FilesFromInternet.Name = "checkBox_FilesFromInternet";
            this.checkBox_FilesFromInternet.Size = new System.Drawing.Size(147, 17);
            this.checkBox_FilesFromInternet.TabIndex = 8;
            this.checkBox_FilesFromInternet.Text = "Get Files from the Internet";
            this.checkBox_FilesFromInternet.UseVisualStyleBackColor = true;
            this.checkBox_FilesFromInternet.CheckedChanged += new System.EventHandler(this.checkBox_FilesFromInternet_CheckedChanged);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // installerWorker
            // 
            this.installerWorker.WorkerReportsProgress = true;
            this.installerWorker.WorkerSupportsCancellation = true;
            this.installerWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StartInstall);
            this.installerWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.UpdateUI);
            this.installerWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FinishedInstall);
            // 
            // checkBox_dataonly
            // 
            this.checkBox_dataonly.AutoSize = true;
            this.checkBox_dataonly.Location = new System.Drawing.Point(9, 65);
            this.checkBox_dataonly.Name = "checkBox_dataonly";
            this.checkBox_dataonly.Size = new System.Drawing.Size(130, 17);
            this.checkBox_dataonly.TabIndex = 10;
            this.checkBox_dataonly.Text = "Don\'t execute installer";
            this.checkBox_dataonly.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(787, 479);
            this.Controls.Add(this.tableLayoutPanel_Master);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Game Development Workshop Setup";
            this.tableLayoutPanel_Master.ResumeLayout(false);
            this.tableLayoutPanel_Header.ResumeLayout(false);
            this.tableLayoutPanel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.tableLayoutPanel_Buttons.ResumeLayout(false);
            this.splitContainer_Install.Panel1.ResumeLayout(false);
            this.splitContainer_Install.Panel1.PerformLayout();
            this.splitContainer_Install.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Install)).EndInit();
            this.splitContainer_Install.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_locations.ResumeLayout(false);
            this.groupBox_locations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Master;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Header;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Buttons;
        private System.Windows.Forms.Button button_Install;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.SplitContainer splitContainer_Install;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_CurrentItemInstalling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox_locations;
        private System.Windows.Forms.CheckBox checkBox_FilesFromInternet;
        private System.Windows.Forms.TreeView treeView_Software;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.ComponentModel.BackgroundWorker installerWorker;
        private System.Windows.Forms.CheckBox checkBox_Keep;
        private System.Windows.Forms.CheckBox checkBox_dataonly;
    }
}

