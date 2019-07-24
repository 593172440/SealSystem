namespace SealSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class SSContext : DbContext
    {

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
        /// 企业证件类型表(数据上下文)
        /// </summary>
        public DbSet<EnterpriseDocumentsType> EnterpriseDocumentsTypes { get; set; }
        /// <summary>
        /// 印章审批单位信息表(数据上下文)
        /// </summary>
        public DbSet<SealApprovalUnitInfor> SealApprovalUnitInfors { get; set; }
        /// <summary>
        /// 印章类型表(登记类别)(数据上下文)
        /// </summary>
        public DbSet<SealCategory> SealCategorys { get; set; }
        /// <summary>
        /// 印章图像信息表(数据上下文)
        /// </summary>
        public DbSet<SealImageData> SealImageDatas { get; set; }
        /// <summary>
        /// 印章基本信息表(数据上下文)
        /// </summary>
        public DbSet<SealInfor> SealInfors { get; set; }
        /// <summary>
        /// 印章制作单位信息表(数据上下文)
        /// </summary>
        public DbSet<SealMakingUnitInfor> SealMakingUnitInfors { get; set; }
        /// <summary>
        /// 章面(体)材料(数据上下文)
        /// </summary>
        public DbSet<SealMaterial> SealMaterials { get; set; }
        /// <summary>
        /// 印章形状表(数据上下文)
        /// </summary>
        public DbSet<SealShape> SealShapes { get; set; }
        /// <summary>
        /// 印章状态代码表(数据上下文)
        /// </summary>
        public DbSet<SealState> SealStates { get; set; }
        /// <summary>
        /// 印章使用单位类型表(数据上下文)
        /// </summary>
        public DbSet<SealUnitCategory> SealUnitCategorys { get; set; }
        /// <summary>
        /// 单位分类表(数据上下文)
        /// </summary>
        public DbSet<SealUnitClass> EnterpriseClasses { get; set; }
        /// <summary>
        /// 印章使用单位信息表(数据上下文)
        /// </summary>
        public DbSet<SealUseUnitInfor> UnitInfors { get; set; }
        /// <summary>
        /// 用户表(数据上下文)
        /// </summary>
        public DbSet<User> Users { get; set; }









    }


}