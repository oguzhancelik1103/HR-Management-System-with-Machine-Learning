using EntityLayer.Concrete.Connection;
using EntityLayer.Concrete.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysWorkGroup : BaseEntity
    {
        public int ParentID { get; set; } // ??
        public string Title { get; set; }
        public string Code { get; set; }
        public ICollection<PersonConWorkGroup> PersonConWorkGroups { get; set; }
    }
}