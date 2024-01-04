using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.People
{
    public class PersonPass : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public string Nation { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }
    }
}
