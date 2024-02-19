using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;
using System.Threading;
using CmlLib.Core.Version;
using CmlLib.Core.Downloader;
using Microsoft.SqlServer.Server;

namespace DxLauncherZ
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static string version;

        private void Main_Load(object sender, EventArgs e)
        {
            path();

            getMCName.Text = $"Hos Geldin {Login.username}";
            var request = WebRequest.Create($"https://cravatar.eu/helmhead/{Login.username}/60.png");
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
        }

        private void path()
        {
            System.Net.ServicePointManager.DefaultConnectionLimit = 256;

            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);

            //launcher.FileChanged += Downloader_ChangeFile;
            launcher.ProgressChanged += Downloader_ChangeProgress;

            foreach (var item in launcher.GetAllVersions())
            {
                versionsBox.Items.Add(item.Name);
            }
        }

        private void launch()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);
            //launcher.FileChanged += Downloader_ChangeFile;
            launcher.ProgressChanged += Downloader_ChangeProgress;

            if (versionsBox.InvokeRequired)
            {
                versionsBox.Invoke((MethodInvoker)delegate
                {
                    version = versionsBox.SelectedItem.ToString();
                });
            }
            else
            {
                version = versionsBox.SelectedItem.ToString();
            }

            var launchOption = new MLaunchOption()
            {
                Path = new MinecraftPath(),
                MaximumRamMb = 4096,

                ScreenWidth = 1600,
                ScreenHeight = 900,

                VersionType = "DxLauncherZ",
                GameLauncherName = "DxLauncherZ",
                GameLauncherVersion = "1",
                Session = MSession.CreateOfflineSession(Login.username),

                FullScreen = false,
            };

            var process = launcher.CreateProcess(version, launchOption);
            process.Start();
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Hide();
                });
            }
            else
            {
                Hide();
            }
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            playBtn.Enabled = false;
            Thread thread = new Thread(() => launch());
            thread.Start();
        }

        private void Downloader_ChangeProgress(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (loadingBar.InvokeRequired)
            {
                loadingBar.Invoke((MethodInvoker)delegate
                {
                    loadingBar.Value = e.ProgressPercentage;
                });
            }
            else
            {
                loadingBar.Value = e.ProgressPercentage;
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*private void Downloader_ChangeFile(DownloadFileChangedEventArgs e)
        {
            if (cmdDownload.InvokeRequired)
            {
                cmdDownload.Invoke((MethodInvoker)delegate
                {
                    cmdDownload.Items.Add(String.Format("[{0}] ({2}/{3}) {1}  ", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount));
                });
            }
            else
            {
                cmdDownload.Items.Add(String.Format("[{0}] ({2}/{3}) {1}  ", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount));
            }
        }*/
    }
}
