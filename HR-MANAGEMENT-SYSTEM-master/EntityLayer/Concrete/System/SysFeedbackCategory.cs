using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysFeedbackCategory : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; }
        public int Typeid { get; set; }

        public int sysid { get; set; }

        public ICollection<SysFeedback> SysFeedbacks { get; set; }
    }
}