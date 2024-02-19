using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DxLauncherZ
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Init_Data();
        }

        public static string username;

        private void loginBtn_Click(object sender, EventArgs e)
        {
            username = mcUsername.Text.ToLower();
            if (!string.IsNullOrEmpty(mcUsername.Text) && Regex.IsMatch(mcUsername.Text, "^[a-zA-Z]+$"))
            {
                if (username.Length < 3)
                {
                    MessageBox.Show("The name you entered is too short. Please enter a name with at least 3 characters.!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Main main = new Main();
                    main.Show();
                    Hide();
                    Save_Data();
                }
            }
        }

        private void mcUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";

            if (!allowedCharacters.Contains(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (mcUsername.Text.Length >= 16 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/kWsArfAsGG");
        }

        private void guna2Panel2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Eratonos");
        }

        private void Init_Data()
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                if (Properties.Settings.Default.RememberMe == true)
                {
                    mcUsername.Text = Properties.Settings.Default.Username;
                    rememberMe.Checked = true;
                }
                else
                {
                    mcUsername.Text = Properties.Settings.Default.Username;
                }
            }
        }

        private void Save_Data()
        {
            if (rememberMe.Checked)
            {
                Properties.Settings.Default.Username = mcUsername.Text.Trim();
                Properties.Settings.Default.RememberMe = true;
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.RememberMe = false;
            }
            Properties.Settings.Default.Save();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
