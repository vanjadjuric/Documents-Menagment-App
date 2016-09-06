using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentsProject.Business.Classes;
using DocumentsProject.Entity.Classes;

namespace DocumentsProject
{
    public partial class IzmeniProizvodForm : Form
    {
        DocumentsBL _DocumentBL;

        int ProductID;

        string CRUD;

        public IzmeniProizvodForm()
        {
            InitializeComponent();
            _DocumentBL = new DocumentsBL();

        }

        private void IzmeniProizvodForm_Load(object sender, EventArgs e)
        {
            LoadData();
            PrihvatiBtn.Visible = false;
            OdustaniBtn.Visible = false;
            ClearText();
        }
        private void LoadData()
        {
            dataGridView1.DataSource = _DocumentBL.ProductCombo();
            dataGridView1.Columns["ProductID"].Visible = false;
            dataGridView1.Columns["ProductTypeID"].Visible = false;
            dataGridView1.Columns["ProductName"].HeaderText = "Ime proizvoda";
            dataGridView1.Columns["ProductSerialNumber"].HeaderText = "Serijski broj";
            dataGridView1.Columns["ProductExpirationDate"].HeaderText = "Rok trajanja";
            dataGridView1.Columns["ProductTypeName"].HeaderText = "Tip proizvoda";
            dataGridView1.RowHeadersVisible = false;
            TipCmb.DataSource = _DocumentBL.ProductTypeCombo();
            TipCmb.DisplayMember = "ProductTypeName";
            TipCmb.ValueMember = "ProductTypeID";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Rows[0].Selected = false;
        }

        private void ClearText()
        {
            NazivProizvodaTxt.Enabled = false;
            NazivProizvodaTxt.Clear();
            SerijskiBrojTxt.Enabled = false;
            SerijskiBrojTxt.Clear();
            TipCmb.Enabled = false;
            TipCmb.SelectedIndex = -1;
            RokTrajanjaTxt.Enabled = false;
            RokTrajanjaTxt.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                ProductID = int.Parse(row.Cells["ProductID"].Value.ToString());
                NazivProizvodaTxt.Text = row.Cells["ProductName"].Value.ToString();
                SerijskiBrojTxt.Text = row.Cells["ProductSerialNumber"].Value.ToString();
                RokTrajanjaTxt.Text = row.Cells["ProductExpirationDate"].Value.ToString();
                TipCmb.Text = row.Cells["ProductTypeName"].Value.ToString();
              
            }
           
        }

        private void InsertProductBtn_Click(object sender, EventArgs e)
        {
            NazivProizvodaTxt.Enabled = true;
            NazivProizvodaTxt.Clear();
            SerijskiBrojTxt.Enabled = true;
            SerijskiBrojTxt.Clear();
            TipCmb.Enabled = true;
            TipCmb.SelectedIndex = -1;
            RokTrajanjaTxt.Enabled = true;
            RokTrajanjaTxt.Clear();
            PrihvatiBtn.Visible = true;
            OdustaniBtn.Visible = true;
            InsertProductBtn.Visible = false;
            DeleteProductBtn.Visible = false;
            UpdateProductBtn.Visible = false;
            CRUD = "INSERT";
        }

        private void PrihvatiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Products pr = new Products();
                pr.ProductName = NazivProizvodaTxt.Text;
                pr.ProductSerialNumber = SerijskiBrojTxt.Text;
                pr.ProductExpirationDate = RokTrajanjaTxt.Text;
                pr.ProductTypeID = int.Parse(TipCmb.SelectedValue.ToString());
                pr.ProductID = ProductID;



                if (CRUD == "INSERT")
                {
                    _DocumentBL.InsertProduct(pr);
                }
                if (CRUD == "UPDATE")
                {
                    _DocumentBL.UpdateProduct(pr);

                }


                PrihvatiBtn.Visible = false;
                OdustaniBtn.Visible = false;
                InsertProductBtn.Visible = true;
                DeleteProductBtn.Visible = true;
                UpdateProductBtn.Visible = true;

                LoadData();
                ClearText();

            }
            catch
            {
                MessageBox.Show("Niste popunili sva polja pravilno");
            }
           
        }

        private void OdustaniBtn_Click(object sender, EventArgs e)
        {
            PrihvatiBtn.Visible = false;
            OdustaniBtn.Visible = false;
            InsertProductBtn.Visible = true;
            DeleteProductBtn.Visible = true;
            UpdateProductBtn.Visible = true;
            ClearText();
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite da obrisete ovaj proizvod?", "Brisanje", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _DocumentBL.DeleteProduct(ProductID);
                LoadData();
            }
           
           

        }

        private void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            NazivProizvodaTxt.Enabled = true;            
            SerijskiBrojTxt.Enabled = true;            
            TipCmb.Enabled = true;
            RokTrajanjaTxt.Enabled = true;

            PrihvatiBtn.Visible = true;
            OdustaniBtn.Visible = true;
            InsertProductBtn.Visible = false;
            DeleteProductBtn.Visible = false;
            UpdateProductBtn.Visible = false;
            CRUD = "UPDATE";
        }
    }
}
