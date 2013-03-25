using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
namespace Setup
{
    public partial class MainForm : Form
    {

        static string CurrentTask = "None";
        bool ifWorked = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox_Locations_Projects_Layout(object sender, LayoutEventArgs e)
        {
            textBox_Locations_Projects.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CMSGameDevProjects";
        }

        private void button_browse_project_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyDocuments;
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox_Locations_Projects.Text = folderBrowserDialog.SelectedPath;

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartInstall(object sender, DoWorkEventArgs e)
        {
            //This is the big one.
            List<string> toInstall = new List<string>();
            //Step One - Validate all fields.
            string valid = "";

                //Software
                foreach (TreeNode prnode in treeView_Software.Nodes)
                {
                    foreach (TreeNode node in prnode.Nodes)
                    {
                        if (node.Checked == true)
                            toInstall.Add(node.Tag.ToString());
                    }
                }

                if (toInstall.Count < 1)
                    valid += "You have not selected any packages to install!" + Environment.NewLine;

                //Internet
                if(checkBox_FilesFromInternet.Checked)
                    if(!CheckConnection())
                        valid += "You do not appear to be connected to the internet!" + Environment.NewLine;

                if (string.Empty != valid)
                {
                 MessageBox.Show(this, valid, "Error installing...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 ifWorked = false;
                 return;
                }

                //Check data directory exists
                if (!Directory.Exists("Data"))
                    Directory.CreateDirectory("Data");

                foreach (string item in toInstall)
                {

                    Process p;
                    switch (item)
                    {
                        case "MONODEV":
                            if (checkBox_FilesFromInternet.Checked)
                            {
                                CurrentTask = "Downloading DotNet3.5";
                                installerWorker.ReportProgress(0);
                                DownloadFile("http://download.microsoft.com/download/6/0/f/60fc5854-3cb8-4892-b6db-bd4f42510f28/dotnetfx35.exe", @"Data\setup.exe");
                                CurrentTask = "Downloading MonoDevelop";
                                installerWorker.ReportProgress(15);
                                DownloadFile("http://heanet.dl.sourceforge.net/project/monodevelop.mirror/MonoDevelop%203.0.6/MonoDevelop-3.0.6.msi", @"Data\setup2.msi");
                                CurrentTask = "Downloading GTKSharp";
                                installerWorker.ReportProgress(30);
                                DownloadFile("http://roh-arbiter.googlecode.com/files/gtk-sharp-2.12.9-2.win32.msi", @"Data\setup1.msi");
                                installerWorker.ReportProgress(45);
                            }

                            if (!File.Exists(@"Data\setup.exe") || !File.Exists(@"Data\setup2.msi") || !File.Exists(@"Data\setup1.msi"))
                            {
                                MessageBox.Show("You are missing one or more of the required files for install.", "Error installing...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ifWorked = false;
                                break;
                            }

                            //DotNet3.5
                            CurrentTask = "Installing DotNet3.5";
                            installerWorker.ReportProgress(60);
                            p = Process.Start(@"Data\setup.exe");
                            while (!p.HasExited) { System.Threading.Thread.Sleep(500); }
                            
                            
                            //GTK-Sharp
                            CurrentTask = "Installing GTK Sharp";
                            installerWorker.ReportProgress(75);
                            p = Process.Start(@"msiexec", @" /i Data\setup1.msi /qn ");
                            while (!p.HasExited) { System.Threading.Thread.Sleep(500); }
                            

                            //MonoDevelop
                            CurrentTask = "Installing MonoDevelop";
                            installerWorker.ReportProgress(90);
                            p = Process.Start(@"msiexec",@" /i Data\setup2.msi /qn ");
                            while (!p.HasExited) { System.Threading.Thread.Sleep(500); }

                            installerWorker.ReportProgress(100);
                            break;
                        case "GAME":

                            if (checkBox_FilesFromInternet.Checked)
                            {
                                CurrentTask = "Downloading OpenTK";
                                installerWorker.ReportProgress(0);
                                DownloadFile("http://downloads.sourceforge.net/project/opentk/opentk/opentk-1.0/2010-10-06/opentk-2010-10-06.exe?r=&ts=1363629504&use_mirror=switch", @"Data\setup.exe");
                            }

                            if (!File.Exists(@"Data\setup.exe"))
                            {
                                MessageBox.Show("You are missing one or more of the required files for install.", "Error installing...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ifWorked = false;
                                break;
                            }

                            //OpenTK
                            CurrentTask = "Installing OpenTK";
                            installerWorker.ReportProgress(25);
                            p = Process.Start(@"Data\setup.exe");
                            while (!p.HasExited) { System.Threading.Thread.Sleep(500); }

                            installerWorker.ReportProgress(50);

                            if (checkBox_FilesFromInternet.Checked)
                            {
                                CurrentTask = "Downloading MonoGame";
                                installerWorker.ReportProgress(75);
                                DownloadFile("http://monogame.codeplex.com/downloads/get/606112", @"Data\MonoGame.mpack");
                            }

                            if (!File.Exists(@"Data\MonoGame.mpack"))
                            {
                                MessageBox.Show("You are missing the MonoGame Addon file (MonoGame.mpack). You may continue but you must download it yourself.", "Error installing...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            CurrentTask = "Infomation";
                            installerWorker.ReportProgress(100);
                            MessageBox.Show("To complete the install of MonoGame, please read readme.txt. You must install monogame manually.", "Manual Steps Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Process.Start("readme.txt");
                            break;
                        case "Pro_1":
                            CurrentTask = "Space Invaders";
                            break;
                        case "Pro_2":
                            CurrentTask = "Side Scroller";
                            break;
                        case "Doc":
                            CurrentTask = "Documentation";
                            break;
                        default:

                            break;
                    }
                }
                CurrentTask = "Removing Tempoary Files";
                if (!checkBox_Keep.Checked)
                    Directory.Delete("Data",true);
                CurrentTask = "Done";

        }

        private bool CheckConnection()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.google.co.uk");
                request.Timeout = 10000;
                request.Credentials = CredentialCache.DefaultNetworkCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK) return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }

        private void DownloadFile(string file, string savefile)
        {
            WebClient wclient = new WebClient();
            if (File.Exists(savefile))
                return;
            wclient.DownloadFile(file, savefile);
        }

        private void button_Install_Click(object sender, EventArgs e)
        {
            installerWorker.RunWorkerAsync();
            //Disable controls
            treeView_Software.Enabled = false;
            groupBox_locations.Enabled = false;
            button_Cancel.Enabled = false;
            button_Install.Enabled = false;
        }

        private void treeView_Software_Layout(object sender, LayoutEventArgs e)
        {
            //Check to see if installed.
            treeView_Software.Nodes[1].BackColor = Color.DarkGray;
            if (!treeView_Software.Nodes[1].Text.Contains("(Not Ready Yet)"))
            {
                treeView_Software.Nodes[1].Text += "(Not Ready Yet)";
            }
           
            foreach (TreeNode item in treeView_Software.Nodes[0].Nodes)
            {
                switch (item.Tag.ToString())
	            {
                    case "MONODEV":
                        if (item.Text.Contains("(Installed)")) { break; }

                        if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\MonoDevelop"))
                        {
                            item.BackColor = Color.DarkGray;
                            item.Text += "(Installed)";
                            item.Checked = false;
                        }
                        break;
		            default:
                        break;
	            }
                }

            }

        private void treeView_Software_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach (TreeNode node in e.Node.Nodes)
            {
                node.Checked = e.Node.Checked;
            }
        }

        private void UpdateUI(object sender, ProgressChangedEventArgs e)
        {
            label_CurrentItemInstalling.Text = CurrentTask;
            progressBar.Value = e.ProgressPercentage;
        }

        private void FinishedInstall(object sender, RunWorkerCompletedEventArgs e)
        {
            if (ifWorked)
            {
                MessageBox.Show(this, "Your files are now installed and ready to use. The program will now close.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void checkBox_FilesFromInternet_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Keep.Enabled = checkBox_FilesFromInternet.Checked;
            if (!checkBox_FilesFromInternet.Checked)
                checkBox_Keep.Checked = false;
        }

    }
}
