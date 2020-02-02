using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Infrastructure;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        #region Actions
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Cooperation()
        {
            return Content("关于合作");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                if (model.UserName == "admin" && model.Password == "123")
                {
                    //TODO: write session or cookie 
                    return RedirectToAction("Index");
                }
                //ModelState.AddModelError(nameof(model.Password), "用户名或密码不正确");  //nameof in C# 6.0
                ModelState.AddModelError("Password", "用户名或密码不正确");
            }
            return View();
        }

        [NonAction]
        public string ShowInfo()
        {
            return "ABC";
        }
        #endregion

        public ActionResult Notice(string lan)
        {
            ViewBag.ListNotice = new[] {"最新的疫情","2020春节推迟上班","NBA球星科比遇难"};
            
            if ("en".Equals(lan, StringComparison.OrdinalIgnoreCase))
            {
                return View("Notice_EN");
            }

            return View();
        }

        public ActionResult GetNotice(int? id)
        {
            if (!id.HasValue || id.Value == 0)
            {
                throw new ArgumentException("id不能为空或者是0","id");
            }

            return Content("ok");
        }
    }
}