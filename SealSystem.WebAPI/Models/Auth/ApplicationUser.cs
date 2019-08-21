using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace SealSystem.WebAPI.Models.Auth
{
    public class ApplicationUser : IPrincipal
    {
        public ApplicationUser(int id,string name)
        {
            Identity = new UserIdentity(id, name);
        }
        public IIdentity Identity { get; }

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }
    }
}