using EntityLayer.Concrete.Connection;
using EntityLayer.Concrete.System;
using EntityLayer.Concrete.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Work
{
    public class WorkGroup : BaseEntity
    {
        public int WorkGroupTypeID { get; set; }
        public WorkGroupType WorkGroupType { get; set; }
        public int ParentID { get; set; } //??
        public string Title { get; set; }
        public string Description { get; set; }

        //public ICollection<PersonConWorkGroup> PersonConWorkGroups { get; set; }
    }
}