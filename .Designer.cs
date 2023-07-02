namespace IS1_20_BorinM.A
{
    partial class Registration
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.login = new MetroFramework.Controls.MetroTextBox();
            this.Pass = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(407, 285);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(103, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Войти";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(298, 285);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(103, 23);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Выйти";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // login
            // 
            // 
            // 
            // 
            this.login.CustomButton.Image = null;
            this.login.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.login.CustomButton.Name = "";
            this.login.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login.CustomButton.TabIndex = 1;
            this.login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login.CustomButton.UseSelectable = true;
            this.login.CustomButton.Visible = false;
            this.login.Lines = new string[0];
            this.login.Location = new System.Drawing.Point(330, 179);
            this.login.MaxLength = 32767;
            this.login.Name = "login";
            this.login.PasswordChar = '\0';
            this.login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login.SelectedText = "";
            this.login.SelectionLength = 0;
            this.login.SelectionStart = 0;
            this.login.ShortcutsEnabled = true;
            this.login.Size = new System.Drawing.Size(141, 23);
            this.login.TabIndex = 2;
            this.login.UseSelectable = true;
            this.login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Pass
            // 
            // 
            // 
            // 
            this.Pass.CustomButton.Image = null;
            this.Pass.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.Pass.CustomButton.Name = "";
            this.Pass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Pass.CustomButton.TabIndex = 1;
            this.Pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Pass.CustomButton.UseSelectable = true;
            this.Pass.CustomButton.Visible = false;
            this.Pass.Lines = new string[0];
            this.Pass.Location = new System.Drawing.Point(330, 227);
            this.Pass.MaxLength = 32767;
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '\0';
            this.Pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Pass.SelectedText = "";
            this.Pass.SelectionLength = 0;
            this.Pass.SelectionStart = 0;
            this.Pass.ShortcutsEnabled = true;
            this.Pass.Size = new System.Drawing.Size(141, 23);
            this.Pass.TabIndex = 3;
            this.Pass.UseSelectable = true;
            this.Pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 5);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(297, 359);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(330, 157);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Username";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(330, 205);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(376, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(315, 110);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(169, 29);
            this.metroComboBox1.TabIndex = 8;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 360);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.login);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Name = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox login;
        private MetroFramework.Controls.MetroTextBox Pass;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}

