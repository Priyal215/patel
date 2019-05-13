namespace ClothesShop
{
    partial class frmProductPlace
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
            this.combBoxProducts = new System.Windows.Forms.ComboBox();
            this.comboBoxQuantity = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combBoxProducts
            // 
            this.combBoxProducts.FormattingEnabled = true;
            this.combBoxProducts.Location = new System.Drawing.Point(50, 35);
            this.combBoxProducts.Name = "combBoxProducts";
            this.combBoxProducts.Size = new System.Drawing.Size(556, 24);
            this.combBoxProducts.TabIndex = 0;
            this.combBoxProducts.SelectedIndexChanged += new System.EventHandler(this.combBoxProducts_SelectedIndexChanged);
            // 
            // comboBoxQuantity
            // 
            this.comboBoxQuantity.FormattingEnabled = true;
            this.comboBoxQuantity.Location = new System.Drawing.Point(50, 81);
            this.comboBoxQuantity.Name = "comboBoxQuantity";
            this.comboBoxQuantity.Size = new System.Drawing.Size(155, 24);
            this.comboBoxQuantity.TabIndex = 1;
            this.comboBoxQuantity.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuantity_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmProductPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 184);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxQuantity);
            this.Controls.Add(this.combBoxProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductPlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductPlace";
            this.Load += new System.EventHandler(this.frmProductPlace_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.border_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combBoxProducts;
        private System.Windows.Forms.ComboBox comboBoxQuantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}