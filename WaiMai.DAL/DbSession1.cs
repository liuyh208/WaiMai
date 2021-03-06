﻿  //引进TT模板的命名空间


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiMai.IDAL;

namespace WaiMai.DAL
{
    //一次跟数据库交互的会话
    public partial class DbSession : IDbSession //代表应用程序跟数据库之间的一次会话，也是数据库访问层的统一入口
    {


	//在这里需要一个for循环来遍历数据库中所有的表放置在下面即可，这样就实现了所有的表对应的仓储显示出来了。
	        public IDAL.IAddressRepository AddressRepository
        {
            get { return new AddressRepository(); }
        }
		        public IDAL.IAreaInfoRepository AreaInfoRepository
        {
            get { return new AreaInfoRepository(); }
        }
		        public IDAL.IBasePermissionRepository BasePermissionRepository
        {
            get { return new BasePermissionRepository(); }
        }
		        public IDAL.IBasePermissionGroupRepository BasePermissionGroupRepository
        {
            get { return new BasePermissionGroupRepository(); }
        }
		        public IDAL.IBaseRoleRepository BaseRoleRepository
        {
            get { return new BaseRoleRepository(); }
        }
		        public IDAL.IBaseUserRepository BaseUserRepository
        {
            get { return new BaseUserRepository(); }
        }
		        public IDAL.ICookInfoRepository CookInfoRepository
        {
            get { return new CookInfoRepository(); }
        }
		        public IDAL.ICouponUseInfoRepository CouponUseInfoRepository
        {
            get { return new CouponUseInfoRepository(); }
        }
		        public IDAL.ICourierInfoRepository CourierInfoRepository
        {
            get { return new CourierInfoRepository(); }
        }
		        public IDAL.ICustomerRepository CustomerRepository
        {
            get { return new CustomerRepository(); }
        }
		        public IDAL.ICustomerMessageRepository CustomerMessageRepository
        {
            get { return new CustomerMessageRepository(); }
        }
		        public IDAL.IFoodInfoRepository FoodInfoRepository
        {
            get { return new FoodInfoRepository(); }
        }
		        public IDAL.ILimitTimeRepository LimitTimeRepository
        {
            get { return new LimitTimeRepository(); }
        }
		        public IDAL.IMenuGroupRepository MenuGroupRepository
        {
            get { return new MenuGroupRepository(); }
        }
		        public IDAL.IMenuInfoRepository MenuInfoRepository
        {
            get { return new MenuInfoRepository(); }
        }
		        public IDAL.IOrderDeliveryRepository OrderDeliveryRepository
        {
            get { return new OrderDeliveryRepository(); }
        }
		        public IDAL.IOrderInfoRepository OrderInfoRepository
        {
            get { return new OrderInfoRepository(); }
        }
		        public IDAL.IOrderItemRepository OrderItemRepository
        {
            get { return new OrderItemRepository(); }
        }
		        public IDAL.IOrderProblemRepository OrderProblemRepository
        {
            get { return new OrderProblemRepository(); }
        }
		        public IDAL.IR_Group_PermissionRepository R_Group_PermissionRepository
        {
            get { return new R_Group_PermissionRepository(); }
        }
		        public IDAL.IR_Group_RoleRepository R_Group_RoleRepository
        {
            get { return new R_Group_RoleRepository(); }
        }
		        public IDAL.IR_Group_UserRepository R_Group_UserRepository
        {
            get { return new R_Group_UserRepository(); }
        }
		        public IDAL.IR_Role_PermissionRepository R_Role_PermissionRepository
        {
            get { return new R_Role_PermissionRepository(); }
        }
		        public IDAL.IR_User_PermissionRepository R_User_PermissionRepository
        {
            get { return new R_User_PermissionRepository(); }
        }
		        public IDAL.IR_User_RoleRepository R_User_RoleRepository
        {
            get { return new R_User_RoleRepository(); }
        }
		        public IDAL.IShopRepository ShopRepository
        {
            get { return new ShopRepository(); }
        }
		        public IDAL.ISys_DicInfoRepository Sys_DicInfoRepository
        {
            get { return new Sys_DicInfoRepository(); }
        }
		}
}