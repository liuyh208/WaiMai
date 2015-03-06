using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WaiMai.Common.@select;

namespace WaiMai.IBLL.Query
{
    public  class BasePagedQuery:ParamterQuery
    {
        public BasePagedQuery(HttpRequestBase request)
        {
            if (request==null)
            {
                this.PageIndex = 1;
                this.PageSize = 10;
            }
            this.PageIndex = request["page"] == null ? 1 : int.Parse(request["page"]);
            this.PageSize = request["rows"] == null ? 10 : int.Parse(request["rows"]);
        }
    }
}
