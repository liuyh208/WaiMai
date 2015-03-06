using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiMai.Common;
using WaiMai.IBLL;
using WaiMai.IBLL.Query;
using WaiMai.Model;

namespace WaiMai.BLL
{
    public partial class CookInfoService : BaseService<CookInfo>, ICookInfoService
    {
        public PagedResult<CookInfo> Search(CookQuery cookSelect)
        {
            int tt = 0;
           var result=  _DbSession.CookInfoRepository.LoadPageEntities(cookSelect.PageIndex, cookSelect.PageSize, out tt,
                t => t.Name.Contains(cookSelect.Name), true, s => s.Name);
            return new PagedResult<CookInfo>(result.ToList(),tt);
        }
    }
}
