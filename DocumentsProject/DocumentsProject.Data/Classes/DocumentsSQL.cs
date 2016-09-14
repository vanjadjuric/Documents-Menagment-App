using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentsProject.Data.Interfaces;
using DocumentsProject.Entity.Classes;
using System.Data;


namespace DocumentsProject.Data.Classes
{
    public class DocumentsSQL:SQLMethods,IDocumentsSQLRepository
    {
        public DocumentsSQL(SqlConnection con): base(con)
        {

        }    

        public void Insert(Documents obj)
        {

            try
            {
              
                 ExecuteScalar(CommandType.StoredProcedure, @"SP_InsertDocument",
                    new SqlParameter[4]
                    {
                         new SqlParameter("@DocumentName",obj.DocumentName),
                         new SqlParameter("@DocumentFirm",obj.DocumentFirm),
                         new SqlParameter("@DocTypeID",obj.DocTypeID),
                         new SqlParameter("@DocUserID",obj.DocUserID),
                    });

            }
            catch 
            {

                throw;
            }
           
        }

        public void Update(Documents obj)
        {
            try
            {

                ExecuteScalar(CommandType.StoredProcedure, @"SP_UpdateDocument",
                new SqlParameter[4]
                {
                         new SqlParameter("@DocumentName",obj.DocumentName),
                         new SqlParameter("@DocumentFirm",obj.DocumentFirm),
                         new SqlParameter("@DocTypeID",obj.DocTypeID),                        
                         new SqlParameter("DocumentsID",obj.DocumentsID)
                    });

            }
            catch
            {

                throw;
            }
        }

        public void Delete(int ID)
        {
            try
            {
                ExecuteScalar(CommandType.StoredProcedure, @"SP_DeleteDocument",
                  new SqlParameter[1] { new SqlParameter("@DocumentsID", ID) });

            }
            catch
            {
                throw;
            }
           
        }

        public List<PrikazDocument> SelectAll()
        {
            try
            {
            
                List<PrikazDocument> ListaDokumenata = new List<PrikazDocument>();
               SqlDataReader dr = ExecuteReader(CommandType.StoredProcedure, @"SP_SelectAllDocuments",
                                        
                                        new SqlParameter[0]
                                        );
                while(dr.Read())
                {
                    PrikazDocument pr = new PrikazDocument();
                    pr.DocName = dr["DocName"].ToString();
                    pr.DocumentFirm = dr["DocumentFirm"].ToString();
                    pr.DocumentName = dr["DocumentName"].ToString();
                    pr.Name = dr["Name"].ToString();
                    pr.DocumentsID =Convert.ToInt32( dr["DocumentsID"].ToString());
                    pr.DocTypeID = Convert.ToInt32(dr["DocTypeID"].ToString());
                    pr.DocUserID = Convert.ToInt32(dr["DocUserID"].ToString());
                    ListaDokumenata.Add(pr);
                }

                return ListaDokumenata;

            }
            catch
            {

                throw;
            }
        }

        public List<DocUser> UserCombo()
        {
            try
            {

                List<DocUser> ListaUsera = new List<DocUser>();
                SqlDataReader dr = ExecuteReader(CommandType.StoredProcedure, @"SP_FillUserCombo", new SqlParameter[0]);

                while (dr.Read())
                {
                    DocUser du = new DocUser();
                    du.Name = dr["Name"].ToString();
                    du.DocUserID =Convert.ToInt32(dr["DocUserID"].ToString());
                    du.Username = dr["Username"].ToString();
                    du.UserPassword = dr["UserPassword"].ToString();
                    ListaUsera.Add(du);
                }

                return ListaUsera;

            }
            catch
            {

                throw;
            }
        }

        public List<DocType> TipDokumentaCombo()
        {
            try
            {
                List<DocType> ListaTipDokumenata = new List<DocType>();
                SqlDataReader dr = ExecuteReader(CommandType.StoredProcedure, "SP_FillDocTypeCombo", new SqlParameter[0]);

                while (dr.Read())
                {
                    DocType dt = new DocType();
                    dt.DocName = dr["DocName"].ToString();
                    dt.DocTypeID = Convert.ToInt32(dr["DocTypeID"].ToString());
                    ListaTipDokumenata.Add(dt);

                }
                return ListaTipDokumenata;

            }
            catch
            {
                throw;
            }
        }

