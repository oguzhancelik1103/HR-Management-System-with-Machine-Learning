using EntityLayer.Concrete.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysRollcall : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int Status { get; set; }
        public DateOnly CheckedAt { get; set; }

        // rollcall stsatus ile baglanti???
    }
}
