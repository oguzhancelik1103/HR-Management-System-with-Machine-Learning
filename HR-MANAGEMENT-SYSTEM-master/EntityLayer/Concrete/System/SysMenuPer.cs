﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysMenuPer : BaseEntity
    {
        public int SysModuleMenuID { get; set; } // MenuID

        //public SysModuleMenu SysModuleMenu { get; set; }
        public short Status { get; set; }
        public string Title { get; set; }
        public string LangKey { get; set; } // ???
        public string PerKey { get; set; } // ???
    }
}