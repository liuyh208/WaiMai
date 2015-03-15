//  ***********************************************************************
// Assembly         : WaiMai.UI
// Author             : liuyh208
// Created          : 2015-03-15 15:09
// 
// Last Modified By : liuyh208
// Last Modified On :2015-03-15 15:17
// ***********************************************************************
// <copyright file="SysDicController.cs" company="">
// Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WaiMai.BLL;
using WaiMai.IBLL;

namespace WaiMai.UI.Controllers
{
    /// <summary>
    ///     Class SysDicController.
    /// </summary>
    public class SysDicController : BaseController
    {
        private ISys_DicInfoService service = new Sys_DicInfoService();
        //
        // GET: /SysDic/


        public ActionResult FoodType()
        {
            return GetSysDic("foodtype");
        }
   
        public ActionResult GetSysDic(string category)
        {
            var result =
                from s in service.LoadEntities(t => t.Category == category && t.Enable == true).OrderBy(t => t.PIndex)
                select new {s.Code, s.Text};

            return JsonDate(result);
        }
    }
}