  //引进TT模板的命名空间

//使用TT模板生成代码的片段
using WaiMai.Model;

namespace WaiMai.IDAL
{

	//在这里需要一个for循环来遍历数据库中所有的表放置在下面即可，这样就实现了所有的表对应的仓储显示出来了。
	    public partial interface IAddressRepository : IBaseRepository<Address>
    {
     
    }

	    public partial interface IAreaInfoRepository : IBaseRepository<AreaInfo>
    {
     
    }

	    public partial interface IBasePermissionRepository : IBaseRepository<BasePermission>
    {
     
    }

	    public partial interface IBasePermissionGroupRepository : IBaseRepository<BasePermissionGroup>
    {
     
    }

	    public partial interface IBaseRoleRepository : IBaseRepository<BaseRole>
    {
     
    }

	    public partial interface IBaseUserRepository : IBaseRepository<BaseUser>
    {
     
    }

	    public partial interface ICookInfoRepository : IBaseRepository<CookInfo>
    {
     
    }

	    public partial interface ICouponUseInfoRepository : IBaseRepository<CouponUseInfo>
    {
     
    }

	    public partial interface ICourierInfoRepository : IBaseRepository<CourierInfo>
    {
     
    }

	    public partial interface ICustomerRepository : IBaseRepository<Customer>
    {
     
    }

	    public partial interface ICustomerMessageRepository : IBaseRepository<CustomerMessage>
    {
     
    }

	    public partial interface IFoodInfoRepository : IBaseRepository<FoodInfo>
    {
     
    }

	    public partial interface ILimitTimeRepository : IBaseRepository<LimitTime>
    {
     
    }

	    public partial interface IMenuGroupRepository : IBaseRepository<MenuGroup>
    {
     
    }

	    public partial interface IMenuInfoRepository : IBaseRepository<MenuInfo>
    {
     
    }

	    public partial interface IOrderDeliveryRepository : IBaseRepository<OrderDelivery>
    {
     
    }

	    public partial interface IOrderInfoRepository : IBaseRepository<OrderInfo>
    {
     
    }

	    public partial interface IOrderItemRepository : IBaseRepository<OrderItem>
    {
     
    }

	    public partial interface IOrderProblemRepository : IBaseRepository<OrderProblem>
    {
     
    }

	    public partial interface IR_Group_PermissionRepository : IBaseRepository<R_Group_Permission>
    {
     
    }

	    public partial interface IR_Group_RoleRepository : IBaseRepository<R_Group_Role>
    {
     
    }

	    public partial interface IR_Group_UserRepository : IBaseRepository<R_Group_User>
    {
     
    }

	    public partial interface IR_Role_PermissionRepository : IBaseRepository<R_Role_Permission>
    {
     
    }

	    public partial interface IR_User_PermissionRepository : IBaseRepository<R_User_Permission>
    {
     
    }

	    public partial interface IR_User_RoleRepository : IBaseRepository<R_User_Role>
    {
     
    }

	    public partial interface IShopRepository : IBaseRepository<Shop>
    {
     
    }

	    public partial interface ISys_DicInfoRepository : IBaseRepository<Sys_DicInfo>
    {
     
    }

}