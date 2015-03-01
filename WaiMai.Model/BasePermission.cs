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
    
    public partial class BasePermission
    {
        public BasePermission()
        {
            this.RequestURL = "";
            this.RequestHttpType = 0;
            this.AllowEdit = 1;
            this.AllowDelete = 1;
            this.IsVisible = 1;
            this.DeletionStateCode = 0;
            this.Enabled = 1;
            this.ActionType = 0;
            this.R_UserInfo_ActionInfo = new HashSet<R_User_Permission>();
            this.R_Role_Permission = new HashSet<R_Role_Permission>();
            this.R_Group_Permission = new HashSet<R_Group_Permission>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string RequestURL { get; set; }
        public Nullable<int> RequestHttpType { get; set; }
        public string PerMission { get; set; }
        public Nullable<int> AllowEdit { get; set; }
        public Nullable<int> AllowDelete { get; set; }
        public Nullable<int> IsVisible { get; set; }
        public Nullable<int> SortCode { get; set; }
        public Nullable<short> DeletionStateCode { get; set; }
        public Nullable<int> Enabled { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public string CreateUserID { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedUserID { get; set; }
        public string ModifiedBy { get; set; }
        public short ActionType { get; set; }
    
        public virtual ICollection<R_User_Permission> R_UserInfo_ActionInfo { get; set; }
        public virtual ICollection<R_Role_Permission> R_Role_Permission { get; set; }
        public virtual ICollection<R_Group_Permission> R_Group_Permission { get; set; }
    }
}
