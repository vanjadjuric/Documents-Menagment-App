namespace DocumentsProject
{
    partial class Form1
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.InserDocumentBtn = new System.Windows.Forms.Button();
            this.IzmeniDocumentsBtn = new System.Windows.Forms.Button();
            this.DeleteDocumentBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OdustaniBtn = new System.Windows.Forms.Button();
            this.PrihvatiBtn = new System.Windows.Forms.Button();
            this.datumLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cenaLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProizvodCmb = new System.Windows.Forms.ComboBox();
            this.KolicinaTxt = new System.Windows.Forms.TextBox();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.DatumUnosaTxt = new System.Windows.Forms.TextBox();
            this.CenaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DetailsDeleteBtn = new System.Windows.Forms.Button();
            this.DetailsUpdateBtb = new System.Windows.Forms.Button();
            this.DocDetailsInsertBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EvidencijaBtn = new System.Windows.Forms.Button();
            this.ProizvodiListbx = new System.Windows.Forms.ListBox();
            this.ZatvoriLbBtn = new System.Windows.Forms.Button();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.IzmenaProizvodaBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FilterCmb = new System.Windows.Forms.ComboBox();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.ShowAllBtnn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(310, 581);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // InserDocumentBtn
            // 
            this.InserDocumentBtn.Location = new System.Drawing.Point(92, 630);
            this.InserDocumentBtn.Name = "InserDocumentBtn";
            this.InserDocumentBtn.Size = new System.Drawing.Size(122, 23);
            this.InserDocumentBtn.TabIndex = 6;
            this.InserDocumentBtn.Text = "Unesi dokument";
            this.InserDocumentBtn.UseVisualStyleBackColor = true;
            this.InserDocumentBtn.Click += new System.EventHandler(this.InsertDocumentBtn);
            // 
            // IzmeniDocumentsBtn
            // 
            this.IzmeniDocumentsBtn.Location = new System.Drawing.Point(92, 659);
            this.IzmeniDocumentsBtn.Name = "IzmeniDocumentsBtn";
            this.IzmeniDocumentsBtn.Size = new System.Drawing.Size(122, 23);
            this.IzmeniDocumentsBtn.TabIndex = 7;
            this.IzmeniDocumentsBtn.Text = "Izmeni dokument";
            this.IzmeniDocumentsBtn.UseVisualStyleBackColor = true;
            this.IzmeniDocumentsBtn.Click += new System.EventHandler(this.IzmeniDocumentsBtn_Click);
            // 
            // DeleteDocumentBtn
            // 
            this.DeleteDocumentBtn.Location = new System.Drawing.Point(92, 688);
            this.DeleteDocumentBtn.Name = "DeleteDocumentBtn";
            this.DeleteDocumentBtn.Size = new System.Drawing.Size(122, 23);
            this.DeleteDocumentBtn.TabIndex = 8;
            this.DeleteDocumentBtn.Text = "Obrisi dokument";
            this.DeleteDocumentBtn.UseVisualStyleBackColor = true;
            this.DeleteDocumentBtn.Click += new System.EventHandler(this.DeleteDocumentBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowAllBtnn);
            this.groupBox1.Controls.Add(this.FilterBtn);
            this.groupBox1.Controls.Add(this.FilterCmb);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.DeleteDocumentBtn);
            this.groupBox1.Controls.Add(this.IzmeniDocumentsBtn);
            this.groupBox1.Controls.Add(this.InserDocumentBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 717);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dokumenti";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.OdustaniBtn);
            this.groupBox2.Controls.Add(this.PrihvatiBtn);
            this.groupBox2.Controls.Add(this.datumLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cenaLabel);
            this.groupBox2.Controls.Add(this.IdLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ProizvodCmb);
            this.groupBox2.Controls.Add(this.KolicinaTxt);
            this.groupBox2.Controls.Add(this.IDtxt);
            this.groupBox2.Controls.Add(this.DatumUnosaTxt);
            this.groupBox2.Controls.Add(this.CenaTxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DetailsDeleteBtn);
            this.groupBox2.Controls.Add(this.DetailsUpdateBtb);
            this.groupBox2.Controls.Add(this.DocDetailsInsertBtn);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(342, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 589);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stavke dokumenta";
            // 
            // OdustaniBtn
            // 
            this.OdustaniBtn.Location = new System.Drawing.Point(371, 520);
            this.OdustaniBtn.Name = "OdustaniBtn";
            this.OdustaniBtn.Size = new System.Drawing.Size(93, 34);
            this.OdustaniBtn.TabIndex = 24;
            this.OdustaniBtn.Text = "Odustani";
            this.OdustaniBtn.UseVisualStyleBackColor = true;
            this.OdustaniBtn.Click += new System.EventHandler(this.OdustaniBtn_Click);
            // 
            // PrihvatiBtn
            // 
            this.PrihvatiBtn.Location = new System.Drawing.Point(246, 521);
            this.PrihvatiBtn.Name = "PrihvatiBtn";
            this.PrihvatiBtn.Size = new System.Drawing.Size(102, 34);
            this.PrihvatiBtn.TabIndex = 23;
            this.PrihvatiBtn.Text = "Prihvati izmene";
            this.PrihvatiBtn.UseVisualStyleBackColor = true;
            this.PrihvatiBtn.Click += new System.EventHandler(this.PrihvatiBtn_Click);
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(492, 405);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(70, 13);
            this.datumLabel.TabIndex = 22;
            this.datumLabel.Text = "Datum unosa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Kolicina";
            // 
            // cenaLabel
            // 
            this.cenaLabel.AutoSize = true;
            this.cenaLabel.Location = new System.Drawing.Point(89, 445);
            this.cenaLabel.Name = "cenaLabel";
            this.cenaLabel.Size = new System.Drawing.Size(32, 13);
            this.cenaLabel.TabIndex = 20;
            this.cenaLabel.Text = "Cena";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(330, 445);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(18, 13);
            this.IdLabel.TabIndex = 19;
            this.IdLabel.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Proizvod";
            // 
            // ProizvodCmb
            // 
            this.ProizvodCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProizvodCmb.FormattingEnabled = true;
            this.ProizvodCmb.Location = new System.Drawing.Point(127, 402);
            this.ProizvodCmb.Name = "ProizvodCmb";
            this.ProizvodCmb.Size = new System.Drawing.Size(136, 21);
            this.ProizvodCmb.TabIndex = 17;
            this.ProizvodCmb.SelectionChangeCommitted += new System.EventHandler(this.ProizvodCmb_SelectionChangeCommitted);
            // 
            // KolicinaTxt
            // 
            this.KolicinaTxt.Location = new System.Drawing.Point(354, 403);
            this.KolicinaTxt.Name = "KolicinaTxt";
            this.KolicinaTxt.Size = new System.Drawing.Size(121, 20);
            this.KolicinaTxt.TabIndex = 16;
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(354, 442);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(121, 20);
            this.IDtxt.TabIndex = 15;
            // 
            // DatumUnosaTxt
            // 
            this.DatumUnosaTxt.Location = new System.Drawing.Point(568, 402);
            this.DatumUnosaTxt.Name = "DatumUnosaTxt";
            this.DatumUnosaTxt.Size = new System.Drawing.Size(121, 20);
            this.DatumUnosaTxt.TabIndex = 13;
            // 
            // CenaTxt
            // 
            this.CenaTxt.Location = new System.Drawing.Point(127, 442);
            this.CenaTxt.Name = "CenaTxt";
            this.CenaTxt.Size = new System.Drawing.Size(136, 20);
            this.CenaTxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // DetailsDeleteBtn
            // 
            this.DetailsDeleteBtn.Location = new System.Drawing.Point(418, 520);
            this.DetailsDeleteBtn.Name = "DetailsDeleteBtn";
            this.DetailsDeleteBtn.Size = new System.Drawing.Size(122, 35);
            this.DetailsDeleteBtn.TabIndex = 9;
            this.DetailsDeleteBtn.Text = "Obrisi stavku dokumenta";
            this.DetailsDeleteBtn.UseVisualStyleBackColor = true;
            this.DetailsDeleteBtn.Click += new System.EventHandler(this.DetailsDeleteBtn_Click);
            // 
            // DetailsUpdateBtb
            // 
            this.DetailsUpdateBtb.Location = new System.Drawing.Point(279, 520);
            this.DetailsUpdateBtb.Name = "DetailsUpdateBtb";
            this.DetailsUpdateBtb.Size = new System.Drawing.Size(122, 35);
            this.DetailsUpdateBtb.TabIndex = 8;
            this.DetailsUpdateBtb.Text = "Izmeni stavku dokumenta";
            this.DetailsUpdateBtb.UseVisualStyleBackColor = true;
            this.DetailsUpdateBtb.Click += new System.EventHandler(this.DetailsUpdateBtb_Click);
            // 
            // DocDetailsInsertBtn
            // 
            this.DocDetailsInsertBtn.Location = new System.Drawing.Point(141, 520);
            this.DocDetailsInsertBtn.Name = "DocDetailsInsertBtn";
            this.DocDetailsInsertBtn.Size = new System.Drawing.Size(122, 35);
            this.DocDetailsInsertBtn.TabIndex = 7;
            this.DocDetailsInsertBtn.Text = "Unesi novu stavku dokumenta";
            this.DocDetailsInsertBtn.UseVisualStyleBackColor = true;
            this.DocDetailsInsertBtn.Click += new System.EventHandler(this.DocDetailsInsertBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(702, 319);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1315, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1263, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 22);
            this.button2.TabIndex = 12;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EvidencijaBtn
            // 
            this.EvidencijaBtn.Location = new System.Drawing.Point(1118, 204);
            this.EvidencijaBtn.Name = "EvidencijaBtn";
            this.EvidencijaBtn.Size = new System.Drawing.Size(75, 34);
            this.EvidencijaBtn.TabIndex = 13;
            this.EvidencijaBtn.Text = "Evidencija proizvoda";
            this.EvidencijaBtn.UseVisualStyleBackColor = true;
            this.EvidencijaBtn.Click += new System.EventHandler(this.EvidencijaBtn_Click);
            // 
            // ProizvodiListbx
            // 
            this.ProizvodiListbx.FormattingEnabled = true;
            this.ProizvodiListbx.Location = new System.Drawing.Point(1142, 287);
            this.ProizvodiListbx.Name = "ProizvodiListbx";
            this.ProizvodiListbx.Size = new System.Drawing.Size(177, 407);
            this.ProizvodiListbx.TabIndex = 15;
            // 
            // ZatvoriLbBtn
            // 
            this.ZatvoriLbBtn.Location = new System.Drawing.Point(1187, 244);
            this.ZatvoriLbBtn.Name = "ZatvoriLbBtn";
            this.ZatvoriLbBtn.Size = new System.Drawing.Size(75, 23);
            this.ZatvoriLbBtn.TabIndex = 16;
            this.ZatvoriLbBtn.Text = "Zavrsi";
            this.ZatvoriLbBtn.UseVisualStyleBackColor = true;
            this.ZatvoriLbBtn.Click += new System.EventHandler(this.ZatvoriLbBtn_Click);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(139, 37);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(110, 20);
            this.UsernameTxt.TabIndex = 17;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(139, 63);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(110, 20);
            this.PasswordTxt.TabIndex = 18;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(109, 106);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 35);
            this.LoginBtn.TabIndex = 19;
            this.LoginBtn.Text = "Log in";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(27, 68);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(53, 13);
            this.PasswordLbl.TabIndex = 20;
            this.PasswordLbl.Text = "Password";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(27, 40);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(55, 13);
            this.UsernameLbl.TabIndex = 21;
            this.UsernameLbl.Text = "Username";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(1187, 157);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(75, 21);
            this.LogOutBtn.TabIndex = 22;
            this.LogOutBtn.Text = "Log out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Location = new System.Drawing.Point(1115, 91);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(35, 13);
            this.WelcomeLbl.TabIndex = 23;
            this.WelcomeLbl.Text = "label3";
            // 
            // IzmenaProizvodaBtn
            // 
            this.IzmenaProizvodaBtn.Location = new System.Drawing.Point(1254, 204);
            this.IzmenaProizvodaBtn.Name = "IzmenaProizvodaBtn";
            this.IzmenaProizvodaBtn.Size = new System.Drawing.Size(75, 34);
            this.IzmenaProizvodaBtn.TabIndex = 24;
            this.IzmenaProizvodaBtn.Text = "Izmena proizvoda";
            this.IzmenaProizvodaBtn.UseVisualStyleBackColor = true;
            this.IzmenaProizvodaBtn.Click += new System.EventHandler(this.IzmenaProizvodaBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UsernameTxt);
            this.groupBox3.Controls.Add(this.PasswordTxt);
            this.groupBox3.Controls.Add(this.UsernameLbl);
            this.groupBox3.Controls.Add(this.LoginBtn);
            this.groupBox3.Controls.Add(this.PasswordLbl);
            this.groupBox3.Location = new System.Drawing.Point(481, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 159);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login information";
            // 
            // FilterCmb
            // 
            this.FilterCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterCmb.FormattingEnabled = true;
            this.FilterCmb.Location = new System.Drawing.Point(6, 16);
            this.FilterCmb.Name = "FilterCmb";
            this.FilterCmb.Size = new System.Drawing.Size(112, 21);
            this.FilterCmb.TabIndex = 9;
            this.FilterCmb.SelectionChangeCommitted += new System.EventHandler(this.FilterCmb_SelectionChangeCommitted);
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(6, 16);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(112, 23);
            this.FilterBtn.TabIndex = 10;
            this.FilterBtn.Text = "Filtriraj";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // ShowAllBtnn
            // 
            this.ShowAllBtnn.Location = new System.Drawing.Point(124, 16);
            this.ShowAllBtnn.Name = "ShowAllBtnn";
            this.ShowAllBtnn.Size = new System.Drawing.Size(112, 23);
            this.ShowAllBtnn.TabIndex = 11;
            this.ShowAllBtnn.Text = "Prikazi sve";
            this.ShowAllBtnn.UseVisualStyleBackColor = true;
            this.ShowAllBtnn.Click += new System.EventHandler(this.ShowAllBtnn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.IzmenaProizvodaBtn);
            this.Controls.Add(this.WelcomeLbl);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.ZatvoriLbBtn);
            this.Controls.Add(this.ProizvodiListbx);
            this.Controls.Add(this.EvidencijaBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija dokumenata";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button InserDocumentBtn;
        private System.Windows.Forms.Button IzmeniDocumentsBtn;
        private System.Windows.Forms.Button DeleteDocumentBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DetailsDeleteBtn;
        private System.Windows.Forms.Button DetailsUpdateBtb;
        private System.Windows.Forms.Button DocDetailsInsertBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CenaTxt;
        private System.Windows.Forms.TextBox KolicinaTxt;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox DatumUnosaTxt;
        private System.Windows.Forms.ComboBox ProizvodCmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label cenaLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Button PrihvatiBtn;
        private System.Windows.Forms.Button OdustaniBtn;
        private System.Windows.Forms.Button EvidencijaBtn;
        private System.Windows.Forms.ListBox ProizvodiListbx;
        private System.Windows.Forms.Button ZatvoriLbBtn;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.Button IzmenaProizvodaBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.ComboBox FilterCmb;
        private System.Windows.Forms.Button ShowAllBtnn;
    }
}

