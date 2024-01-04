using EntityLayer.Concrete.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysSocial : BaseEntity
    {
        public int SysSocialTypeID { get; set; } // ???? RefID
        public SysSocialType SysSocialType { get; set; }
        public int CTypeID { get; set; } //sor
        public int STypeID { get; set; } //sor
        public int Status { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}