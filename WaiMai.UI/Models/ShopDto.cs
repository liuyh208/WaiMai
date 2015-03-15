using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaiMai.UI.Models
{
    public class ShopDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Linker { get; set; }
        public string Telephone { get; set; }
        public string Remarks { get; set; }
    }
}