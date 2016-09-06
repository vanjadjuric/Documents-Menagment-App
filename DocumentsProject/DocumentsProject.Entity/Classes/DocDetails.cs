using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsProject.Entity.Classes
{
    public class DocDetails
    {
        public int DocDetailsID { get; set; }
        public string DocumentIdNumber { get; set; }
        public string DateOfEntry { get; set; }     
        public int? Kolicina { get; set; }
        public int? TotalPrice { get; set; }
        public int ProductID { get; set; }
        public int DocumentsID { get; set; }




    }
}
