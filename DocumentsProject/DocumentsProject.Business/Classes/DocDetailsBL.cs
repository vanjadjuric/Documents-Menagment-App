using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DocumentsProject.Business.Interfaces;
using DocumentsProject.Entity.Classes;
using DocumentsProject.Data.Classes;
using DocumentsProject.Data.Interfaces;

namespace DocumentsProject.Business.Classes
{
    public class DocDetailsBL : ConnectionMenager, IDocDetailsBLRepository
    {

        public IDocumentDetailsSQLRepository _docDetailsData;

        public DocDetailsBL()
        {
            _docDetailsData = new DocumentDetailsSQL(Connection);
        }

        public void Insert(DocDetails obj)
        {
            try
            {
                Open();
                _docDetailsData.Insert(obj);                   

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

        public void Update(DocDetails obj)
        {
            try
            {
                Open();
                _docDetailsData.Update(obj);

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
                _docDetailsData.Delete(ID);

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

        public List<PrikazDocumentDetails> SelectAll(int id)
        {
            try
            {
                Open();
                return _docDetailsData.SelectAll(id);
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
