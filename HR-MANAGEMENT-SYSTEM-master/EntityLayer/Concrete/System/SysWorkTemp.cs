using EntityLayer.Concrete.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysWorkTemp : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; } // ??
        public short Status { get; set; }
        public ICollection<SysDepartment> SysDepartments { get; set; }
        public ICollection<SysWorkTempItem> SysWorkTempItems { get; set; }
        public ICollection<PersonConWorkTemp> PersonConWorkTemps { get; set; }
    }
}