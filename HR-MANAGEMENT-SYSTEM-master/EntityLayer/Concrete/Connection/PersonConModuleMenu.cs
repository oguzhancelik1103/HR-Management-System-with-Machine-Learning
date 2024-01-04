using EntityLayer.Concrete.People;
using EntityLayer.Concrete.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Connection
{
    public class PersonConModuleMenu : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int SysModuleMenuID { get; set; }
        public SysModuleMenu SysModuleMenu { get; set; }
    }
}