namespace SealSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class SSContext : DbContext
    {
        //con1是112.112.112.18；con2是本地
        public SSContext() : base("con1")
        {
            Database.SetInitializer<SSContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        /// <summary>
        /// 印章备案(审批)单位信息表(数据上下文)
        /// </summary>
        public DbSet<SealApprovalUnitInfor> SealApprovalUnitInfors { get; set; }
       
        /// <summary>
        /// 印章制作单位信息表(数据上下文)
        /// </summary>
        public DbSet<SealMakingUnitInfor> SealMakingUnitInfors { get; set; }
        /// <summary>
        /// 印章使用单位信息表(数据上下文)
        /// </summary>
        public DbSet<SealUseUnitInfor> UnitInfors { get; set; }
        /// <summary>
        /// 所有印章系统所使用的下拉列表名单
        /// </summary>
        public DbSet<SealSystemList> SealSystemLists { get; set; }
        /// <summary>
        /// 用户表(数据上下文)
        /// </summary>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// 地区区域表
        /// </summary>
        public DbSet<Area> Areas { get; set; }
        /// <summary>
        /// 文件上传表
        /// </summary>
        public DbSet<DataFile> DataFiles { get; set; }
        /// <summary>
        /// 菜单表
        /// </summary>
        public DbSet<MenuTable> MenuTables { get; set; }
        /// <summary>
        /// 用户权限表
        /// </summary>
        public DbSet<UserPermissions> UserPermissions { get; set; }
        /// <summary>
        /// 通知公告表
        /// </summary>
        public System.Data.Entity.DbSet<SealSystem.Models.AnnouncementNotice> AnnouncementNotices { get; set; }
        /// <summary>
        /// 文件和图像表
        /// </summary>
        public System.Data.Entity.DbSet<SealSystem.Models.FileAndImage> FileAndImages { get; set; }

        //------- 以下仅限数据库实例化 -----------------------

        /// <summary>
        /// 印章类型表(登记类别)(数据上下文)
        /// </summary>
        public DbSet<SealCategory> SealCategorys { get; set; }

        /// <summary>
        /// 新的印章基本信息
        /// </summary>
        public System.Data.Entity.DbSet<SealSystem.Models.SealInforNew> SealInforNews { get; set; }
  
        /// <summary>
        /// 用户组表
        /// </summary>
        public DbSet<UserGroup> UserGroups { get; set; }

        /// <summary>
        /// 印章交付信息
        /// </summary>
        public DbSet<SealTheDeliveryInformation> SealTheDeliveryInformations { get; set; }
        /// <summary>
        /// 订单信息表
        /// </summary>
        public DbSet<TheOrder> TheOrders { get; set; }
    }
}