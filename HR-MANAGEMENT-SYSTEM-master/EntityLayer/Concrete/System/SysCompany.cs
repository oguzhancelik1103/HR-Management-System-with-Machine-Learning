using EntityLayer.Concrete.People;
using EntityLayer.Concrete.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysCompany : BaseEntity
    {
        public bool Status { get; set; }
        public string RegNumber { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public ICollection<PersonCard> PersonCards { get; set; }
        public ICollection<SysDepartment> SysDepartments { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
    }
}
