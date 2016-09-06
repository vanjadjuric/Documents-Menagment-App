namespace DocumentsProject
{
    partial class IzmeniProizvodForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NazivProizvodaTxt = new System.Windows.Forms.TextBox();
            this.RokTrajanjaTxt = new System.Windows.Forms.TextBox();
            this.SerijskiBrojTxt = new System.Windows.Forms.TextBox();
            this.InsertProductBtn = new System.Windows.Forms.Button();
            this.UpdateProductBtn = new System.Windows.Forms.Button();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TipCmb = new System.Windows.Forms.ComboBox();
            this.PrihvatiBtn = new System.Windows.Forms.Button();
            this.OdustaniBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(447, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // NazivProizvodaTxt
            // 
            this.NazivProizvodaTxt.Location = new System.Drawing.Point(531, 45);
            this.NazivProizvodaTxt.Name = "NazivProizvodaTxt";
            this.NazivProizvodaTxt.Size = new System.Drawing.Size(100, 20);
            this.NazivProizvodaTxt.TabIndex = 1;
            // 
            // RokTrajanjaTxt
            // 
            this.RokTrajanjaTxt.Location = new System.Drawing.Point(710, 45);
            this.RokTrajanjaTxt.Name = "RokTrajanjaTxt";
            this.RokTrajanjaTxt.Size = new System.Drawing.Size(100, 20);
            this.RokTrajanjaTxt.TabIndex = 3;
            // 
            // SerijskiBrojTxt
            // 
            this.SerijskiBrojTxt.Location = new System.Drawing.Point(710, 97);
            this.SerijskiBrojTxt.Name = "SerijskiBrojTxt";
            this.SerijskiBrojTxt.Size = new System.Drawing.Size(100, 20);
            this.SerijskiBrojTxt.TabIndex = 4;
            // 
            // InsertProductBtn
            // 
            this.InsertProductBtn.Location = new System.Drawing.Point(542, 158);
            this.InsertProductBtn.Name = "InsertProductBtn";
            this.InsertProductBtn.Size = new System.Drawing.Size(75, 35);
            this.InsertProductBtn.TabIndex = 5;
            this.InsertProductBtn.Text = "Unesi novi proizvod";
            this.InsertProductBtn.UseVisualStyleBackColor = true;
            this.InsertProductBtn.Click += new System.EventHandler(this.InsertProductBtn_Click);
            // 
            // UpdateProductBtn
            // 
            this.UpdateProductBtn.Location = new System.Drawing.Point(623, 158);
            this.UpdateProductBtn.Name = "UpdateProductBtn";
            this.UpdateProductBtn.Size = new System.Drawing.Size(75, 35);
            this.UpdateProductBtn.TabIndex = 6;
            this.UpdateProductBtn.Text = "Izmeni proizvod";
            this.UpdateProductBtn.UseVisualStyleBackColor = true;
            this.UpdateProductBtn.Click += new System.EventHandler(this.UpdateProductBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.Location = new System.Drawing.Point(709, 158);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(75, 35);
            this.DeleteProductBtn.TabIndex = 6;
            this.DeleteProductBtn.Text = "Obrisi proizvod";
            this.DeleteProductBtn.UseVisualStyleBackColor = true;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rok trajanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tip ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Serijski broj";
            // 
            // TipCmb
            // 
            this.TipCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipCmb.FormattingEnabled = true;
            this.TipCmb.Location = new System.Drawing.Point(530, 97);
            this.TipCmb.Name = "TipCmb";
            this.TipCmb.Size = new System.Drawing.Size(101, 21);
            this.TipCmb.TabIndex = 11;
            // 
            // PrihvatiBtn
            // 
            this.PrihvatiBtn.Location = new System.Drawing.Point(577, 158);
            this.PrihvatiBtn.Name = "PrihvatiBtn";
            this.PrihvatiBtn.Size = new System.Drawing.Size(75, 35);
            this.PrihvatiBtn.TabIndex = 12;
            this.PrihvatiBtn.Text = "Prihvati";
            this.PrihvatiBtn.UseVisualStyleBackColor = true;
            this.PrihvatiBtn.Click += new System.EventHandler(this.PrihvatiBtn_Click);
            // 
            // OdustaniBtn
            // 
            this.OdustaniBtn.Location = new System.Drawing.Point(671, 158);
            this.OdustaniBtn.Name = "OdustaniBtn";
            this.OdustaniBtn.Size = new System.Drawing.Size(75, 35);
            this.OdustaniBtn.TabIndex = 13;
            this.OdustaniBtn.Text = "Odustani";
            this.OdustaniBtn.UseVisualStyleBackColor = true;
            this.OdustaniBtn.Click += new System.EventHandler(this.OdustaniBtn_Click);
            // 
            // IzmeniProizvodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 308);
            this.Controls.Add(this.OdustaniBtn);
            this.Controls.Add(this.PrihvatiBtn);
            this.Controls.Add(this.TipCmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.UpdateProductBtn);
            this.Controls.Add(this.InsertProductBtn);
            this.Controls.Add(this.SerijskiBrojTxt);
            this.Controls.Add(this.RokTrajanjaTxt);
            this.Controls.Add(this.NazivProizvodaTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IzmeniProizvodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmena proizvoda";
            this.Load += new System.EventHandler(this.IzmeniProizvodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NazivProizvodaTxt;
        private System.Windows.Forms.TextBox RokTrajanjaTxt;
        private System.Windows.Forms.TextBox SerijskiBrojTxt;
        private System.Windows.Forms.Button InsertProductBtn;
        private System.Windows.Forms.Button UpdateProductBtn;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TipCmb;
        private System.Windows.Forms.Button PrihvatiBtn;
        private System.Windows.Forms.Button OdustaniBtn;
    }
}