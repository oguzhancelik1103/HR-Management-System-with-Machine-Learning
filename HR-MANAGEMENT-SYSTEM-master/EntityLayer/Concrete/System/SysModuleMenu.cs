﻿using EntityLayer.Concrete.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysModuleMenu : BaseEntity
    {
        public int SysModuleID { get; set; }
        public SysModule SysModule { get; set; }
        public int ParentID { get; set; }
        public short Status { get; set; }
        public string Title { get; set; }
        public string MenuGroup { get; set; }
        public int OrderNo { get; set; }
        public string LangKey { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public string TestUrl { get; set; }
        public int SyncID { get; set; }
        public ICollection<PersonConModuleMenu> PersonConModuleMenus { get; set; }
        //public ICollection<SysMenuPer> SysMenuPers { get; set; }
    }
}