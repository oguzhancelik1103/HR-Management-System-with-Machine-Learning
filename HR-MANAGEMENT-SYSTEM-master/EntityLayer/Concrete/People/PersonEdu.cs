using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete.Types;

namespace EntityLayer.Concrete.People
{
    public class PersonEdu : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int SysEduTypeID { get; set; }
        public SysEduType SysEduType { get; set; }
        public string InstitutionName { get; set; }
        public string SectionName { get; set; }
        public string LFile { get; set; }
        public int EndYear { get; set; }
    }
}