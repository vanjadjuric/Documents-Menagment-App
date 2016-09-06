using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentsProject.Entity.Classes;

namespace DocumentsProject.Business.Interfaces
{
    public interface IDocDetailsBLRepository
    {
        void Insert(DocDetails obj);
        void Update(DocDetails obj);
        void Delete(int ID);
        List<PrikazDocumentDetails> SelectAll(int id);



    }
}
