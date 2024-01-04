using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Types
{
    public class SysContactType : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; } // language??
    }
}