using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysLanguage : BaseEntity
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public short Status { get; set; }
        public ICollection<SysTranslate> SysTranslates { get; set; }
    }
}