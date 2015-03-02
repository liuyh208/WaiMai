using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaiMai.UI.Models
{
    public class MenuGroupDto
    {
        public MenuGroupDto()
        {
            this.MenuDtos=new List<MenuDto>();
        }
        public string   Text { get; set; }

        public IList<MenuDto> MenuDtos { get; set; }
    }

    public class MenuDto
    {
        public string Text { get; set; }

        public string Url { get; set; }

        public string Ico { get; set; }
    }
}