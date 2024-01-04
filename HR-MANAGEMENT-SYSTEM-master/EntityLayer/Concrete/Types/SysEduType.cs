using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete.People;

namespace EntityLayer.Concrete.Types
{
    public class SysEduType : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; }
        public ICollection<PersonEdu> PersonEdus { get; set; }
    }
}