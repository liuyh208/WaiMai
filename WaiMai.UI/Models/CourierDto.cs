using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaiMai.UI.Models
{
    public class CourierDto
    {
        public System.Guid ID { get; set; }
        public string Name { get; set; }

        public string ImagePath { get; set; }
        public string Telephone { get; set; }
        public string BarCode { get; set; }
        public bool Enable { get; set; }
        public bool IsSecond { get; set; }
        public string Remarks { get; set; }

        public Guid ShopID { get; set; }
    }
}