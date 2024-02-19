using System;
using System.Net;
using System.Windows.Forms;

namespace DxLauncherZ
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

            loadingBar.Value = 0;

            TestInternetConnection();
        }

        private bool internetConnected = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (internetConnected)
            {
                if (loadingBar.Value < 100)
                {
                    loadingBar.Value+=2;
                }
                else
                {
                    timer1.Stop();
                    if (loadingBar.Value == 100)
                    {
                        Login login = new Login();
                        login.Show();
                        Hide();
                        return;
                    }
                }
            }
        }

        private void TestInternetConnection()
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    webClient.DownloadString("https://www.google.com");
                }

                internetConnected = true;
            }
            catch
            {
                MessageBox.Show("No internet connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Stop();
                return;
            }
        }
    }
}
