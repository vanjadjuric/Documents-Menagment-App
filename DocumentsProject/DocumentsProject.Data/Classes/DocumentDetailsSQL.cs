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
               
                ExecuteScalar(CommandType.StoredProcedure, @"SP_DocDetailsInsert",
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

                ExecuteScalar(CommandType.StoredProcedure, @"SP_DocDetailsUpdate",
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
            ExecuteScalar(CommandType.StoredProcedure, @"SP_DocDetailsDelete",
                  new SqlParameter[1] { new SqlParameter("@DocDetailsID", ID) });
        }

        public List<PrikazDocumentDetails> SelectAll(int id)
        {
            try
            {

                List<PrikazDocumentDetails> ListaDokumenata = new List<PrikazDocumentDetails>();
                SqlDataReader dr = ExecuteReader(CommandType.StoredProcedure, @"SP_DocDetailsSelectAll",
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
                    pr.DateOFEntry = dr["DateOfEntry"].ToString();
                    if (dr["TotalPrice"].ToString() == "")
                    {
                        pr.TotalPrice = null;
                    }
                    else
                    {
                        pr.TotalPrice = Convert.ToInt32(dr["TotalPrice"].ToString());
                    }                 
                                     
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
