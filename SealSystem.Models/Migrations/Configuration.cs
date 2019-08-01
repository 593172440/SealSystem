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
            //ӡ�����ʹ�����ʼ��
            context.SealCategorys.AddOrUpdate(
                new SealCategory { Code = "01", Name = "��λר����" },
                new SealCategory { Code = "02", Name = "����ר����" },
                new SealCategory { Code = "03", Name = "˰��ר����" },
                new SealCategory { Code = "04", Name = "��ͬר����" },
                new SealCategory { Code = "05", Name = "��������������" },
                new SealCategory { Code = "99", Name = "��������ӡ��" }
                );
            //����(��)����
            context.SealMaterials.AddOrUpdate(
                new SealMaterial { Code = "01", Name = "�л�����" },
                new SealMaterial { Code = "02", Name = "ͭ" },
                new SealMaterial { Code = "03", Name = "��" },
                new SealMaterial { Code = "04", Name = "����" },
                new SealMaterial { Code = "05", Name = "ţ��" },
                new SealMaterial { Code = "99", Name = "�����������" }
                );
            //ӡ��ʹ�õ�λ����
            context.SealUnitCategorys.AddOrUpdate(
                new SealUnitCategory { Code = "01", Name = "�������ء��˴���Э" },
                new SealUnitCategory { Code = "02", Name = "��ҵ��λ" },
                new SealUnitCategory { Code = "03", Name = "��ҵ��λ" },
                new SealUnitCategory { Code = "04", Name = "�������" },
                new SealUnitCategory { Code = "05", Name = "������ҵ��λ" },
                new SealUnitCategory { Code = "99", Name = "����" }
                );
            //ӡ��״̬����
            context.SealStates.AddOrUpdate(
                new SealState { Code = "1", Name = "������" },
                new SealState { Code = "2", Name = "�ѳн�" },
                new SealState { Code = "3", Name = "������" },
                new SealState { Code = "4", Name = "�ѽ���" },
                new SealState { Code = "5", Name = "�ѱ���" },
                new SealState { Code = "6", Name = "�ѽ���" },
                new SealState { Code = "7", Name = "�ѹ�ʧ" }
                );
            //��������
            context.Areas.AddOrUpdate(
                new Area { Code = "120116", Name = "���" }
                );
            //��λ����
            context.SealUnitClasses.AddOrUpdate(
                new SealUnitClass { Name = "ũ,��,��,��ҵ" },
                new SealUnitClass { Name = "�ɾ�ҵ" },
                new SealUnitClass { Name = "����ҵ" },
                new SealUnitClass { Name = "����" }
                );
            //�˵���
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
                new MenuTable { CodeId = 17, Name = "�˵�����", SuperiorCodeId = 400, MenuPath = "<li><a href='/MenuTables/Index'>�˵�����</a></li>" },
                new MenuTable { CodeId = 17, Name = "�ļ�����", SuperiorCodeId = 400, MenuPath = "<li><a href='/FileAndImages/Index'>�ļ�����</a></li>" }
                );
            //���ӹ���Ա
            context.Users.AddOrUpdate(
                new User { UserName = "admin", UserPwd = "admin", EntityName = "����Ա" }
                );
            //���ӹ���Ա��Ȩ�޹���(ע���������ֻ���½����ݿ�����һ��)
            context.UserPermissions.AddOrUpdate(
                 new UserPermissions { User_Id = 1, Menu_Id = 16, Add = true, Delete = true, Edit = true }
                 );
        }
    }
}
