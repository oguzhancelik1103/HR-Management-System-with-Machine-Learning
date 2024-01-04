using EntityLayer.Concrete.Connection;
using EntityLayer.Concrete.People;
using EntityLayer.Concrete.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Inventories
{
    public class Inventory : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int SysCompanyID { get; set; }
        public SysCompany SysCompany { get; set; }
        public short Status { get; set; }
        public string Title { get; set; }
        public string SpecialCode { get; set; }
        public ICollection<InvTrans> InvTranses { get; set; }
        public ICollection<InventoryConCategory> InventoryConCategories { get; set; }
    }
}