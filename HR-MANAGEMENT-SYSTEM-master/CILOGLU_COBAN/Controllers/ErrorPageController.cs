using Microsoft.AspNetCore.Mvc;

namespace CILOGLU_COBAN.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}