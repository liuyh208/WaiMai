﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataModelContainer1 : DbContext
    {
        public DataModelContainer1()
            : base("name=DataModelContainer1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BaseUser> BaseUser { get; set; }
        public DbSet<R_User_Role> R_User_Role { get; set; }
        public DbSet<BaseRole> BaseRole { get; set; }
        public DbSet<BasePermission> BasePermission { get; set; }
        public DbSet<R_User_Permission> R_User_Permission { get; set; }
        public DbSet<R_Role_Permission> R_Role_Permission { get; set; }
        public DbSet<BasePermissionGroup> BasePermissionGroup { get; set; }
        public DbSet<R_Group_Permission> R_Group_Permission { get; set; }
        public DbSet<R_Group_User> R_Group_User { get; set; }
        public DbSet<R_Group_Role> R_Group_Role { get; set; }
        public DbSet<MenuGroup> MenuGroup { get; set; }
        public DbSet<MenuInfo> MenuInfo { get; set; }
        public DbSet<CookInfo> CookInfo { get; set; }
    }
}
