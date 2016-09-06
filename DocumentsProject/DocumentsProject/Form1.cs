using DocumentsProject.Business.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentsProject.Entity.Classes;

namespace DocumentsProject
{
    public partial class Form1 : Form
    {
        #region Objekti klasa
        public DocumentsBL _DocumentBL;

        public DocDetailsBL _DocDetailsBL;

        public int DocumentsID, DocUserID, ProductID, DocDetailsID, DocTypeID,FilterDocType;

        public string DocumentName, DocumentFirm, DocTypeValue, CRUD, DocType;

        public static string LoginUser;
        #endregion
        public Form1()
        {
            InitializeComponent();
            _DocumentBL = new DocumentsBL();
            _DocDetailsBL = new DocDetailsBL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // LoadData();         
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            clearTxt();
            ProizvodiListbx.Visible = false;
            ZatvoriLbBtn.Visible = false;
            PrihvatiBtn.Visible = false;
            OdustaniBtn.Visible = false;
            LogOutBtn.Visible = false;
            WelcomeLbl.Visible = false;
            IzmenaProizvodaBtn.Enabled = false;
            EvidencijaBtn.Enabled = false;
            PasswordTxt.PasswordChar = '*';
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            FilterCmb.Visible = false;
            ShowAllBtnn.Visible = false;
            IzmenaProizvodaBtn.Visible = false;
            EvidencijaBtn.Visible = false;
            groupBox3.Left = (this.ClientSize.Width - groupBox3.Width) / 2;
            groupBox3.Top = (this.ClientSize.Height - groupBox3.Height) / 2;
            UsernameTxt.Focus();
           
        }
        
        public void LoadData()
        {
            dataGridView2.DataSource = _DocumentBL.SelectAll();
            dataGridView2.Columns["DocumentsID"].Visible = false;
            dataGridView2.Columns["DocTypeID"].Visible = false;
            dataGridView2.Columns["DocUserID"].Visible = false;
            dataGridView2.Columns["Name"].Visible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Columns[3].HeaderText = "Ime dokumenta";
            dataGridView2.Columns[4].HeaderText = "Firma";
            dataGridView2.Columns[5].HeaderText = "Tip dokumenta";
            dataGridView2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            ProizvodCmb.DataSource = _DocumentBL.ProductCombo();
            ProizvodCmb.DisplayMember = "ProductName";
            ProizvodCmb.ValueMember = "ProductID";
            ProizvodCmb.SelectedIndex = -1;

            FilterCmb.DataSource = _DocumentBL.DocTypeCombo();
            FilterCmb.DisplayMember = "DocName";
            FilterCmb.ValueMember = "DocTypeID";
            FilterCmb.SelectedIndex = -1;
            if(dataGridView1.RowCount > 1)
            {
                dataGridView2.Rows[0].Selected = false;
            }
           
            dataGridView1.DataSource = null;

        }

        public void clearTxt()
        {
            CenaTxt.Clear();
            IDtxt.Clear();
            KolicinaTxt.Clear();
            DatumUnosaTxt.Clear();
            ProizvodCmb.SelectedIndex= -1;
            CenaTxt.Enabled = false;
            KolicinaTxt.Enabled = false;
            ProizvodCmb.Enabled = false;
            DatumUnosaTxt.Enabled = false;
            IDtxt.Enabled = false;
        }
        private void InsertDocumentBtn(object sender, EventArgs e)
        {
            InsertDocumentForm form = new InsertDocumentForm();
            form.FormClosing += new FormClosingEventHandler(this.InsertDocumentForm_Closing);
            form.Show();
        }

        private void InsertDocumentForm_Closing(object sender, FormClosingEventArgs e)
        {
            LoadData();
        }
     
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                    DocumentsID = int.Parse(row.Cells["DocumentsID"].Value.ToString());
                    DocumentName = row.Cells["DocumentName"].Value.ToString();
                    DocumentFirm = row.Cells["DocumentFirm"].Value.ToString();
                    DocType = row.Cells["DocName"].Value.ToString();
                    DocTypeID = int.Parse(row.Cells["DocTypeID"].Value.ToString());
                    DocUserID = int.Parse(row.Cells[2].Value.ToString());
            }

           

