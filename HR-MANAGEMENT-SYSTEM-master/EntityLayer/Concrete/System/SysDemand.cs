using EntityLayer.Concrete.People;
using EntityLayer.Concrete.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysDemand : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int SysDemandTypeID { get; set; }
        public SysDemandType SysDemandType { get; set; }
        public int Status { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Note { get; set; }
        public string StatusNote { get; set; }
    }
}
