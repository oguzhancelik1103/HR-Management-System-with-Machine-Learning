using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.People
{
    public class PersonAddress : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int CTypeID { get; set; }
        public int Status { get; set; }
        public string Title { get; set; }
        public int CountryID { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Content { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
