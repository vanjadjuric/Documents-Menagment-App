namespace DocumentsProject
{
    partial class IzmeniDocumentsForma
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
            this.PrihvatiBtn = new System.Windows.Forms.Button();
            this.UpdateImeTxt = new System.Windows.Forms.TextBox();
            this.UpdateFirmaTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TipCmb = new System.Windows.Forms.ComboBox();
            this.KorisnikLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrihvatiBtn
            // 
            this.PrihvatiBtn.Location = new System.Drawing.Point(123, 239);
            this.PrihvatiBtn.Name = "PrihvatiBtn";
            this.PrihvatiBtn.Size = new System.Drawing.Size(75, 36);
            this.PrihvatiBtn.TabIndex = 1;
            this.PrihvatiBtn.Text = "Prihvati izmene";
            this.PrihvatiBtn.UseVisualStyleBackColor = true;
            this.PrihvatiBtn.Click += new System.EventHandler(this.PrihvatiBtn_Click);
            // 
            // UpdateImeTxt
            // 
            this.UpdateImeTxt.Location = new System.Drawing.Point(164, 58);
            this.UpdateImeTxt.Name = "UpdateImeTxt";
            this.UpdateImeTxt.Size = new System.Drawing.Size(100, 20);
            this.UpdateImeTxt.TabIndex = 2;
            // 
            // UpdateFirmaTxt
            // 
            this.UpdateFirmaTxt.Location = new System.Drawing.Point(164, 97);
            this.UpdateFirmaTxt.Name = "UpdateFirmaTxt";
            this.UpdateFirmaTxt.Size = new System.Drawing.Size(100, 20);
            this.UpdateFirmaTxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ime dokumenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Firma dokumenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tip dokumenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Korisnik koji pravi izmene";
            // 
            // TipCmb
            // 
            this.TipCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipCmb.FormattingEnabled = true;
            this.TipCmb.Location = new System.Drawing.Point(164, 140);
            this.TipCmb.Name = "TipCmb";
            this.TipCmb.Size = new System.Drawing.Size(100, 21);
            this.TipCmb.TabIndex = 13;
            // 
            // KorisnikLb
            // 
            this.KorisnikLb.AutoSize = true;
            this.KorisnikLb.Location = new System.Drawing.Point(163, 181);
            this.KorisnikLb.Name = "KorisnikLb";
            this.KorisnikLb.Size = new System.Drawing.Size(35, 13);
            this.KorisnikLb.TabIndex = 14;
            this.KorisnikLb.Text = "label1";
            // 
            // IzmeniDocumentsForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 299);
            this.Controls.Add(this.KorisnikLb);
            this.Controls.Add(this.TipCmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdateFirmaTxt);
            this.Controls.Add(this.UpdateImeTxt);
            this.Controls.Add(this.PrihvatiBtn);
            this.Name = "IzmeniDocumentsForma";
            this.Text = "IzmeniDocumentsForma";
            this.Load += new System.EventHandler(this.IzmeniDocumentsForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PrihvatiBtn;
        private System.Windows.Forms.TextBox UpdateImeTxt;
        private System.Windows.Forms.TextBox UpdateFirmaTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TipCmb;
        private System.Windows.Forms.Label KorisnikLb;
    }
}