using EntityLayer.Concrete.People;
using EntityLayer.Concrete.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Connection
{
    public class SysPersonConShift : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int SysShiftID { get; set; }
        public SysShift SysShift { get; set; }
        public short TypeID { get; set; } //????
        public DateOnly TargetedAt { get; set; }
    }
}