namespace Tax_Calculator
{
    partial class Tax
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
            this.lblTax = new System.Windows.Forms.Label();
            this.txtBoxTax = new System.Windows.Forms.TextBox();
            this.bttnConfirmTax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(2, 9);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(35, 13);
            this.lblTax.TabIndex = 0;
            this.lblTax.Text = "label1";
            // 
            // txtBoxTax
            // 
            this.txtBoxTax.Location = new System.Drawing.Point(70, 31);
            this.txtBoxTax.Name = "txtBoxTax";
            this.txtBoxTax.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTax.TabIndex = 1;
            // 
            // bttnConfirmTax
            // 
            this.bttnConfirmTax.Location = new System.Drawing.Point(70, 57);
            this.bttnConfirmTax.Name = "bttnConfirmTax";
            this.bttnConfirmTax.Size = new System.Drawing.Size(100, 23);
            this.bttnConfirmTax.TabIndex = 2;
            this.bttnConfirmTax.Text = "Confirm";
            this.bttnConfirmTax.UseVisualStyleBackColor = true;
            this.bttnConfirmTax.Click += new System.EventHandler(this.bttnConfirmTax_Click);
            // 
            // Tax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 105);
            this.Controls.Add(this.bttnConfirmTax);
            this.Controls.Add(this.txtBoxTax);
            this.Controls.Add(this.lblTax);
            this.Name = "Tax";
            this.ShowIcon = false;
            this.Text = "Tax";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtBoxTax;
        private System.Windows.Forms.Button bttnConfirmTax;
    }
}