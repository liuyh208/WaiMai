using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiMai.Common;
using WaiMai.IBLL.Query;
using WaiMai.Model;

namespace WaiMai.IBLL
{
    public partial interface IShopService
    {
        PagedResult<Shop> GetAll(ShopQuery query);
    }
}
