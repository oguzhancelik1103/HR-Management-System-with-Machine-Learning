using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete.People;

namespace EntityLayer.Concrete.Types
{
    public class SysVisaType : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; }
        public int SyncID { get; set; }
        public ICollection<PersonVisa> PersonVisas { get; set; }
    }
}
