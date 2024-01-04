using EntityLayer.Concrete.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Types
{
    public class SysSocialType : BaseEntity
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string LangKey { get; set; }
        public ICollection<SysSocial> SysSocials { get; set; }
    }
}