        public List<Products> ProductCombo()
        {
            try
            {
                List<Products> ListaProizvoda = new List<Products>();
                SqlDataReader dr = ExecuteReader(CommandType.StoredProcedure, @"SP_FillProductCombo", new SqlParameter[0]);

                while (dr.Read())
                {
                    Products pr = new Products();
                    pr.ProductName = dr["ProductName"].ToString();
                    pr.ProductID = Convert.ToInt32(dr["ProductID"].ToString());
                    pr.ProductExpirationDate = dr["ProductExpirationDate"].ToString();
                    pr.ProductSerialNumber = dr["ProductSerialNumber"].ToString();
                    pr.ProductTypeID = Convert.ToInt32(dr["ProductTypeID"].ToString());
                    pr.ProductTypeName = dr["ProductTypeName"].ToString();
                    ListaProizvoda.Add(pr);

                }
                return ListaProizvoda;

            }
            catch
            {
                throw;
            }
        }

        public List<ProductType> ProductTypeCombo()
        {
            try
            {
                List<ProductType> ListaTip = new List<ProductType>();
                SqlDataReader dr = ExecuteReader(CommandType.StoredProcedure, @"SP_FillProductTypeCombo", new SqlParameter[0]);
                while(dr.Read())
                {
                    ProductType pt = new ProductType();
                    pt.ProductTypeID = Convert.ToInt32(dr["ProductTypeID"].ToString());
                    pt.ProductTypeName = dr["ProductTypeName"].ToString();
                    ListaTip.Add(pt);


                }

                return ListaTip;

            }
            catch 
            {

                throw;
            }
        }

        public int Login(string username, string password)
        {
            try
            {
                return (int) ExecuteScalar(CommandType.StoredProcedure, @"SP_Login",
                    new SqlParameter[2]
                {
                    new SqlParameter("@Username",username),
                    new SqlParameter("@UserPassword",password)
                });
        

            }
            catch 
            {

                throw;
            }
        }

        public void InsertProduct( Products obj)
        {
            try
            {
                ExecuteScalar(CommandType.StoredProcedure, @"SP_InsertProduct",
                    new SqlParameter[4]
                {
                    new SqlParameter("@ProductName", obj.ProductName),
                    new SqlParameter("@ProductSerialNumber", obj.ProductSerialNumber),
                    new SqlParameter("ProductExpirationDate", obj.ProductExpirationDate),
                    new SqlParameter("ProductTypeID", obj.ProductTypeID)
               

                });



            }
            catch
            {

                throw;
            }
        }

        public void UpdateProduct(Products obj)
        {
            try
            {

                ExecuteScalar(CommandType.StoredProcedure, @"SP_UpdateProduct",
                new SqlParameter[5]
                {
                    new SqlParameter("@ProductName", obj.ProductName),
                    new SqlParameter("@ProductSerialNumber", obj.ProductSerialNumber),
                    new SqlParameter("ProductExpirationDate", obj.ProductExpirationDate),
                    new SqlParameter("ProductTypeID", obj.ProductTypeID),
                    new SqlParameter("ProductID", obj.ProductID)
                    });

            }
            catch
            {

                throw;
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                ExecuteScalar(CommandType.StoredProcedure, @"SP_DeleteProduct",
                  
                  new SqlParameter[1] { new SqlParameter("@ProductID", id) });

            }
            catch
            {
                throw;
            }
        }

        public List<DocType> DocTypeCombo()
        {
            try
            {

                List<DocType> ListaDocTip = new List<DocType>();
                SqlDataReader dr = ExecuteReader(CommandType.StoredProcedure, @"SP_FillDocTypeCombo", new SqlParameter[0]);

                while (dr.Read())
                {
                    DocType dt = new DocType();
                    dt.DocName = dr["DocName"].ToString();
                    dt.DocTypeID = Convert.ToInt32(dr["DocTypeID"].ToString());
                    ListaDocTip.Add(dt);

                }

                return ListaDocTip;

            }
            catch
            {

                throw;
            }
        }

        public List<PrikazDocument> FilterAll(int DocTypeID)
        {
            try
            {
                List<PrikazDocument> ListaDoc = new List<PrikazDocument>();
                SqlDataReader dr = ExecuteReader(CommandType.StoredProcedure, @"SP_FilterAll",
                    new SqlParameter[1]
                    {
                        new SqlParameter("@DocTypeID", DocTypeID)
                    });
                while (dr.Read())
                {

                    PrikazDocument pr = new PrikazDocument();
                    pr.DocName = dr["DocName"].ToString();
                    pr.DocumentFirm = dr["DocumentFirm"].ToString();
                    pr.DocumentName = dr["DocumentName"].ToString();
                    pr.Name = dr["Name"].ToString();
                    pr.DocumentsID = Convert.ToInt32(dr["DocumentsID"].ToString());
                    pr.DocTypeID = Convert.ToInt32(dr["DocTypeID"].ToString());
                    pr.DocUserID = Convert.ToInt32(dr["DocUserID"].ToString());
                    ListaDoc.Add(pr);

                }
                return ListaDoc;

            }
            catch 
            {

                throw;
            }
        }
    }
}
