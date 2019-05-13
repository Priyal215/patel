using System.Windows.Forms;

namespace ClothesShop {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.detailsBox = new System.Windows.Forms.RichTextBox();
            this.pictureBoxLsShirt = new System.Windows.Forms.PictureBox();
            this.pictureBoxSSShirt = new System.Windows.Forms.PictureBox();
            this.pictureBoxTeeShirt = new System.Windows.Forms.PictureBox();
            this.pictureBoxPants = new System.Windows.Forms.PictureBox();
            this.pictureBoxShorts = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLsShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSSShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeeShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShorts)).BeginInit();
            this.SuspendLayout();
            // 
            // detailsBox
            // 
            this.detailsBox.Enabled = false;
            this.detailsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.detailsBox.Location = new System.Drawing.Point(844, 36);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(500, 700);
            this.detailsBox.TabIndex = 0;
            this.detailsBox.Text = "Please add products to your invoice.";
            this.detailsBox.TextChanged += new System.EventHandler(this.detailsBox_TextChanged);
            // 
            // pictureBoxLsShirt
            // 
            this.pictureBoxLsShirt.Image = global::ClothesShop.Properties.Resources.DockLSSBlWh;
            this.pictureBoxLsShirt.Location = new System.Drawing.Point(134, 182);
            this.pictureBoxLsShirt.Name = "pictureBoxLsShirt";
            this.pictureBoxLsShirt.Size = new System.Drawing.Size(192, 195);
            this.pictureBoxLsShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLsShirt.TabIndex = 2;
            this.pictureBoxLsShirt.TabStop = false;
            this.pictureBoxLsShirt.Click += new System.EventHandler(this.pictureBoxLsShirt_Click);
            this.pictureBoxLsShirt.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxLsShirt_Paint);
            // 
            // pictureBoxSSShirt
            // 
            this.pictureBoxSSShirt.Image = global::ClothesShop.Properties.Resources.ChapSSSBl;
            this.pictureBoxSSShirt.Location = new System.Drawing.Point(362, 182);
            this.pictureBoxSSShirt.Name = "pictureBoxSSShirt";
            this.pictureBoxSSShirt.Size = new System.Drawing.Size(201, 195);
            this.pictureBoxSSShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSSShirt.TabIndex = 3;
            this.pictureBoxSSShirt.TabStop = false;
            this.pictureBoxSSShirt.Click += new System.EventHandler(this.pictureBoxSSShirt_Click);
            this.pictureBoxSSShirt.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSSShirt_Paint);
            // 
            // pictureBoxTeeShirt
            // 
            this.pictureBoxTeeShirt.Image = global::ClothesShop.Properties.Resources.SupermanTee;
            this.pictureBoxTeeShirt.Location = new System.Drawing.Point(584, 182);
            this.pictureBoxTeeShirt.Name = "pictureBoxTeeShirt";
            this.pictureBoxTeeShirt.Size = new System.Drawing.Size(201, 195);
            this.pictureBoxTeeShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTeeShirt.TabIndex = 4;
            this.pictureBoxTeeShirt.TabStop = false;
            this.pictureBoxTeeShirt.Click += new System.EventHandler(this.pictureBoxTeeShirt_Click);
            this.pictureBoxTeeShirt.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxTeeShirt_Paint);
            // 
            // pictureBoxPants
            // 
            this.pictureBoxPants.Image = global::ClothesShop.Properties.Resources.LeviPntBjean;
            this.pictureBoxPants.Location = new System.Drawing.Point(134, 440);
            this.pictureBoxPants.Name = "pictureBoxPants";
            this.pictureBoxPants.Size = new System.Drawing.Size(201, 195);
            this.pictureBoxPants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPants.TabIndex = 5;
            this.pictureBoxPants.TabStop = false;
            this.pictureBoxPants.Click += new System.EventHandler(this.pictureBoxPants_Click);
            this.pictureBoxPants.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPants_Paint);
            // 
            // pictureBoxShorts
            // 
            this.pictureBoxShorts.Image = global::ClothesShop.Properties.Resources.WranShtBjean;
            this.pictureBoxShorts.Location = new System.Drawing.Point(371, 440);
            this.pictureBoxShorts.Name = "pictureBoxShorts";
            this.pictureBoxShorts.Size = new System.Drawing.Size(201, 195);
            this.pictureBoxShorts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShorts.TabIndex = 6;
            this.pictureBoxShorts.TabStop = false;
            this.pictureBoxShorts.Click += new System.EventHandler(this.pictureBoxShorts_Click);
            this.pictureBoxShorts.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxShorts_Paint);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(134, 713);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(201, 73);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(380, 713);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(201, 73);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Location = new System.Drawing.Point(609, 713);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(201, 73);
            this.buttonOrder.TabIndex = 11;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClothesShop.Properties.Resources.ClothesShop;
            this.ClientSize = new System.Drawing.Size(1384, 822);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBoxShorts);
            this.Controls.Add(this.pictureBoxPants);
            this.Controls.Add(this.pictureBoxTeeShirt);
            this.Controls.Add(this.pictureBoxSSShirt);
            this.Controls.Add(this.pictureBoxLsShirt);
            this.Controls.Add(this.detailsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "The Clothes Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.titleShop_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLsShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSSShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeeShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShorts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox detailsBox;
        private System.Windows.Forms.PictureBox pictureBoxLsShirt;
        private System.Windows.Forms.PictureBox pictureBoxSSShirt;
        private System.Windows.Forms.PictureBox pictureBoxTeeShirt;
        private System.Windows.Forms.PictureBox pictureBoxPants;
        private System.Windows.Forms.PictureBox pictureBoxShorts;
        private Button buttonExit;
        private Button buttonCancel;
        private Button buttonOrder;
    }
}