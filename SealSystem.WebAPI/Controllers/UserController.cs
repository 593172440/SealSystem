using SealSystem.WebAPI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SealSystem.WebAPI.Controllers
{
    [MyAuth]
    [EnableCors(origins:"*",methods:"*",headers:"*")]
    public class UserController : ApiController
    {

    }
}
