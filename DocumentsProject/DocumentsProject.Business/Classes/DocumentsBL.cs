using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentsProject.Data;
using DocumentsProject.Data.Classes;
using DocumentsProject.Business.Interfaces;
using DocumentsProject.Entity.Classes;
using DocumentsProject.Data.Interfaces;

namespace DocumentsProject.Business.Classes
{
    public class DocumentsBL:ConnectionMenager,IDocumentsBLRepository
    {
        public IDocumentsSQLRepository _DataDocument;

        public DocumentsBL()
        {
            _DataDocument = new DocumentsSQL(Connection);
        }

        public void Insert(Documents obj)
        {
            try
            {
                Open();
                 _DataDocument.Insert(obj);
            }
            catch
            {

                throw;
            }
            finally
            {
                Close();
            }
        }

        public void Update(Documents obj)
        {
            try
            {
                Open();
                _DataDocument.Update(obj);
            }
            catch
            {

                throw;
            }
            finally
            {
                Close();
            }
        }

        public void Delete(int ID)
        {
            try
            {
                Open();
                _DataDocument.Delete(ID);
            }
            catch
            {

                throw;
            }
            finally
            {
                Close();
            }
        }
        public List<PrikazDocument> SelectAll()
        {
            try
            {
                Open();
                return _DataDocument.SelectAll();
            }
            catch
            {

                throw;
            }
            finally
            {
                Close();
            }
        }

        public PrikazDocument SelectSingle(int ID)
        {
            throw new NotImplementedException();
        }
      
        public List<DocUser> UserCombo()
        {
            try
            {
                Open();
                return _DataDocument.UserCombo();
            }
            catch
            {

                throw;
            }
            finally
            {
                Close();
            }
        }

        public List<DocType> TipDokumentaCombo()
        {
            try
            {
                Open();
                return _DataDocument.TipDokumentaCombo();

            }
            catch 
            {

                throw;
            }
            finally
            {
                Close();
            }
        }

        public List<Products> ProductCombo()
        {
            try
            {
                Open();
                return _DataDocument.ProductCombo();

            }
            catch
            {

                throw;
            }
            finally
            {
                Close();
            }
        }

        public List<ProductType> ProductTypeCombo()
        {
            try
            {
                Open();
              return  _DataDocument.ProductTypeCombo();

            }
            catch
            {

                throw;
            }
            finally
            {
                Close();
            }

        }

        public int Login(string username, string password)
        {
            try
            {
                Open();
               return _DataDocument.Login(username, password);

            }
            catch 
            {

                throw;
            }
            finally
            {
                Close();
            }


        }

        public void InsertProduct(Products obj)
        {
            try
            {
                Open();
                _DataDocument.InsertProduct(obj);
            }
            catch
            {

                throw;
            }
            finally
            {
                Close();

            }
        }

        public void UpdateProduct(Products obj)
        {
            try
            {
                Open();
                _DataDocument.UpdateProduct(obj);
            }
            catch
            {

                throw;
            }
            finally
            {
                Close();

            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                Open();
                _DataDocument.DeleteProduct(id);
            }
            catch
            {

                throw;
            }
            finally
            {
                Close();

            }
        }

        public List<DocType> DocTypeCombo()
        {
            try
            {
                Open();
                return _DataDocument.DocTypeCombo();

            }
            catch 
            {

                throw;
            }
            finally
            {
                Close();
            }
        }

        public List<PrikazDocument> FilterAll(int DocTypeID)
        {
            try
            {
                Open();
                return _DataDocument.FilterAll(DocTypeID);


            }
            catch 
            {

                throw;
            }
            finally
            {
                Close();
            }

        }

    }
}
