using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WaiMai.Common;
using WaiMai.IBLL;
using WaiMai.IBLL.Query;
using WaiMai.Model;
using WaiMai.Common.Specifications;
namespace WaiMai.BLL
{
    public partial class FoodInfoService : IFoodInfoService
    {
       
        public PagedResult<FoodInfo> GetAll(FoodQuery query)
        {
            int tt = 0;
            Expression<Func<FoodInfo, bool>> filter = t => t.ShopID==query.ShopID;

            if (!string.IsNullOrEmpty(query.Name))
            {
                filter = filter.And(t => t.Name.Contains(query.Name));
            }

            if (!string.IsNullOrEmpty(query.SaleType))
            {
                filter = filter.And(t => t.SaleType == query.SaleType);
            }

            if (!string.IsNullOrEmpty(query.FoodType))
            {
                filter = filter.And(t => t.FoodType == query.FoodType);
            }
            
            var result = _DbSession.FoodInfoRepository.LoadPageEntities(query.PageIndex, query.PageSize, out tt, filter,
                true, t => t.PIndex);
            return new PagedResult<FoodInfo>(result.ToList(), tt);
        }
    }
}
