using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete.Types;

namespace EntityLayer.Concrete.People
{
    public class PersonLeave : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int SysLeaveTypeID { get; set; }
        public SysLeaveType SysLeaveType { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public int Status { get; set; }
        public string LFile { get; set; }
        public string Note { get; set; }
        public int SyncID { get; set; }
    }
}