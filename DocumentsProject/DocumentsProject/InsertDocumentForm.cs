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
    public partial class InsertDocumentForm : Form
    {

        public DocumentsBL Document;

        public int TipID, UserID;
        public InsertDocumentForm()
        {
            InitializeComponent();
            Document = new DocumentsBL();
            LoadData();
        }

        private void ZavrsiBtn_Click(object sender, EventArgs e)
        {
            Documents d = new Documents();

            d.DocumentName = DocumentNameTxt.Text;
            d.DocumentFirm = DocumentFirmTxt.Text;
            d.DocUserID = UserID;
            d.DocTypeID = TipID;

            Document.Insert(d);


            this.Close();
           

        }

        
        void LoadData()
        {
          

            TipDocCmb.DataSource = Document.TipDokumentaCombo();
            TipDocCmb.DisplayMember = "DocName";
            TipDocCmb.ValueMember = "DocTypeID";
            TipDocCmb.SelectedIndex = -1;

            label5.Text = Form1.LoginUser.ToString();
            if (Form1.LoginUser.ToString() == "administrator")
            {
                UserID = 1;
            }
            else
            {
                UserID = 3;
            }
        }

       

        private void TipDocCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TipID = int.Parse(TipDocCmb.SelectedValue.ToString());
        }
    }
}
