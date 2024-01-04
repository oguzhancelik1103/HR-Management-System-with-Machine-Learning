using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysWorkTempItem : BaseEntity
    {
        public int SysWorkTempID { get; set; }
        public SysWorkTemp SysWorkTemp { get; set; }
        public int dayid { get; set; } // ???

        public short Status { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public ICollection<SysFeedback> SysFeedbacks { get; set; }
    }
}