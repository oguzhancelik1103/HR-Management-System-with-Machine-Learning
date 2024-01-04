using BusinessLayer.Concrete.System;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Models;
using EntityLayer.Concrete.System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CILOGLU_COBAN.Controllers
{
    public class LoginController : Controller
    {
		Context _context;
		EFSysUserDal efu;
		SysUserManager umg;

		public LoginController(Context context)
		{
			_context = context;
			efu = new EFSysUserDal(context);
			umg = new SysUserManager(efu);
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Index()
		{
			ClaimsPrincipal claimUser = HttpContext.User;

			if (claimUser.Identity.IsAuthenticated)
			{
				return RedirectToAction("Index", "Home");
			}

			return View();
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Index(SysUser p)
		{
			var user = _context.SysUsers.FirstOrDefault(x => x.Username == p.Username &&
				x.Password == p.Password);

			if (user != null)
			{
				var claims = new List<Claim>
				{
				new Claim(ClaimTypes.Name, p.Username)
				};

				var userid = new ClaimsIdentity(claims, "Login");
				ClaimsPrincipal principal = new ClaimsPrincipal(userid);

				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index", "Home");
			}
			return View();
		}

		[Authorize]
		public async Task<IActionResult> LogOut()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Index", "Login");
		}

	}
}