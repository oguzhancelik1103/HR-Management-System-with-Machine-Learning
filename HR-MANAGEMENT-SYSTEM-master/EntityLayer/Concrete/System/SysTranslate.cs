using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysTranslate : BaseEntity
    {
        public int SysLanguageID { get; set; } //?? short LangID
        public SysLanguage SysLanguage { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}