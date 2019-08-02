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
            //印章类型代码表初始化
            context.SealCategorys.AddOrUpdate(
                new SealCategory { Code = "01", Name = "单位专用章" },
                new SealCategory { Code = "02", Name = "财务专用章" },
                new SealCategory { Code = "03", Name = "税务专用章" },
                new SealCategory { Code = "04", Name = "合同专用章" },
                new SealCategory { Code = "05", Name = "法定代表人名章" },
                new SealCategory { Code = "99", Name = "其它类型印章" }
                );
            //章面(体)材料
            context.SealMaterials.AddOrUpdate(
                new SealMaterial { Code = "01", Name = "有机玻璃" },
                new SealMaterial { Code = "02", Name = "铜" },
                new SealMaterial { Code = "03", Name = "钢" },
                new SealMaterial { Code = "04", Name = "塑橡" },
                new SealMaterial { Code = "05", Name = "牛角" },
                new SealMaterial { Code = "99", Name = "其他章面材料" }
                );
            //印章使用单位类型
            context.SealUnitCategorys.AddOrUpdate(
                new SealUnitCategory { Code = "01", Name = "党政机关、人大、政协" },
                new SealUnitCategory { Code = "02", Name = "企业单位" },
                new SealUnitCategory { Code = "03", Name = "事业单位" },
                new SealUnitCategory { Code = "04", Name = "社会团体" },
                new SealUnitCategory { Code = "05", Name = "民办非企业单位" },
                new SealUnitCategory { Code = "99", Name = "其他" }
                );
            //地区区域
            context.Areas.AddOrUpdate(
                new Area { Code = "120116", Name = "天津" }
                );
            //单位分类
            context.SealUnitClasses.AddOrUpdate(
                new SealUnitClass { Name = "农,林,牧,渔业" },
                new SealUnitClass { Name = "采掘业" },
                new SealUnitClass { Name = "制造业" },
                new SealUnitClass { Name = "其它" }
                );
            //菜单表
            context.MenuTables.AddOrUpdate(
                new MenuTable { CodeId = 100, Name = "信息登记", SuperiorCodeId = 0, MenuPath = "" },
                new MenuTable { CodeId = 2, Name = "印章信息管理", SuperiorCodeId = 100, MenuPath = "<li><a href='/SealInforNews/Index'>印章信息管理</a></li>" },
                new MenuTable { CodeId = 3, Name = "使用单位信息管理", SuperiorCodeId = 100, MenuPath = "<li><a href='/SealUseUnitInfors/Index'>使用单位信息管理</a></li>" },
                new MenuTable { CodeId = 4, Name = "制章单位信息管理", SuperiorCodeId = 100, MenuPath = "<li><a href='/SealMakingUnitInfors/Index'>制章单位信息管理</a></li>" },
                new MenuTable { CodeId = 5, Name = "备案单位信息", SuperiorCodeId = 100, MenuPath = "<li><a href='/SealApprovalUnitInfors/Index'>备案单位信息</a></li>" },
                new MenuTable { CodeId = 200, Name = "生产管理", SuperiorCodeId = 0, MenuPath = "" },
                new MenuTable { CodeId = 7, Name = "刻章企业信息", SuperiorCodeId = 200, MenuPath = "<li><a href='#'>刻章企业信息</a></li>" },
                new MenuTable { CodeId = 8, Name = "备案申请", SuperiorCodeId = 200, MenuPath = "<li><a href='#'>备案申请</a></li>" },
                new MenuTable { CodeId = 300, Name = "信息查询", SuperiorCodeId = 0, MenuPath = "" },
                new MenuTable { CodeId = 10, Name = "印章信息查询", SuperiorCodeId = 300, MenuPath = "<li><a href='#'>印章信息查询</a></li>" },
                new MenuTable { CodeId = 11, Name = "公告通知查询", SuperiorCodeId = 300, MenuPath = "<li><a href='/AnnouncementNotices/Index'>公告通知查询</a></li>" },
                new MenuTable { CodeId = 400, Name = "后台设置", SuperiorCodeId = 0, MenuPath = "" },
                new MenuTable { CodeId = 13, Name = "单位分类", SuperiorCodeId = 400, MenuPath = "<li><a href='/SealUnitClasses/Index'>单位分类</a></li>" },
                new MenuTable { CodeId = 14, Name = "区域管理", SuperiorCodeId = 400, MenuPath = "<li><a href='/Areas/Index'>区域管理</a></li>" },
                new MenuTable { CodeId = 15, Name = "用户管理", SuperiorCodeId = 400, MenuPath = "<li><a href='/Users/Index'>用户管理</a></li>" },
                new MenuTable { CodeId = 16, Name = "权限管理", SuperiorCodeId = 400, MenuPath = "<li><a href='/UserPermissions/Index'>权限管理</a></li>" },
                new MenuTable { CodeId = 17, Name = "菜单管理", SuperiorCodeId = 400, MenuPath = "<li><a href='/MenuTables/Index'>菜单管理</a></li>" },
                new MenuTable { CodeId = 18, Name = "文件管理", SuperiorCodeId = 400, MenuPath = "<li><a href='/FileAndImages/Index'>文件管理</a></li>" }
                );
            //增加管理员
            context.Users.AddOrUpdate(
                new User { UserName = "admin", UserPwd = "admin", EntityName = "管理员" }
                );
            //增加管理员的权限管理(注：这个功能只能新建数据库运行一次)
            context.UserPermissions.AddOrUpdate(
                 new UserPermissions { User_Id = 1, Menu_Id = 2, Add = true, Delete = true, Edit = true },
                 new UserPermissions { User_Id = 1, Menu_Id = 3, Add = true, Delete = true, Edit = true },
                 new UserPermissions { User_Id = 1, Menu_Id = 4, Add = true, Delete = true, Edit = true },
                 new UserPermissions { User_Id = 1, Menu_Id = 5, Add = true, Delete = true, Edit = true },
                 new UserPermissions { User_Id = 1, Menu_Id = 7, Add = true, Delete = true, Edit = true },
                 new UserPermissions { User_Id = 1, Menu_Id = 8, Add = true, Delete = true, Edit = true },
                 new UserPermissions { User_Id = 1, Menu_Id = 10, Add = true, Delete = true, Edit = true },
                 new UserPermissions { User_Id = 1, Menu_Id = 11, Add = true, Delete = true, Edit = true },
                 new UserPermissions { User_Id = 1, Menu_Id = 13, Add = true, Delete = true, Edit = true },
                 new UserPermissions { User_Id = 1, Menu_Id = 14, Add = true, Delete = true, Edit = true },
                 new UserPermissions { User_Id = 1, Menu_Id = 15, Add = true, Delete = true, Edit = true },
                 new UserPermissions { User_Id = 1, Menu_Id = 16, Add = true, Delete = true, Edit = true },
                 new UserPermissions { User_Id = 1, Menu_Id = 17 },
                 new UserPermissions { User_Id = 1, Menu_Id = 18, Add = true, Delete = true, Edit = true }
                 );
        }
    }
}
