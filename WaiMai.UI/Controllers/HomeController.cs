using WaiMai.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WaiMai.UI.Portal.Controllers
{
    public class HomeController :BaseController
    {
        public ActionResult Index()
        {
            BaseUser user = Session["UserInfo"] as BaseUser;
            if (user != null)
            {
                ViewBag.UserName = user.RealName;
            }

            return View();
        }

    }
}
