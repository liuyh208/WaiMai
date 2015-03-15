using System;
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
    public class FoodController : BaseController
    {
        private IFoodInfoService _service = new FoodInfoService();
        //
        // GET: /Shop/

        public ActionResult Index()
        {
            ViewBag.Key = "Food";
            ViewBag.Controller = "Food";
            return View();
        }

        public ActionResult GetAll()
        {
            var query = new FoodQuery(Request);
            var result = _service.GetAll(query);
            var r = Mapper.Map<IEnumerable<FoodInfo>, IEnumerable<FoodDto>>(result.rows);
            return JsonDate(new PagedResult<FoodDto>(r,result.total));
        }

        public ActionResult GetShopList()
        {

            var result = from s in _service.LoadEntities(t => true) select new { s.ID, s.Name };
            return JsonDate(result);
        }
       
        //
        // POST: /Shop/Create

        [HttpPost]
        public ActionResult Create(FoodInfo food)
        {
            var sdate = Request["SupplyDate"];
            food.SupplyDate = sdate;
            food.ID = Guid.NewGuid();
            _service.AddEntity(food);
            return Content("OK");
        }

   
        //
        // POST: /Shop/Edit/5

        [HttpPost]
        public ActionResult Edit(FoodInfo food)
        {
            var sdate = Request["SupplyDate"];
            food.SupplyDate = sdate;
            bool bl = _service.UpdateEntity(food);
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

                bool bl = _service.DeleteEntity(t => ids.Contains(t.ID.ToString()));

            if (bl)
            {
                return Content("OK");
            }
            return Content("error");
        }
    }
}
