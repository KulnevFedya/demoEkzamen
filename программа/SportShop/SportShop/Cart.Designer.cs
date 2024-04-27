namespace SportShop
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.panelUp = new System.Windows.Forms.Panel();
            this.lblpointOfIssue = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.comboBoxPointOfIssues = new System.Windows.Forms.ComboBox();
            this.listBoxProductsinCart = new System.Windows.Forms.ListBox();
            this.btnDoOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panelUp.Controls.Add(this.lblpointOfIssue);
            this.panelUp.Controls.Add(this.lblCart);
            this.panelUp.Controls.Add(this.comboBoxPointOfIssues);
            this.panelUp.Controls.Add(this.listBoxProductsinCart);
            this.panelUp.Controls.Add(this.btnDoOrder);
            this.panelUp.Controls.Add(this.btnExit);
            this.panelUp.Controls.Add(this.pictureBoxLogo);
            this.panelUp.Controls.Add(this.lblname);
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(430, 451);
            this.panelUp.TabIndex = 4;
            // 
            // lblpointOfIssue
            // 
            this.lblpointOfIssue.AutoSize = true;
            this.lblpointOfIssue.Location = new System.Drawing.Point(12, 323);
            this.lblpointOfIssue.Name = "lblpointOfIssue";
            this.lblpointOfIssue.Size = new System.Drawing.Size(125, 13);
            this.lblpointOfIssue.TabIndex = 14;
            this.lblpointOfIssue.Text = "Выбрать пункт выдачи:";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(12, 107);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(53, 13);
            this.lblCart.TabIndex = 13;
            this.lblCart.Text = "Корзина:";
            // 
            // comboBoxPointOfIssues
            // 
            this.comboBoxPointOfIssues.FormattingEnabled = true;
            this.comboBoxPointOfIssues.Location = new System.Drawing.Point(12, 339);
            this.comboBoxPointOfIssues.Name = "comboBoxPointOfIssues";
            this.comboBoxPointOfIssues.Size = new System.Drawing.Size(387, 21);
            this.comboBoxPointOfIssues.TabIndex = 12;
            // 
            // listBoxProductsinCart
            // 
            this.listBoxProductsinCart.FormattingEnabled = true;
            this.listBoxProductsinCart.Location = new System.Drawing.Point(12, 131);
            this.listBoxProductsinCart.Name = "listBoxProductsinCart";
            this.listBoxProductsinCart.Size = new System.Drawing.Size(387, 173);
            this.listBoxProductsinCart.TabIndex = 11;
            // 
            // btnDoOrder
            // 
            this.btnDoOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnDoOrder.Location = new System.Drawing.Point(309, 391);
            this.btnDoOrder.Name = "btnDoOrder";
            this.btnDoOrder.Size = new System.Drawing.Size(90, 46);
            this.btnDoOrder.TabIndex = 10;
            this.btnDoOrder.Text = "Оформить заказ";
            this.btnDoOrder.UseVisualStyleBackColor = false;
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
            this.pictureBoxLogo.Location = new System.Drawing.Point(276, 12);
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
            this.lblname.Location = new System.Drawing.Point(12, 44);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(229, 18);
            this.lblname.TabIndex = 7;
            this.lblname.Text = "ООО \"Спортивный магазин\"";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 449);
            this.Controls.Add(this.panelUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корзина";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBoxPointOfIssues;
        private System.Windows.Forms.ListBox listBoxProductsinCart;
        private System.Windows.Forms.Button btnDoOrder;
        private System.Windows.Forms.Label lblpointOfIssue;
        private System.Windows.Forms.Label lblCart;
    }
}