using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace SealSystem.WebAPI.Models.Auth
{
    public class UserIdentity : IIdentity
    {
        public UserIdentity(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; }
        public string Name { get; }

        public string AuthenticationType => throw new NotImplementedException();

        public bool IsAuthenticated => throw new NotImplementedException();
    }
}