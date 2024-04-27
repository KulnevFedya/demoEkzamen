namespace SportShop
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.panelUp = new System.Windows.Forms.Panel();
            this.groupBoxAddPhoto = new System.Windows.Forms.GroupBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.pictureBoxNewProduct = new System.Windows.Forms.PictureBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.lblphoto = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.panelUp.SuspendLayout();
            this.groupBoxAddPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panelUp.Controls.Add(this.groupBoxAddPhoto);
            this.panelUp.Controls.Add(this.btnExit);
            this.panelUp.Controls.Add(this.pictureBoxLogo);
            this.panelUp.Controls.Add(this.lblname);
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(644, 653);
            this.panelUp.TabIndex = 5;
            // 
            // groupBoxAddPhoto
            // 
            this.groupBoxAddPhoto.Controls.Add(this.btnfind);
            this.groupBoxAddPhoto.Controls.Add(this.btnadd);
            this.groupBoxAddPhoto.Controls.Add(this.pictureBoxNewProduct);
            this.groupBoxAddPhoto.Controls.Add(this.textBoxPath);
            this.groupBoxAddPhoto.Controls.Add(this.lblphoto);
            this.groupBoxAddPhoto.Location = new System.Drawing.Point(408, 160);
            this.groupBoxAddPhoto.Name = "groupBoxAddPhoto";
            this.groupBoxAddPhoto.Size = new System.Drawing.Size(221, 248);
            this.groupBoxAddPhoto.TabIndex = 15;
            this.groupBoxAddPhoto.TabStop = false;
            this.groupBoxAddPhoto.Text = "Добавление нового фото";
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(34, 202);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 39);
            this.btnfind.TabIndex = 13;
            this.btnfind.Text = "Выбрать фото";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(115, 203);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 38);
            this.btnadd.TabIndex = 14;
            this.btnadd.Text = "Сохранить";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // pictureBoxNewProduct
            // 
            this.pictureBoxNewProduct.Location = new System.Drawing.Point(34, 19);
            this.pictureBoxNewProduct.Name = "pictureBoxNewProduct";
            this.pictureBoxNewProduct.Size = new System.Drawing.Size(156, 121);
            this.pictureBoxNewProduct.TabIndex = 10;
            this.pictureBoxNewProduct.TabStop = false;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(34, 176);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(156, 20);
            this.textBoxPath.TabIndex = 11;
            // 
            // lblphoto
            // 
            this.lblphoto.AutoSize = true;
            this.lblphoto.Location = new System.Drawing.Point(31, 160);
            this.lblphoto.Name = "lblphoto";
            this.lblphoto.Size = new System.Drawing.Size(103, 13);
            this.lblphoto.TabIndex = 12;
            this.lblphoto.Text = "Введите название:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 29);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Вернуться";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(506, 12);
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
            this.lblname.Location = new System.Drawing.Point(271, 16);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(229, 18);
            this.lblname.TabIndex = 7;
            this.lblname.Text = "ООО \"Спортивный магазин\"";
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 652);
            this.Controls.Add(this.panelUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно для Админов";
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.groupBoxAddPhoto.ResumeLayout(false);
            this.groupBoxAddPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox groupBoxAddPhoto;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.PictureBox pictureBoxNewProduct;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label lblphoto;
    }
}