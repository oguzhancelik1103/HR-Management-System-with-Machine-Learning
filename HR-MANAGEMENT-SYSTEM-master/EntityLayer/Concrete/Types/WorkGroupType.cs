using EntityLayer.Concrete.System;
using EntityLayer.Concrete.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Types
{
    public class WorkGroupType : BaseEntity
    {
        public string Title { get; set; }
        public ICollection<WorkGroup> WorkGroups { get; set; }
    }
}
