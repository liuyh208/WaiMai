using System;
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
    public partial class ShopService:IShopService
    {
        public PagedResult<Shop> GetAll(ShopQuery query)
        {
            int tt = 0;
            IQueryable<Shop> result = null;
            if (string.IsNullOrEmpty(query.Name))
            {
                result = _DbSession.ShopRepository.LoadPageEntities(query.PageIndex, query.PageSize, out tt,
                    t =>true, true, s => s.Name);
            }
            else
            {
                result = _DbSession.ShopRepository.LoadPageEntities(query.PageIndex, query.PageSize, out tt,
                 t => t.Name.Contains(query.Name), true, s => s.Name);
            }

            return new PagedResult<Shop>(result.ToList(), tt);
        }
    }
}
