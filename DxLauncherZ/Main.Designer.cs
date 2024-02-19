namespace DxLauncherZ
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.welcomeText = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.getMCName = new System.Windows.Forms.Label();
            this.loadingBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.backBtn = new FontAwesome.Sharp.IconButton();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.versionsBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.BackColor = System.Drawing.Color.Transparent;
            this.welcomeText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.welcomeText.Location = new System.Drawing.Point(172, 732);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(92, 26);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "WELCOME,";
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(255)))));
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Font = new System.Drawing.Font("Poppins ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.playBtn.Location = new System.Drawing.Point(1160, 735);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(114, 44);
            this.playBtn.TabIndex = 4;
            this.playBtn.Text = "PLAY";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(100, 716);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.playBtn;
            // 
            // getMCName
            // 
            this.getMCName.AutoSize = true;
            this.getMCName.BackColor = System.Drawing.Color.Transparent;
            this.getMCName.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getMCName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.getMCName.Location = new System.Drawing.Point(172, 751);
            this.getMCName.Name = "getMCName";
            this.getMCName.Size = new System.Drawing.Size(66, 31);
            this.getMCName.TabIndex = 6;
            this.getMCName.Text = "Erato";
            // 
            // loadingBar
            // 
            this.loadingBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.loadingBar.Location = new System.Drawing.Point(80, 697);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.loadingBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(191)))));
            this.loadingBar.Size = new System.Drawing.Size(1220, 5);
            this.loadingBar.TabIndex = 7;
            this.loadingBar.Text = "guna2ProgressBar1";
            this.loadingBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 16;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.backBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.backBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(54)))));
            this.backBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backBtn.IconSize = 22;
            this.backBtn.Location = new System.Drawing.Point(20, 734);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(40, 40);
            this.backBtn.TabIndex = 9;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 16;
            this.guna2Elipse3.TargetControl = this.backBtn;
            // 
            // versionsBox
            // 
            this.versionsBox.BackColor = System.Drawing.Color.Transparent;
            this.versionsBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.versionsBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.versionsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionsBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.versionsBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.versionsBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.versionsBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.versionsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.versionsBox.ItemHeight = 30;
            this.versionsBox.Location = new System.Drawing.Point(886, 740);
            this.versionsBox.Name = "versionsBox";
            this.versionsBox.Size = new System.Drawing.Size(252, 36);
            this.versionsBox.TabIndex = 10;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(1180, 0);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(60, 60);
            this.guna2ControlBox2.TabIndex = 12;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2ControlBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(1240, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 60);
            this.guna2ControlBox1.TabIndex = 11;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.versionsBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.getMCName);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcomeText);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button playBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label getMCName;
        private Guna.UI2.WinForms.Guna2ProgressBar loadingBar;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private FontAwesome.Sharp.IconButton backBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2ComboBox versionsBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}