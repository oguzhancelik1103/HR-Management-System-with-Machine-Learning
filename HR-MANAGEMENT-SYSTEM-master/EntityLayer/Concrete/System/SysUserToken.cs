using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysUserToken : BaseEntity
    {
        public int SysUserID { get; set; }
        public SysUser SysUser { get; set; }
        public string UserSign { get; set; }
        public string UserToken { get; set; }
        public DateTime EndAt { get; set; }
    }
}