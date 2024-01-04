using EntityLayer.Concrete.Inventories;
using EntityLayer.Concrete.People;
using EntityLayer.Concrete.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Connection
{
    public class InventoryConCategory : BaseEntity
    {
        public int InventoryID { get; set; }
        public Inventory Inventory { get; set; }
        public int InvCategoryID { get; set; }
        public InvCategory InvCategory { get; set; }
    }
}