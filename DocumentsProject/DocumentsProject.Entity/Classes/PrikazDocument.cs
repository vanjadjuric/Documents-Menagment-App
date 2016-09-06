using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsProject.Entity.Classes
{
    public class PrikazDocument
    {
        public int DocumentsID { get; set; }
        public int DocTypeID { get; set; }
        public int DocUserID { get; set; }
        public string DocumentName { get; set; }
        public string DocumentFirm { get; set; }
        public string DocName { get; set; }
        public string Name { get; set; }

    }
}
