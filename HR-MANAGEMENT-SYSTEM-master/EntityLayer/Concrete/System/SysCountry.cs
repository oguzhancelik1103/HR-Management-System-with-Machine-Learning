using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysCountry : BaseEntity
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public string LangKey { get; set; }
        public short Status { get; set; }
    }
}
