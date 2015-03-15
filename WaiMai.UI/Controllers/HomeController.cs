using WaiMai.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WaiMai.UI.Models;

namespace WaiMai.UI.Controllers
{
    public class HomeController : BaseController
    {

        private IBLL.IMenuInfoService _menuService = new BLL.MenuInfoService();

        public ActionResult Index()
        {
            BaseUser user = Session["UserInfo"] as BaseUser;
            if (user != null)
            {
                ViewBag.UserName = user.RealName;
            }

            var lst = new List<string>();
            lst.Add("vvv1");
            lst.Add("vvv2");

            return View(lst);
        }

        public string SS()
        {
            return "it is from asp.net";
        }

        public ActionResult Menus()
        {
            var lst = new List<MenuGroupDto>();
            var groups = _menuService.GetMenuGroups();
            foreach (var menuGroup in groups)
            {
                var g = new MenuGroupDto();
                g.Text = menuGroup.Text;

                var lstMenus = _menuService.GetMenuInfos(menuGroup.Id);
                foreach (var menu in lstMenus)
                {
                    var m = new MenuDto();
                    m.Text = menu.Text;
                    m.Url = menu.Url;
                    m.Ico = menu.Ico;
                    g.MenuDtos.Add(m);
                }
                lst.Add(g);
                
            }
            return PartialView(lst);
        }
    }
}
