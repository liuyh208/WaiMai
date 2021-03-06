﻿  //引进TT模板的命名空间

//使用TT模板生成代码的片段
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiMai.Model;

namespace WaiMai.IBLL
{

	//在这里需要一个for循环来遍历数据库中所有的表放置在下面即可，这样就实现了所有的表对应的仓储显示出来了。
	 public partial interface IAddressService:IBaseService<Address>
    {
	}
	 public partial interface IAreaInfoService:IBaseService<AreaInfo>
    {
	}
	 public partial interface IBasePermissionService:IBaseService<BasePermission>
    {
	}
	 public partial interface IBasePermissionGroupService:IBaseService<BasePermissionGroup>
    {
	}
	 public partial interface IBaseRoleService:IBaseService<BaseRole>
    {
	}
	 public partial interface IBaseUserService:IBaseService<BaseUser>
    {
	}
	 public partial interface ICookInfoService:IBaseService<CookInfo>
    {
	}
	 public partial interface ICouponUseInfoService:IBaseService<CouponUseInfo>
    {
	}
	 public partial interface ICourierInfoService:IBaseService<CourierInfo>
    {
	}
	 public partial interface ICustomerService:IBaseService<Customer>
    {
	}
	 public partial interface ICustomerMessageService:IBaseService<CustomerMessage>
    {
	}
	 public partial interface IFoodInfoService:IBaseService<FoodInfo>
    {
	}
	 public partial interface ILimitTimeService:IBaseService<LimitTime>
    {
	}
	 public partial interface IMenuGroupService:IBaseService<MenuGroup>
    {
	}
	 public partial interface IMenuInfoService:IBaseService<MenuInfo>
    {
	}
	 public partial interface IOrderDeliveryService:IBaseService<OrderDelivery>
    {
	}
	 public partial interface IOrderInfoService:IBaseService<OrderInfo>
    {
	}
	 public partial interface IOrderItemService:IBaseService<OrderItem>
    {
	}
	 public partial interface IOrderProblemService:IBaseService<OrderProblem>
    {
	}
	 public partial interface IR_Group_PermissionService:IBaseService<R_Group_Permission>
    {
	}
	 public partial interface IR_Group_RoleService:IBaseService<R_Group_Role>
    {
	}
	 public partial interface IR_Group_UserService:IBaseService<R_Group_User>
    {
	}
	 public partial interface IR_Role_PermissionService:IBaseService<R_Role_Permission>
    {
	}
	 public partial interface IR_User_PermissionService:IBaseService<R_User_Permission>
    {
	}
	 public partial interface IR_User_RoleService:IBaseService<R_User_Role>
    {
	}
	 public partial interface IShopService:IBaseService<Shop>
    {
	}
	 public partial interface ISys_DicInfoService:IBaseService<Sys_DicInfo>
    {
	}
}