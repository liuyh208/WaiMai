using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiMai.IBLL;
using WaiMai.Model;

namespace WaiMai.BLL
{
    public partial class MenuInfoService : BaseService<MenuInfo>, IMenuInfoService
    {
        public IList<MenuGroup> GetMenuGroups()
        {
            return _DbSession.MenuGroupRepository.LoadEntities(t => t.Enabled == true).OrderBy(t=>t.POrder).ToList();
        }

        public IList<MenuInfo> GetMenuInfos(Guid groupId)
        {
            return _DbSession.MenuInfoRepository.LoadEntities(t => t.GroupID == groupId && t.Enabled == true).OrderBy(t => t.POrder).ToList();
        }
    }
}
