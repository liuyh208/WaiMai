using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiMai.Model;

namespace WaiMai.IBLL
{
    public partial interface IMenuInfoService
    {
        IList<MenuGroup> GetMenuGroups();

        IList<MenuInfo> GetMenuInfos(Guid groupd);
    }
}
