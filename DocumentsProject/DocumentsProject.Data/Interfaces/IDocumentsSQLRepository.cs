using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentsProject.Entity.Classes;

namespace DocumentsProject.Data.Interfaces
{
    public interface IDocumentsSQLRepository
    {
        void Insert(Documents obj);
        void Update(Documents obj);
        void Delete(int ID);
        List<PrikazDocument> SelectAll();
        List<PrikazDocument> FilterAll(int DocTypeID);
        PrikazDocument SelectSingle(int ID);
        List<DocUser> UserCombo();
        List<DocType> TipDokumentaCombo();
        List<Products> ProductCombo();
        List<ProductType> ProductTypeCombo();
        List<DocType> DocTypeCombo();
        
        int Login(string username, string password);
        void InsertProduct(Products obj);
        void UpdateProduct(Products obj);
        void DeleteProduct(int id);
    }
}
