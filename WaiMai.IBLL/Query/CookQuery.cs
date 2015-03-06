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
    public class CookQuery : BasePagedQuery
    {
        public CookQuery(HttpRequestBase request):base(request)
        {
            this.Name = request["name"];
        }
        public string Name { get; set; }
    }
}
