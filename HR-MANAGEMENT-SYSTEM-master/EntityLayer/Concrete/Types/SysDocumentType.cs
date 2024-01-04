using EntityLayer.Concrete.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Types
{
    public class SysDocumentType : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; }
        public int MyProperty { get; set; }
        public short TypeID { get; set; } //SOR
        public ICollection<PersonDocument> PersonDocuments { get; set; }
    }
}