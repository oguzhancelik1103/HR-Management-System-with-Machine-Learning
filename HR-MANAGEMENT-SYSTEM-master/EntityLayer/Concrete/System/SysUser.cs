using EntityLayer.Concrete.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysUser : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int Utype { get; set; }
        public short Status { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
		//public string PasswordSalt { get; set; }
		//public string? PasswordHash { get; set; }
		public string Note { get; set; }
        public ICollection<SysUserToken> SysUserTokens { get; set; }
    }
}