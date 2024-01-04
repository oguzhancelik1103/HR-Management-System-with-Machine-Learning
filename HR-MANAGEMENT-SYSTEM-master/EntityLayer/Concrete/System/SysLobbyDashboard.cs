using EntityLayer.Concrete.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysLobbyDashboard : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; }
        public ICollection<PersonConDashboard> PersonConDashboards { get; set; }
    }
}