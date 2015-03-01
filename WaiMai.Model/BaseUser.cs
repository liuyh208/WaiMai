//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WaiMai.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BaseUser
    {
        public BaseUser()
        {
            this.SecurityLevel = 9;
            this.IsStaff = 1;
            this.IsVisible = 1;
            this.Enabled = 1;
            this.AuditStatus = "已审核";
            this.R_UserInfo_Role = new HashSet<R_User_Role>();
            this.R_UserInfo_ActionInfo = new HashSet<R_User_Permission>();
            this.R_Group_User = new HashSet<R_Group_User>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string RealName { get; set; }
        public string QuickQuery { get; set; }
        public Nullable<int> SecurityLevel { get; set; }
        public string UserFrom { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> SubCompanyID { get; set; }
        public string SubCompanyName { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public Nullable<int> WorkgroupID { get; set; }
        public string WorkgroupName { get; set; }
        public string WorkCategory { get; set; }
        public Nullable<System.DateTime> ChangePasswordDate { get; set; }
        public string Duty { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Lang { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public string QICQ { get; set; }
        public string HomeAddress { get; set; }
        public string Theme { get; set; }
        public Nullable<int> IsStaff { get; set; }
        public Nullable<int> IsVisible { get; set; }
        public string UserAddRessID { get; set; }
        public Nullable<int> Enabled { get; set; }
        public string AuditStatus { get; set; }
        public Nullable<int> DeletionStateCode { get; set; }
        public string Signature { get; set; }
        public Nullable<int> SortCode { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public string CreateUserID { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifirdOn { get; set; }
        public string ModifiedUserID { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ICollection<R_User_Role> R_UserInfo_Role { get; set; }
        public virtual ICollection<R_User_Permission> R_UserInfo_ActionInfo { get; set; }
        public virtual ICollection<R_Group_User> R_Group_User { get; set; }
    }
}
