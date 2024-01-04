using EntityLayer.Concrete.People;
using EntityLayer.Concrete.System;
using EntityLayer.Concrete.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Connection
{
    public class PersonConWorkGroup : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int WorkGroupID { get; set; }
        public SysWorkGroup SysWorkGroup { get; set; } // WorkGroup WorkGroup
    }
}