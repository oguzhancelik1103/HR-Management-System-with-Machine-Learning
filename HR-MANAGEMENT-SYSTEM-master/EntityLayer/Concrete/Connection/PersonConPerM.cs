using EntityLayer.Concrete.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Connection
{
    public class PersonConPerM : BaseEntity // per_con_mper
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int PerMID { get; set; }

        //public Person PersonM { get; set; }
    }
}