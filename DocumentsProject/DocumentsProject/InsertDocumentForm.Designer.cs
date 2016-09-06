namespace DocumentsProject
{
    partial class InsertDocumentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DocumentNameTxt = new System.Windows.Forms.TextBox();
            this.DocumentFirmTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ZavrsiBtn = new System.Windows.Forms.Button();
            this.TipDocCmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime dokumenta";
            // 
            // DocumentNameTxt
            // 
            this.DocumentNameTxt.Location = new System.Drawing.Point(160, 65);
            this.DocumentNameTxt.Name = "DocumentNameTxt";
            this.DocumentNameTxt.Size = new System.Drawing.Size(100, 20);
            this.DocumentNameTxt.TabIndex = 1;
            // 
            // DocumentFirmTxt
            // 
            this.DocumentFirmTxt.Location = new System.Drawing.Point(160, 101);
            this.DocumentFirmTxt.Name = "DocumentFirmTxt";
            this.DocumentFirmTxt.Size = new System.Drawing.Size(100, 20);
            this.DocumentFirmTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Firma dokumenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tip dokumenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Korisnik koji kreira dokument";
            // 
            // ZavrsiBtn
            // 
            this.ZavrsiBtn.Location = new System.Drawing.Point(135, 226);
            this.ZavrsiBtn.Name = "ZavrsiBtn";
            this.ZavrsiBtn.Size = new System.Drawing.Size(75, 23);
            this.ZavrsiBtn.TabIndex = 8;
            this.ZavrsiBtn.Text = "Zavrsi";
            this.ZavrsiBtn.UseVisualStyleBackColor = true;
            this.ZavrsiBtn.Click += new System.EventHandler(this.ZavrsiBtn_Click);
            // 
            // TipDocCmb
            // 
            this.TipDocCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipDocCmb.FormattingEnabled = true;
            this.TipDocCmb.Location = new System.Drawing.Point(160, 138);
            this.TipDocCmb.Name = "TipDocCmb";
            this.TipDocCmb.Size = new System.Drawing.Size(99, 21);
            this.TipDocCmb.TabIndex = 10;
            this.TipDocCmb.SelectionChangeCommitted += new System.EventHandler(this.TipDocCmb_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // InsertDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 288);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TipDocCmb);
            this.Controls.Add(this.ZavrsiBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DocumentFirmTxt);
            this.Controls.Add(this.DocumentNameTxt);
            this.Controls.Add(this.label1);
            this.Name = "InsertDocumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje novog dokumenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DocumentNameTxt;
        private System.Windows.Forms.TextBox DocumentFirmTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ZavrsiBtn;
        private System.Windows.Forms.ComboBox TipDocCmb;
        private System.Windows.Forms.Label label5;
    }
}