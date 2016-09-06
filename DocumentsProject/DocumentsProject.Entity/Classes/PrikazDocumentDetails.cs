using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsProject.Entity.Classes
{
    public class PrikazDocumentDetails
    {
        public int DocDetailsID { get; set; }    
        public string ProductName { get; set; }      
        public string DocumentIDNumber { get; set; }     
        public int DocumentsID { get; set; }
        public int? Kolicina { get; set; }
        public int? TotalPrice { get; set; }
        public string ProductTypeName { get; set; }
        public string ProductExpirationDate { get; set; }
        public string DateOFEntry { get; set; }

    }
}
