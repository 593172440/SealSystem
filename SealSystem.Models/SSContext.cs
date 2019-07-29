namespace SealSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class SSContext : DbContext
    {
        //con1是112.112.112.18；con2是本地
        public SSContext() : base("con2")
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
        /// 印章审批单位信息表(数据上下文)
        /// </summary>
        public DbSet<SealApprovalUnitInfor> SealApprovalUnitInfors { get; set; }
       
        /// <summary>
        /// 印章基本信息表(数据上下文)
        /// </summary>
        public DbSet<SealInfor> SealInfors { get; set; }
        /// <summary>
        /// 印章制作单位信息表(数据上下文)
        /// </summary>
        public DbSet<SealMakingUnitInfor> SealMakingUnitInfors { get; set; }
        /// <summary>
        /// 单位分类表(数据上下文)
        /// </summary>
        public DbSet<SealUnitClass> SealUnitClasses { get; set; }
        /// <summary>
        /// 印章使用单位信息表(数据上下文)
        /// </summary>
        public DbSet<SealUseUnitInfor> UnitInfors { get; set; }
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

        //------- 以下仅限数据库实例化 -----------------------

        /// <summary>
        /// 印章类型表(登记类别)(数据上下文)
        /// </summary>
        public DbSet<SealCategory> SealCategorys { get; set; }
        /// <summary>
        /// 章面(体)材料(数据上下文)
        /// </summary>
        public DbSet<SealMaterial> SealMaterials { get; set; }
        /// <summary>
        /// 印章状态代码表(数据上下文)
        /// </summary>
        public DbSet<SealState> SealStates { get; set; }
        /// <summary>
        /// 印章使用单位类型表(数据上下文)
        /// </summary>
        public DbSet<SealUnitCategory> SealUnitCategorys { get; set; }
    }
}