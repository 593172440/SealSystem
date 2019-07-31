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
                new MenuTable { CodeId = 100, Name = "��Ϣ�Ǽ�", SuperiorCodeId = 0, MenuPath = "" },
                new MenuTable { CodeId = 2, Name = "ӡ����Ϣ����", SuperiorCodeId = 100, MenuPath = "<li><a href='/SealInfors/Index'>ӡ����Ϣ����</a></li>" },
                new MenuTable { CodeId = 3, Name = "ʹ�õ�λ��Ϣ����", SuperiorCodeId = 100, MenuPath = "<li><a href='/SealUseUnitInfors/Index'>ʹ�õ�λ��Ϣ����</a></li>" },
                new MenuTable { CodeId = 4, Name = "���µ�λ��Ϣ����", SuperiorCodeId = 100, MenuPath = "<li><a href='/SealMakingUnitInfors/Index'>���µ�λ��Ϣ����</a></li>" },
                new MenuTable { CodeId = 5, Name = "������λ��Ϣ", SuperiorCodeId = 100, MenuPath = "<li><a href='/SealApprovalUnitInfors/Index'>������λ��Ϣ</a></li>" },
                new MenuTable { CodeId = 200, Name = "��������", SuperiorCodeId = 0, MenuPath = "" },
                new MenuTable { CodeId = 7, Name = "������ҵ��Ϣ", SuperiorCodeId = 200, MenuPath = "<li><a href='#'>������ҵ��Ϣ</a></li>" },
                new MenuTable { CodeId = 8, Name = "��������", SuperiorCodeId = 200, MenuPath = "<li><a href='#'>��������</a></li>" },
                new MenuTable { CodeId = 300, Name = "��Ϣ��ѯ", SuperiorCodeId = 0, MenuPath = "" },
                new MenuTable { CodeId = 10, Name = "ӡ����Ϣ��ѯ", SuperiorCodeId = 300, MenuPath = "<li><a href='#'>ӡ����Ϣ��ѯ</a></li>" },
                new MenuTable { CodeId = 11, Name = "����֪ͨ��ѯ", SuperiorCodeId = 300, MenuPath = "<li><a href='/AnnouncementNotices/Index'>����֪ͨ��ѯ</a></li>" },
                new MenuTable { CodeId = 400, Name = "��̨����", SuperiorCodeId = 0, MenuPath = "" },
                new MenuTable { CodeId = 13, Name = "��λ����", SuperiorCodeId = 400, MenuPath = "<li><a href='/SealUnitClasses/Index'>��λ����</a></li>" },
                new MenuTable { CodeId = 14, Name = "�������", SuperiorCodeId = 400, MenuPath = "<li><a href='/Areas/Index'>�������</a></li>" },
                new MenuTable { CodeId = 15, Name = "�û�����", SuperiorCodeId = 400, MenuPath = "<li><a href='/Users/Index'>�û�����</a></li>" },
                new MenuTable { CodeId = 16, Name = "Ȩ�޹���", SuperiorCodeId = 400, MenuPath = "<li><a href='/UserPermissions/Index'>Ȩ�޹���</a></li>" },
                new MenuTable { CodeId = 17, Name = "�˵�����", SuperiorCodeId = 400, MenuPath = "<li><a href='/MenuTables/Index'>�˵�����</a></li>",Edit=true}
                );
        }
    }
}
