using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class AccountController : Controller
    {
        // GET: AccountController
        public ActionResult Login()
        {
            return View();
        }


        public ActionResult Register()
        {
            return View();
        }

        public ActionResult VerifyEmail()
        {
            return View();
        }

        public ActionResult ChangePassword()
        {
            return View();
        }
    }
}
