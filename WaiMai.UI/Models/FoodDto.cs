using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaiMai.UI.Models
{
    public class FoodDto
    {
        public Guid ID { get; set; }
        public string   Name { get; set; }

        public string SupplyDate { get; set; }

        public string FoodType { get; set; }

        public string SaleType { get; set; }

        public string ShopName { get; set; }
        public string ShopID { get; set; }

        public string Remarks { get; set; }

        public bool Enable { get; set; }

        public bool Visible { get; set; }

        public bool IsPreferential { get; set; }

        public float Price { get; set; }

        public string Image { get; set; }
    }

    public class FoodViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public string SupplyDate { get; set; }

        public string FoodType { get; set; }

        public string SaleType { get; set; }

        public string ShopName { get; set; }
        public string ShopID { get; set; }

        public string Remarks { get; set; }

        public bool Enable { get; set; }

        public string Visible { get; set; }

        public string IsPreferential { get; set; }

    }
}