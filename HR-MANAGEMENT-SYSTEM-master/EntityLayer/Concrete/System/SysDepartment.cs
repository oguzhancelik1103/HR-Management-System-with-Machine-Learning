using EntityLayer.Concrete.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysDepartment : BaseEntity
    {
        public int SysCompanyID { get; set; }
        public SysCompany SysCompany { get; set; }
        public int SysWorkTempID { get; set; }
        public SysWorkTemp SysWorkTemp { get; set; }
        public int ParentID { get; set; }
        public int SuperVisorID { get; set; }

        public string Title { get; set; }
        public string LangKey { get; set; }
        public short Status { get; set; }
        public int SyncID { get; set; }

        public ICollection<SysShift> SysShifts { get; set; }
        public ICollection<PersonConDepartment> PersonConDepartments { get; set; }
        public ICollection<PersonConRollcallDepartment> PersonConRollcallDepartments { get; set; }
    }
}