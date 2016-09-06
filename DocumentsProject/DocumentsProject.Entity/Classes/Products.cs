using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsProject.Entity.Classes
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductSerialNumber { get; set; }
        public string ProductExpirationDate { get; set; }
        public int ProductTypeID { get; set; }

        public string ProductTypeName { get; set; }


    }
}
