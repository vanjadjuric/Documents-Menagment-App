using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DocumentsProject.Entity.Classes;
using DocumentsProject.Data.Interfaces;
using System.Data.SqlClient;

namespace DocumentsProject.Data.Classes
{
    public class DocumentDetailsSQL : SQLMethods, IDocumentDetailsSQLRepository
    {
     
        public DocumentDetailsSQL(SqlConnection con) : base(con)
        {

        }


        public void Insert(DocDetails obj)
        {
            try
            {
               
                ExecuteScalar(CommandType.Text, "Insert into DocDetails values(@DocumentIdNumber,@DocumentsID,@ProductID,@TotalPrice,@Kolicina,@DateOfEntry)",
                   new SqlParameter[6]
                   {

                         new SqlParameter("@DocumentIdNumber",obj.DocumentIdNumber),
                         new SqlParameter("@DocumentsID",obj.DocumentsID),
                         new SqlParameter("@ProductID",obj.ProductID),
                         new SqlParameter("@TotalPrice",obj.TotalPrice),
                         new SqlParameter("@Kolicina",obj.Kolicina),
                         new SqlParameter("@DateOfEntry",obj.DateOfEntry)
                   });

            }
            catch
            {

                throw;
            }


        }

        public void Update(DocDetails obj)
        {
            try
            {

                ExecuteScalar(CommandType.Text, "Update DocDetails set DocumentIdNumber=@DocumentIdNumber, DocumentsID=@DocumentsID, ProductID=@ProductID, TotalPrice=@TotalPrice, Kolicina=@Kolicina, DateOfEntry=@DateOfEntry where DocDetailsID=@DocDetailsID",
                new SqlParameter[7]
                {
                         new SqlParameter("@DocumentIdNumber",obj.DocumentIdNumber),
                         new SqlParameter("@DocumentsID",obj.DocumentsID),
                         new SqlParameter("@ProductID",obj.ProductID),
                         new SqlParameter("@TotalPrice",obj.TotalPrice),
                         new SqlParameter("@Kolicina",obj.Kolicina),
                         new SqlParameter("@DateOfEntry",obj.DateOfEntry),
                         new SqlParameter("@DocDetailsID",obj.DocDetailsID),

                    });

            }
            catch
            {

                throw;
            }
        }

        public void Delete(int ID)
        {
            ExecuteScalar(CommandType.Text, "Delete from DocDetails where DocDetailsID=@DocDetailsID ",
                  new SqlParameter[1] { new SqlParameter("@DocDetailsID", ID) });
        }

        public List<PrikazDocumentDetails> SelectAll(int id)
        {
            try
            {

                List<PrikazDocumentDetails> ListaDokumenata = new List<PrikazDocumentDetails>();
                SqlDataReader dr = ExecuteReader(CommandType.Text,
                "select dd.DocDetailsID, dd.DocumentsID, dd.DateOfEntry, dd.TotalPrice,dd.Kolicina,dd.DocumentIdNumber, p.ProductName,pt.ProductTypeName,p.ProductExpirationDate "+
                "FROM Documents as d inner join DocDetails as dd on d.DocumentsID = dd.DocumentsID "+
                "inner join Product as p on p.ProductID = dd.ProductID "+
                "inner join ProductType as pt on pt.ProductTypeID = p.ProductTypeID where dd.DocumentsID=@DocumentsID",

                                         new SqlParameter[1]
                    {
                        new SqlParameter("@DocumentsID",id)
                    });
                while (dr.Read())
                {
                    PrikazDocumentDetails pr = new PrikazDocumentDetails();
                    
                    pr.DocDetailsID = Convert.ToInt32(dr["DocDetailsID"].ToString());                
                    pr.Kolicina = Convert.ToInt32(dr["Kolicina"].ToString());                                  
                    pr.ProductExpirationDate = dr["ProductExpirationDate"].ToString();
                    pr.ProductTypeName = dr["ProductTypeName"].ToString();                
                    pr.ProductName = dr["ProductName"].ToString();                                     
                    pr.DocumentIDNumber = dr["DocumentIdNumber"].ToString();                
                    pr.DocumentsID = Convert.ToInt32(dr["DocumentsID"].ToString());
                    if(dr["TotalPrice"].ToString() == "")
                    {
                        pr.TotalPrice = null;
                    }
                    else
                    {
                        pr.TotalPrice = Convert.ToInt32(dr["TotalPrice"].ToString());
                    }                 
                    pr.DateOFEntry = dr["DateOfEntry"].ToString();
                  
                    ListaDokumenata.Add(pr);
                }

                return ListaDokumenata;

            }
            catch
            {

                throw;
            }
        }

    
    }
}
