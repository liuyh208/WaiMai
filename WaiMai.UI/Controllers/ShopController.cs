﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using WaiMai.BLL;
using WaiMai.Common;
using WaiMai.IBLL;
using WaiMai.IBLL.Query;
using WaiMai.Model;
using WaiMai.UI.Models;

namespace WaiMai.UI.Controllers
{
    public class ShopController : BaseController
    {
        IShopService shopService=new ShopService();
        //
        // GET: /Shop/

        public ActionResult Index()
        {
            ViewBag.Key = "Shop";
            ViewBag.Controller = "Shop";
            return View();
        }

        public ActionResult GetAll()
        {
            var query = new ShopQuery(Request);
            var result = shopService.GetAll(query);

            var r = Mapper.Map<IEnumerable<Shop>, IEnumerable<ShopDto>>(result.rows);

            return JsonDate(new PagedResult<ShopDto>(r,result.total));
        }

        public ActionResult GetShopList()
        {

           var result= from  s in shopService.LoadEntities(t => true) select  new {s.Id,s.Name};
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
