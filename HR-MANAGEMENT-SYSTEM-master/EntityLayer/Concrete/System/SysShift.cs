using EntityLayer.Concrete.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysShift : BaseEntity
    {
        public int SysDepartmentID { get; set; }
        public SysDepartment SysDepartment { get; set; }
        public string Title { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public ICollection<PersonConShift> PersonConShifts { get; set; }
        public ICollection<SysPersonConShift> SysPersonConShifts { get; set; }
    }
}
