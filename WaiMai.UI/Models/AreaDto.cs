using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaiMai.UI.Models
{
    public class AreaDto
    {
        public Guid ID { get; set; }
        public string BlongTo { get; set; }
        public string Name { get; set; }
        public string Enable { get; set; }
        public Guid ShopID { get; set; }

        public int TimeLimit { get; set; }
    }
}