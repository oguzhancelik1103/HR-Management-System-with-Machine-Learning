using BusinessLayer.Concrete.System;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CILOGLU_COBAN.Controllers
{
    public class UserController : Controller
    {
        Context _context;
        EFSysUserDal efd;
        SysUserManager mg;

        public UserController(Context context)
        {
            _context = context;
            efd = new EFSysUserDal(context);
            mg = new SysUserManager(efd);
        }
        public IActionResult Index()
        {
            var userValues = mg.GetList();
            return View(userValues);
        }
    }
}