            if(DocTypeID == 1)
            {
                CenaTxt.Visible = false;              
                IDtxt.Visible = false;
                IdLabel.Visible = false;
                cenaLabel.Visible = false;
                DatumUnosaTxt.Visible = true;
                datumLabel.Visible = true;
                DocTypeValue = "Narudzbenica";
            }
            if (DocTypeID == 3)
            {
                CenaTxt.Visible = true;
                IDtxt.Visible = true;
                IdLabel.Visible = true;
                cenaLabel.Visible = true;
                DatumUnosaTxt.Visible = false;
                datumLabel.Visible = false;
                DocTypeValue = "Racun";
            }
            if( DocTypeID == 2)
            {
                CenaTxt.Visible = true;
                IDtxt.Visible = true;
                IdLabel.Visible = true;
                cenaLabel.Visible = true;
                DatumUnosaTxt.Visible = true;
                datumLabel.Visible = true;
                DocTypeValue = "Otpremnica";
            }
            DocDetailsInsertBtn.Visible = true;
            DetailsUpdateBtb.Visible = true;
            DetailsDeleteBtn.Visible = true;
            PrihvatiBtn.Visible = false;
            OdustaniBtn.Visible = false;
           
            clearTxt();
            LoadDocDetailsData();
        }

        private void DeleteDocumentBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite da obrisete ovaj dokument?", "Brisanje", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _DocumentBL.Delete(DocumentsID);
            }

           
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite da izadjete?", "Izlaz", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DocDetailsInsertBtn_Click(object sender, EventArgs e)
        {
            clearTxt();
            CenaTxt.Enabled = true;
            KolicinaTxt.Enabled = true;
            ProizvodCmb.Enabled = true;
            DatumUnosaTxt.Enabled = true;
            IDtxt.Enabled = true;
            DocDetailsInsertBtn.Visible = false;
            DetailsUpdateBtb.Visible = false;
            DetailsDeleteBtn.Visible = false;
            PrihvatiBtn.Visible = true;
            OdustaniBtn.Visible = true;

            CRUD = "INSERT";
          
        }

        private void PrihvatiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DocDetails dd = new DocDetails();

              
                if (DocTypeValue == "Narudzbenica")
                {
                    dd.ProductID = int.Parse(ProizvodCmb.SelectedValue.ToString()); 
                    dd.DocumentIdNumber = "";
                    dd.TotalPrice = 0;
                    dd.Kolicina = Convert.ToInt32(KolicinaTxt.Text);
                    dd.DateOfEntry = DatumUnosaTxt.Text;
                    dd.DocumentsID = DocumentsID;
                    dd.DocDetailsID = DocDetailsID;

                }
                if (DocTypeValue == "Otpremnica")
                {
                    dd.ProductID = int.Parse(ProizvodCmb.SelectedValue.ToString()); 
                    dd.DocumentIdNumber = IDtxt.Text;
                    dd.TotalPrice = Convert.ToInt32(CenaTxt.Text);
                    dd.Kolicina = Convert.ToInt32(KolicinaTxt.Text);
                    dd.DateOfEntry = DatumUnosaTxt.Text;
                    dd.DocumentsID = DocumentsID;
                    dd.DocDetailsID = DocDetailsID;
                }
                if (DocTypeValue == "Racun")
                {

                    dd.ProductID = int.Parse(ProizvodCmb.SelectedValue.ToString()); 
                    dd.DocumentIdNumber = IDtxt.Text;
                    dd.TotalPrice = Convert.ToInt32(CenaTxt.Text);
                    dd.Kolicina = Convert.ToInt32(KolicinaTxt.Text);
                    dd.DateOfEntry = "";
                    dd.DocumentsID = DocumentsID;
                    dd.DocDetailsID = DocDetailsID;
                }

                if(CRUD == "INSERT")
                {
                    _DocDetailsBL.Insert(dd);
                    CRUD = "";
                }
                if(CRUD == "UPDATE")
                {
                    _DocDetailsBL.Update(dd);
                    CRUD = "";
                }
                DocDetailsInsertBtn.Visible = true;
                DetailsUpdateBtb.Visible = true;
                DetailsDeleteBtn.Visible = true;
                PrihvatiBtn.Visible = false;
                OdustaniBtn.Visible = false;
                LoadDocDetailsData();
                clearTxt();

            }
            catch
            {
                MessageBox.Show("Niste pravilno popunili sva polja");
            }

           

        }

        private void OdustaniBtn_Click(object sender, EventArgs e)
        {
            DocDetailsInsertBtn.Visible = true;
            DetailsUpdateBtb.Visible = true;
            DetailsDeleteBtn.Visible = true;
            PrihvatiBtn.Visible = false;
            OdustaniBtn.Visible = false;
            clearTxt();
        }

        private void EvidencijaBtn_Click(object sender, EventArgs e)
        {
            ProizvodiListbx.DataSource = _DocumentBL.ProductCombo();
            ProizvodiListbx.DisplayMember = "ProductName";
            ProizvodiListbx.Visible = true;
            ZatvoriLbBtn.Visible = true;
            EvidencijaBtn.Visible = false;
            IzmenaProizvodaBtn.Visible = false;
         
        }

        private void ZatvoriLbBtn_Click(object sender, EventArgs e)
        {
            ProizvodiListbx.Visible = false;
            EvidencijaBtn.Visible = true;
            ZatvoriLbBtn.Visible = false;
            IzmenaProizvodaBtn.Visible = true;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DocUser du = new DocUser();
              
                _DocumentBL.Login(UsernameTxt.Text, PasswordTxt.Text);
                int rezultat = _DocumentBL.Login(UsernameTxt.Text, PasswordTxt.Text);

                if (rezultat > 0 )
                {
                    MessageBox.Show("Uspesno ste se ulogovali");
                    UsernameTxt.Visible = false;
                    PasswordTxt.Visible = false;
                    LoginBtn.Visible = false;
                    UsernameLbl.Visible = false;
                    PasswordLbl.Visible = false;
                    LogOutBtn.Visible = true;
                    WelcomeLbl.Text = "Dobrodosli, " + UsernameTxt.Text.ToLower();
                    LoginUser = UsernameTxt.Text.ToLower();
                    WelcomeLbl.Visible = true;
                    if(UsernameTxt.Text.ToLower() == "administrator")
                    {
                        IzmenaProizvodaBtn.Enabled = true;
                        EvidencijaBtn.Enabled = true;
                    }
                    if(UsernameTxt.Text.ToLower() != "administrator")
                    {
                        EvidencijaBtn.Enabled = true;
                    }
                    groupBox1.Visible = true;
                    groupBox2.Visible = true;
                    groupBox3.Visible = false;
                    IzmenaProizvodaBtn.Visible = true;
                    EvidencijaBtn.Visible = true;
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Pogresan Username ili Password");

                }
               
            }
            catch 
            {
                

               MessageBox.Show("Doslo je do greske");
            }
            
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            UsernameTxt.Clear();
            PasswordTxt.Clear();
            UsernameTxt.Visible = true;
            PasswordTxt.Visible = true;
            LoginBtn.Visible = true;
            UsernameLbl.Visible = true;
            PasswordLbl.Visible = true;
            LogOutBtn.Visible = false;
            IzmenaProizvodaBtn.Enabled = false;
            EvidencijaBtn.Enabled = false;
            WelcomeLbl.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            IzmenaProizvodaBtn.Visible = false;
            EvidencijaBtn.Visible = false;
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = null;
           

        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            FilterBtn.Visible = false;
            FilterCmb.Visible = true;
        }

        private void ShowAllBtnn_Click(object sender, EventArgs e)
        {
            LoadData();
            ShowAllBtnn.Visible = false;
        }

        private void FilterCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {

            FilterDocType = Convert.ToInt32( FilterCmb.SelectedValue.ToString());
            

            dataGridView2.DataSource = _DocumentBL.FilterAll(FilterDocType);
            FilterCmb.Visible = false;
            ShowAllBtnn.Visible = true;
            FilterBtn.Visible = true;
        }

        private void IzmenaProizvodaBtn_Click(object sender, EventArgs e)
        {
            IzmeniProizvodForm form = new IzmeniProizvodForm();
            form.Show();
            form.TopMost=true;
        }

        private void DetailsUpdateBtb_Click(object sender, EventArgs e)
        {
            CenaTxt.Enabled = true;
            KolicinaTxt.Enabled = true;
            ProizvodCmb.Enabled = true;
            DatumUnosaTxt.Enabled = true;
            IDtxt.Enabled = true;
            DocDetailsInsertBtn.Visible = false;
            DetailsUpdateBtb.Visible = false;
            DetailsDeleteBtn.Visible = false;
            PrihvatiBtn.Visible = true;
            OdustaniBtn.Visible = true;

            CRUD = "UPDATE";
        }

        private void DetailsDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite da obrisete ovu stavku?", "Brisanje", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _DocDetailsBL.Delete(DocDetailsID);
            }
           
            LoadDocDetailsData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    DocDetailsID = int.Parse(row.Cells["DocDetailsID"].Value.ToString());
                    CenaTxt.Text = row.Cells["TotalPrice"].Value.ToString();
                    KolicinaTxt.Text = row.Cells["Kolicina"].Value.ToString();
                    IDtxt.Text = row.Cells["DocumentIdNumber"].Value.ToString();
                    DatumUnosaTxt.Text = row.Cells["DateOfEntry"].Value.ToString();
                    ProizvodCmb.Text = row.Cells["ProductName"].Value.ToString();
                }
            
           
        }

        private void ProizvodCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ProductID = int.Parse(ProizvodCmb.SelectedValue.ToString());
        }

        private void IzmeniDocumentsBtn_Click(object sender, EventArgs e)
        {
            IzmeniDocumentsForma form = new IzmeniDocumentsForma(DocumentsID, DocType,DocUserID,DocumentFirm,DocumentName);
            form.FormClosing += new FormClosingEventHandler(this.IzmeniDocumentsForma_Closing);
            form.Show();
        }

        private void IzmeniDocumentsForma_Closing(object sender, FormClosingEventArgs e)
        {
            LoadData();
        }

        private void LoadDocDetailsData()
        {
            dataGridView1.DataSource = _DocDetailsBL.SelectAll(DocumentsID);
            dataGridView1.ClearSelection();
            dataGridView1.Columns["DocumentsID"].Visible = false;
            dataGridView1.Columns["DocDetailsID"].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["DateOfEntry"].Visible = true;
            dataGridView1.Columns["ProductExpirationDate"].Visible = true;
            dataGridView1.Columns["TotalPrice"].Visible = true;
            dataGridView1.Columns["DocumentIdNumber"].Visible = true;

            dataGridView1.Columns["ProductName"].HeaderText = "Ime proizvoda";
            dataGridView1.Columns["DocumentIdNumber"].HeaderText = "ID broj";                  
            dataGridView1.Columns["TotalPrice"].HeaderText = "Cena";
            dataGridView1.Columns["DateOfEntry"].HeaderText = "Datum unosa";
            dataGridView1.Columns["ProductExpirationDate"].HeaderText = "Rok upotrebe";
            dataGridView1.Columns["ProductTypeName"].HeaderText = "Tip proizvoda";

            dataGridView1.Columns["ProductTypeName"].DisplayIndex = 3;
            dataGridView1.Columns["TotalPrice"].DisplayIndex = 4;
            dataGridView1.Columns["Kolicina"].DisplayIndex = 8;

            if(DocTypeID == 3)
            {
                dataGridView1.Columns["DateOfEntry"].Visible = false;
                dataGridView1.Columns["ProductExpirationDate"].Visible = false;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (DocTypeID == 1)
            {

                dataGridView1.Columns["ProductExpirationDate"].Visible = false;
                dataGridView1.Columns["TotalPrice"].Visible = false;
                dataGridView1.Columns["DocumentIdNumber"].Visible = false;
                dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               
            }
            clearTxt();
        }
    }
}
