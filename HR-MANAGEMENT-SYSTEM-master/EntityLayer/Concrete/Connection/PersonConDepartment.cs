using EntityLayer.Concrete.People;
using EntityLayer.Concrete.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Connection
{
    public class PersonConDepartment : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int SysDepartmentID { get; set; }
        public SysDepartment SysDepartment { get; set; }
    }
}