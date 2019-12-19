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
            //���ӹ���Ա��Ȩ�޹���(ע���������ֻ���½����ݿ�����һ��)
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

            //���ӹ���Ա��ע�����������ӣ�
            context.Users.AddOrUpdate(
                new User { UserName = "admin", UserPwd = "admin", EntityName = "����Ա", UserGroup_Id = 1 }
                );
            //ӡ����Ϣ��������
            context.SealInforNews.AddOrUpdate(
            new SealInforNew { EngravingLevel = "һ��", EngravingType = "Բ��", ForeignLanguageContent = "������������", MakeWay = "������ʽ", RegistrationCategory = "�Ǽ����", Note = "��ע", User_Id = 1, SealCategory_Id_Code = 1, SealContent = "ӡ������", SealInforNum = "1206123456789", SealMaterial = "�������", SealShape = "ӡ����״", SealState = "ӡ��״̬", SealUseUnitInfor_Id_UnitNumber = 1, TheProducer = "������" }
            );
        }
    }
}
