namespace SportShop
{
    partial class Authorization
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.txtBox_Login = new System.Windows.Forms.TextBox();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.panelUp = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.panelDown = new System.Windows.Forms.Panel();
            this.btnEnterAsGuest = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBoxCapcha = new System.Windows.Forms.TextBox();
            this.btnCapcha = new System.Windows.Forms.Button();
            this.pictureBoxCapcha = new System.Windows.Forms.PictureBox();
            this.timerForBlocking = new System.Windows.Forms.Timer(this.components);
            this.imageListCapcha = new System.Windows.Forms.ImageList(this.components);
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapcha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_Login
            // 
            this.txtBox_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.txtBox_Login.Location = new System.Drawing.Point(120, 147);
            this.txtBox_Login.Name = "txtBox_Login";
            this.txtBox_Login.Size = new System.Drawing.Size(170, 20);
            this.txtBox_Login.TabIndex = 0;
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.txtBox_Password.Location = new System.Drawing.Point(120, 201);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(170, 20);
            this.txtBox_Password.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnEnter.Location = new System.Drawing.Point(163, 21);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(86, 42);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panelUp.Controls.Add(this.pictureBoxLogo);
            this.panelUp.Controls.Add(this.lblname);
            this.panelUp.Location = new System.Drawing.Point(-2, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(414, 114);
            this.panelUp.TabIndex = 3;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(288, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(123, 108);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblname.Location = new System.Drawing.Point(14, 36);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(229, 18);
            this.lblname.TabIndex = 7;
            this.lblname.Text = "ООО \"Спортивный магазин\"";
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panelDown.Controls.Add(this.btnEnterAsGuest);
            this.panelDown.Controls.Add(this.btnEnter);
            this.panelDown.Location = new System.Drawing.Point(-2, 347);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(413, 114);
            this.panelDown.TabIndex = 4;
            // 
            // btnEnterAsGuest
            // 
            this.btnEnterAsGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnEnterAsGuest.Location = new System.Drawing.Point(152, 69);
            this.btnEnterAsGuest.Name = "btnEnterAsGuest";
            this.btnEnterAsGuest.Size = new System.Drawing.Size(106, 33);
            this.btnEnterAsGuest.TabIndex = 3;
            this.btnEnterAsGuest.Text = "Войти как гость";
            this.btnEnterAsGuest.UseVisualStyleBackColor = false;
            this.btnEnterAsGuest.Click += new System.EventHandler(this.btnEnterAsGuest_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(185, 131);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Логин";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(185, 185);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Пароль";
            // 
            // textBoxCapcha
            // 
            this.textBoxCapcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.textBoxCapcha.Location = new System.Drawing.Point(120, 310);
            this.textBoxCapcha.Name = "textBoxCapcha";
            this.textBoxCapcha.Size = new System.Drawing.Size(85, 20);
            this.textBoxCapcha.TabIndex = 7;
            // 
            // btnCapcha
            // 
            this.btnCapcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnCapcha.Location = new System.Drawing.Point(221, 309);
            this.btnCapcha.Name = "btnCapcha";
            this.btnCapcha.Size = new System.Drawing.Size(93, 21);
            this.btnCapcha.TabIndex = 4;
            this.btnCapcha.Text = "Ввод";
            this.btnCapcha.UseVisualStyleBackColor = false;
            this.btnCapcha.Click += new System.EventHandler(this.btnCapcha_Click);
            // 
            // pictureBoxCapcha
            // 
            this.pictureBoxCapcha.Location = new System.Drawing.Point(133, 239);
            this.pictureBoxCapcha.Name = "pictureBoxCapcha";
            this.pictureBoxCapcha.Size = new System.Drawing.Size(157, 64);
            this.pictureBoxCapcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCapcha.TabIndex = 9;
            this.pictureBoxCapcha.TabStop = false;
            // 
            // timerForBlocking
            // 
            this.timerForBlocking.Tick += new System.EventHandler(this.timerForBlocking_Tick);
            // 
            // imageListCapcha
            // 
            this.imageListCapcha.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListCapcha.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListCapcha.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(411, 458);
            this.Controls.Add(this.pictureBoxCapcha);
            this.Controls.Add(this.btnCapcha);
            this.Controls.Add(this.textBoxCapcha);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.txtBox_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Login;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnEnterAsGuest;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxCapcha;
        private System.Windows.Forms.Button btnCapcha;
        private System.Windows.Forms.PictureBox pictureBoxCapcha;
        private System.Windows.Forms.Timer timerForBlocking;
        private System.Windows.Forms.ImageList imageListCapcha;
    }
}

