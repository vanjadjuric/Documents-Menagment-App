using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsProject.Entity.Classes
{
   public class Documents
    {
        public int DocumentsID { get; set; }
        public string DocumentName { get; set; }
        public string DocumentFirm { get; set; }
        public int DocTypeID { get; set; }
        public int DocUserID { get; set; }



    }
}
