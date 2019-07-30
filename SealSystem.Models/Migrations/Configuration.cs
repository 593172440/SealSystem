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
                new MenuTable { CodeId = 1, Name = "��Ϣ�Ǽ�", SuperiorCodeId = 0 },
                new MenuTable { CodeId = 2, Name = "ӡ����Ϣ����", SuperiorCodeId = 1 },
                new MenuTable { CodeId = 3, Name = "ʹ�õ�λ��Ϣ����", SuperiorCodeId = 1 },
                new MenuTable { CodeId = 4, Name = "���µ�λ��Ϣ����", SuperiorCodeId = 1 },
                new MenuTable { CodeId = 5, Name = "������λ��Ϣ", SuperiorCodeId = 1 },
                new MenuTable { CodeId = 6, Name = "��������", SuperiorCodeId = 0 },
                new MenuTable { CodeId = 7, Name = "������ҵ��Ϣ", SuperiorCodeId = 6 },
                new MenuTable { CodeId = 7, Name = "��������", SuperiorCodeId = 6 },
                new MenuTable { CodeId = 8, Name = "��Ϣ��ѯ", SuperiorCodeId = 0 },
                new MenuTable { CodeId = 9, Name = "ӡ����Ϣ��ѯ", SuperiorCodeId = 8 },
                new MenuTable { CodeId = 10, Name = "����֪ͨ��ѯ", SuperiorCodeId = 8 },
                new MenuTable { CodeId = 11, Name = "��̨����", SuperiorCodeId = 0 },
                new MenuTable { CodeId = 12, Name = "��λ����", SuperiorCodeId = 11 },
                new MenuTable { CodeId = 13, Name = "�������", SuperiorCodeId = 11 },
                new MenuTable { CodeId = 14, Name = "�û�����", SuperiorCodeId = 11 },
                new MenuTable { CodeId = 15, Name = "Ȩ�޹���", SuperiorCodeId = 11 },
                new MenuTable { CodeId = 16, Name = "�˵�����", SuperiorCodeId = 11 }
                );
        }
    }
}
