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
        public PagedResult<CookInfo> Search(CookQuery query)
        {
            int tt = 0;
            IQueryable<CookInfo> result = null;
            if (string.IsNullOrEmpty(query.Name))
            {
                result = _DbSession.CookInfoRepository.LoadPageEntities(query.PageIndex, query.PageSize, out tt,
                    t => true, true, s => s.Name);
            }
            else
            {
                result = _DbSession.CookInfoRepository.LoadPageEntities(query.PageIndex, query.PageSize, out tt,
                 t => t.Name.Contains(query.Name), true, s => s.Name);
            }
            return new PagedResult<CookInfo>(result.ToList(), tt); 
        }
    }
}
