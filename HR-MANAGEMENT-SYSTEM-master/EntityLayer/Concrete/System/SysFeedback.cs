using EntityLayer.Concrete.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysFeedback : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int FixerID { get; set; }

        public int CategoryID { get; set; }
        public SysFeedbackCategory SysFeedbackCategory { get; set; }
        public short Status { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string LFile { get; set; }
        public int Priority { get; set; }
        public ICollection<SysFeedbackTrans> SysFeedbackTrans { get; set; }
    }
}