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
            context.MenuTables.AddOrUpdate(
                new MenuTable { CodeId = 100, Name = "信息登记", SuperiorCodeId = 0, MenuPath = "" },
                new MenuTable { CodeId = 2, Name = "印章信息管理", SuperiorCodeId = 100, MenuPath = "<li><a href='/SealInfors/Index'>印章信息管理</a></li>" },
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
                new MenuTable { CodeId = 17, Name = "菜单管理", SuperiorCodeId = 400, MenuPath = "<li><a href='/MenuTables/Index'>菜单管理</a></li>",Edit=true}
                );
        }
    }
}
