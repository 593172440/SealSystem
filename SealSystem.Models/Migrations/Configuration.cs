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
            //印章状态代码
            context.SealStates.AddOrUpdate(
                new SealState { Code = "1", Name = "已审批" },
                new SealState { Code = "2", Name = "已承接" },
                new SealState { Code = "3", Name = "已制作" },
                new SealState { Code = "4", Name = "已交付" },
                new SealState { Code = "5", Name = "已报废" },
                new SealState { Code = "6", Name = "已缴销" },
                new SealState { Code = "7", Name = "已挂失" }
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
                new MenuTable { CodeId = 1, Name = "信息登记", SuperiorCodeId = 0 },
                new MenuTable { CodeId = 2, Name = "印章信息管理", SuperiorCodeId = 1 },
                new MenuTable { CodeId = 3, Name = "使用单位信息管理", SuperiorCodeId = 1 },
                new MenuTable { CodeId = 4, Name = "制章单位信息管理", SuperiorCodeId = 1 },
                new MenuTable { CodeId = 5, Name = "备案单位信息", SuperiorCodeId = 1 },
                new MenuTable { CodeId = 6, Name = "生产管理", SuperiorCodeId = 0 },
                new MenuTable { CodeId = 7, Name = "刻章企业信息", SuperiorCodeId = 6 },
                new MenuTable { CodeId = 7, Name = "备案申请", SuperiorCodeId = 6 },
                new MenuTable { CodeId = 8, Name = "信息查询", SuperiorCodeId = 0 },
                new MenuTable { CodeId = 9, Name = "印章信息查询", SuperiorCodeId = 8 },
                new MenuTable { CodeId = 10, Name = "公告通知查询", SuperiorCodeId = 8 },
                new MenuTable { CodeId = 11, Name = "后台设置", SuperiorCodeId = 0 },
                new MenuTable { CodeId = 12, Name = "单位分类", SuperiorCodeId = 11 },
                new MenuTable { CodeId = 13, Name = "区域管理", SuperiorCodeId = 11 },
                new MenuTable { CodeId = 14, Name = "用户管理", SuperiorCodeId = 11 },
                new MenuTable { CodeId = 15, Name = "权限管理", SuperiorCodeId = 11 },
                new MenuTable { CodeId = 16, Name = "菜单管理", SuperiorCodeId = 11 }
                );
        }
    }
}
