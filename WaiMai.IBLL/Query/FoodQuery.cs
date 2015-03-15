using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WaiMai.Common.@select;

namespace WaiMai.IBLL.Query
{
    public class FoodQuery : BasePagedQuery
    {
        public FoodQuery(HttpRequestBase request)
            : base(request)
        {
            var sid = request["ShopID"];
            this.ShopID =string.IsNullOrEmpty(sid)?ShopID=Guid.NewGuid():Guid.Parse(sid) ;

            this.Name = request["Name"];
            this.FoodType = request["FoodType"];
            this.SaleType = request["SaleType"];
        }
        public Guid ShopID { get; set; }

        public string Name { get; set; }

        public string FoodType { get; set; }
        public string SaleType { get; set; }

    }
}
