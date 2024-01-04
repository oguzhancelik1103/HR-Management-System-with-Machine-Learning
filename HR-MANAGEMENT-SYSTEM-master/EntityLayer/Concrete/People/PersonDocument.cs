using EntityLayer.Concrete.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.People
{
    public class PersonDocument : BaseEntity
    {
        public int TypeID { get; set; }
        public SysDocumentType SysDocumentType { get; set; }
        public int PersonID { get; set; }//SOR PERSON MU RefID
        public Person Person { get; set; }
        public string LFile { get; set; }//sor
    }
}