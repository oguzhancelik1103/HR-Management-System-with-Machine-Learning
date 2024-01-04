using EntityLayer.Concrete.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Types
{
    public class SysDemandType : BaseEntity
    {
        public int Status { get; set; }
        public string Title { get; set; }
        public string LangKey { get; set; }
        public ICollection<SysDemand> SysDemands { get; set; }
    }
}