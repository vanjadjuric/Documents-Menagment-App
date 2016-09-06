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
    public partial class IzmeniDocumentsForma : Form
    {
        public int _id;
        public DocumentsBL _documentBL;

        public IzmeniDocumentsForma(int id,string DocType,int DocUserID, string DocumentFirm,string DocumentName)
        {
            InitializeComponent();
            _documentBL = new DocumentsBL();
            LoadData();
            _id = id;                     
            UpdateImeTxt.Text = DocumentName;
            UpdateFirmaTxt.Text = DocumentFirm;
            TipCmb.Text = DocType;
                  
        }

        private void IzmeniDocumentsForma_Load(object sender, EventArgs e)
        {
            KorisnikLb.Text = Form1.LoginUser.ToString();
            
           
        }

        private void PrihvatiBtn_Click(object sender, EventArgs e)
        {
            Documents d = new Documents();

            d.DocumentsID = _id;
            d.DocumentName = UpdateImeTxt.Text;
            d.DocumentFirm = UpdateFirmaTxt.Text;           
            d.DocTypeID = int.Parse(TipCmb.SelectedValue.ToString());

            _documentBL.Update(d);

            this.Close();

        }

        private void LoadData()
        {
            TipCmb.DataSource = _documentBL.TipDokumentaCombo();
            TipCmb.DisplayMember = "DocName";
            TipCmb.ValueMember = "DocTypeID";
            TipCmb.Enabled = false;
            
        }
    }
}
