using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.People
{
    public class PersonFinger : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int DeviceID { get; set; }
        public int Type { get; set; }
        public DateOnly OrginalDate { get; set; }
    }
}
