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
