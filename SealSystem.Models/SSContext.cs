namespace SealSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class SSContext : DbContext
    {
       
        public SSContext(): base("con1")
        {
            Database.SetInitializer<SSContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<EngravingLevel> EngravingLevels { get; set; }
        public DbSet<EngravingType> EngravingTypes { get; set; }
        public DbSet<SealUseUnitInfor> UnitInfors { get; set; }
        public DbSet<EnterpriseClass> EnterpriseClasses { get; set; }
        public DbSet<EnterpriseDocumentsType> EnterpriseDocumentsTypes { get; set; }
        public DbSet<SealUnitCategory> SealUnitCategorys { get; set; }
        public DbSet<Handler> Handlers { get; set; }
        public DbSet<KeepRecord> keepRecords { get; set; }
        public DbSet<KeepRecordType> keepRecordTypes { get; set; }
        public DbSet<RegistrationClass> RegistrationClasses { get; set; }
        public DbSet<SealInfor> SealInfors { get; set; }
        public DbSet<SealMaterial> SealMaterials { get; set; }
        public DbSet<SealShape> SealShapes { get; set; }
        public DbSet<SealSpecification> SealSpecifications { get; set; }
        public DbSet<SealCategory> SealCategorys { get; set; }
        public DbSet<SealState> SealStates { get; set; }
    }

    
}