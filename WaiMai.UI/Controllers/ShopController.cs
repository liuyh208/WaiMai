using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WaiMai.BLL;
using WaiMai.IBLL;
using WaiMai.IBLL.Query;
using WaiMai.Model;

namespace WaiMai.UI.Controllers
{
    public class ShopController : BaseController
    {
        IShopService shopService=new ShopService();
        //
        // GET: /Shop/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var query = new ShopQuery(Request);
            var result = shopService.GetAll(query);
            return JsonDate(result);
        }
       
        //
        // POST: /Shop/Create

        [HttpPost]
        public ActionResult Create(Shop shop)
        {

            shop.Id = Guid.NewGuid();
            shopService.AddEntity(shop);
            return Content("OK");
        }

   
        //
        // POST: /Shop/Edit/5

        [HttpPost]
        public ActionResult Edit(Shop shop)
        {
            bool bl = shopService.UpdateEntity(shop);
            if (bl)
            {
                return Content("OK");
            }
            else
            {
              return  Content("更新失败");
            }
        }

        //
        // POST: /Shop/Delete/5

        [HttpPost]
        public ActionResult Delete(string id)
        {
            
                var ids = id.Split(',');

           bool bl=   shopService.DeleteEntity(t => ids.Contains(t.Id.ToString()));

            if (bl)
            {
                return Content("OK");
            }
            return Content("error");
        }
    }
}
