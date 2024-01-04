using EntityLayer.Concrete.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysModule : BaseEntity
    {
        public int ParentID { get; set; } //??
        public short Status { get; set; }
        public short IsMain { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int OrderNo { get; set; }
        public string Vers { get; set; }
        public string LangKey { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public ICollection<SysModuleMenu> SysModuleMenus { get; set; }
        public ICollection<PersonConModule> PersonConModules { get; set; }
    }
}
