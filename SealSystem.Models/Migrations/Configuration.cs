namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SealSystem.Models.SSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SealSystem.Models.SSContext context)
        {
            //增加管理员的权限管理(注：这个功能只能新建数据库运行一次)
            context.UserPermissions.AddOrUpdate(
                 new UserPermissions { UserGroup_Id = 1, MenuTables_CodeId = 2, Add = true, Delete = true, Edit = true },
                 new UserPermissions { UserGroup_Id = 1, MenuTables_CodeId = 3, Add = true, Delete = true, Edit = true },
                 new UserPermissions { UserGroup_Id = 1, MenuTables_CodeId = 7, Add = true, Delete = true, Edit = true },
                 new UserPermissions { UserGroup_Id = 1, MenuTables_CodeId = 8, Add = true, Delete = true, Edit = true },
                 new UserPermissions { UserGroup_Id = 1, MenuTables_CodeId = 9, Add = true, Delete = true, Edit = true },
                 new UserPermissions { UserGroup_Id = 1, MenuTables_CodeId = 11, Add = true, Delete = true, Edit = true },
                 new UserPermissions { UserGroup_Id = 1, MenuTables_CodeId = 12, Add = true, Delete = true, Edit = true },
                 new UserPermissions { UserGroup_Id = 1, MenuTables_CodeId = 14, Add = true, Delete = true, Edit = true },
                 new UserPermissions { UserGroup_Id = 1, MenuTables_CodeId = 15, Add = true, Delete = true, Edit = true },
                 new UserPermissions { UserGroup_Id = 1, MenuTables_CodeId = 16, Add = true, Delete = true, Edit = true },
                 new UserPermissions { UserGroup_Id = 1, MenuTables_CodeId = 17, Add = true, Delete = true, Edit = true },
                 new UserPermissions { UserGroup_Id = 1, MenuTables_CodeId = 18 },
                 new UserPermissions { UserGroup_Id = 1, MenuTables_CodeId = 19, Add = true, Delete = true, Edit = true }
                 );

            //增加管理员（注：这个最后增加）
            context.Users.AddOrUpdate(
                new User { UserName = "admin", UserPwd = "admin", EntityName = "管理员", UserGroup_Id = 1 }
                );
            //印章信息测试数据
            context.SealInforNews.AddOrUpdate(
            new SealInforNew { EngravingLevel = "一级", EngravingType = "圆形", ForeignLanguageContent = "测试外文内容", MakeWay = "制作方式", RegistrationCategory = "登记类别", Note = "备注", User_Id = 1, SealCategory_Id_Code = 1, SealContent = "印章内容", SealInforNum = "1206123456789", SealMaterial = "章体材料", SealShape = "印章形状", SealState = "印章状态", SealUseUnitInfor_Id_UnitNumber = 1, TheProducer = "制作人" }
            );
        }
    }
}
