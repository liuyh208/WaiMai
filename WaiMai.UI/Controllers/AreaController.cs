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
    public class AreaController : BaseController
    {
        private IAreaInfoService _service = new AreaInfoService();
        //
        // GET: /Shop/

        public ActionResult Index()
        {
            ViewBag.Key = "area";
            ViewBag.Controller = "Area";
            return View();
        }

        public ActionResult GetAll()
        {
            var PageIndex = Request["page"] == null ? 1 : int.Parse(Request["page"]);
            var PageSize = Request["rows"] == null ? 10 : int.Parse(Request["rows"]);
            var shopID = Guid.Parse(Request["ShopID"]);
            var bto = Request["BlongTo"];

            Expression<Func<AreaInfo, bool>> filter = t => t.ShopID == shopID;
            if (!string.IsNullOrEmpty(bto))
            {
                filter = filter.And(t => t.BlongTo.Contains(bto));
            }
             int allCount = 0;
            var result = _service.LoadPageEntities(PageIndex, PageSize,  out allCount,filter, true, t => t.PIndex);

            var r = Mapper.Map<IEnumerable<AreaInfo>, IEnumerable<AreaDto>>(result);

            return JsonDate(new PagedResult<AreaDto>(r, allCount));
        }


   
        //
        // POST: /Shop/Create

        [HttpPost]
        public ActionResult Create(AreaInfo food)
        {
            //var sdate = Request["SupplyDate"];
            //food.SupplyDate = sdate;
          var max=_service.LoadEntities(t => true).Max(t => t.PIndex);
            if (!max.HasValue) max = 0;
            food.ID = Guid.NewGuid();
            food.PIndex = max + 1;
            _service.AddEntity(food);
            return Content("OK");
        }

   
        //
        // POST: /Shop/Edit/5

        [HttpPost]
        public ActionResult Edit(AreaInfo food)
        {
            //var sdate = Request["SupplyDate"];
            //food.SupplyDate = sdate;
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
