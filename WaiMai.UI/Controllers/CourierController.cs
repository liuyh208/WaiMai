using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using WaiMai.BLL;
using WaiMai.Common;
using WaiMai.Common.Specifications;
using WaiMai.IBLL;
using WaiMai.IBLL.Query;
using WaiMai.Model;
using WaiMai.UI.Models;

namespace WaiMai.UI.Controllers
{
    public class CourierController : BaseController
    {
        private ICourierInfoService _service = new CourierInfoService();
        //
        // GET: /Shop/

        public ActionResult Index()
        {
            ViewBag.Key = "Courier";
            ViewBag.Controller = "Courier";
            return View();
        }

        public ActionResult GetAll()
        {
            var PageIndex = Request["page"] == null ? 1 : int.Parse(Request["page"]);
            var PageSize = Request["rows"] == null ? 10 : int.Parse(Request["rows"]);

            var shopID = Guid.Parse(Request["ShopID"]);
            var name = Request["Name"];
            var barcode = Request["BarCode"];

            Expression<Func<CourierInfo, bool>> filter = t => t.ShopID == shopID;
            if (!string.IsNullOrEmpty(name))
            {
                filter = filter.And(t => t.Name.Contains(name));
            }
            if (!string.IsNullOrEmpty(barcode))
            {
                filter = filter.And(t => t.BarCode==barcode);
            }
            int allCount = 0;
            var result = _service.LoadPageEntities(PageIndex, PageSize, out allCount, filter,true,t=>t.Name);

            var r = Mapper.Map<IEnumerable<CourierInfo>, IEnumerable<CourierDto>>(result);

            return JsonDate(new PagedResult<CourierDto>(r, allCount));
        }

        public ActionResult GetShopList()
        {

            var result = from s in _service.LoadEntities(t => true) select new { s.ID, s.Name };
            return JsonDate(result);
        }
       
        //
        // POST: /Shop/Create

        [HttpPost]
        public ActionResult Create(CourierInfo food)
        {
            food.ID = Guid.NewGuid();
            _service.AddEntity(food);
            return Content("OK");
        }

   
        //
        // POST: /Shop/Edit/5

        [HttpPost]
        public ActionResult Edit(CourierInfo food)
        {
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
