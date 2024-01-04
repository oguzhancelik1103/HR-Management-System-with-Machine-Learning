using EntityLayer.Concrete.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Inventories
{
    public class InvCategory : BaseEntity
    {
        public int ParentID { get; set; }
        //public Inventory Inventory { get; set; }
        public string Title { get; set; }
        public string LangKey { get; set; }
        public int SyncID { get; set; }
        public ICollection<InventoryConCategory> InventoryConCategories { get; set; }
    }
}