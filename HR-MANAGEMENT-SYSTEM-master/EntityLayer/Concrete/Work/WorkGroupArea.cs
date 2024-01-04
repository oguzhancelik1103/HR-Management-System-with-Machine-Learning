using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Work
{
    public class WorkGroupArea : BaseEntity
    {
        public int ParentID { get; set; } // ??
        public string Title { get; set; }
    }
}