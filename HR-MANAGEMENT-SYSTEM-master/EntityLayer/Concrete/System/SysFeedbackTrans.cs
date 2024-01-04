using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysFeedbackTrans : BaseEntity
    {
        public int SysFeedbackID { get; set; }
        public SysFeedback SysFeedback { get; set; }
        public short Status { get; set; }
        public string Note { get; set; }
    }
}
