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
            context.Areas.AddOrUpdate(
                new Area { Code = "120116", Name = "���" }
                );
            
        }
    }
}
