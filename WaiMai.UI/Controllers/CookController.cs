using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WaiMai.BLL;
using WaiMai.IBLL.Query;

namespace WaiMai.UI.Controllers
{
    public class CookController : BaseController
    {
        //
        // GET: /Cook/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var sel = new CookQuery(Request);
            IBLL.ICookInfoService cookInfoService=new CookInfoService();
            var result= cookInfoService.Search(sel);
            return JsonDate(result);
        }
        //
        // GET: /Cook/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Cook/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cook/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cook/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Cook/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cook/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Cook/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
