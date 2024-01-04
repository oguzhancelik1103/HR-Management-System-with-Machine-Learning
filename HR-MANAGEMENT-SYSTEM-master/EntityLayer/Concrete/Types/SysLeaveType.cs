using EntityLayer.Concrete.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Types
{
    public class SysLeaveType : BaseEntity
    {
        public short IsPaid { get; set; }
        public short IsDamaged { get; set; }
        public short Status { get; set; }
        public string Title { get; set; }
        public string LangKey { get; set; }
        public int SyncID { get; set; }
        public ICollection<PersonLeave> PersonLeaves { get; set; }
    }
}