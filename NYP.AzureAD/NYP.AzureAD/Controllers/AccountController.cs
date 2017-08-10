using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NYP.AzureAD.Controllers
{
    [Authorize]
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        
        public IHttpActionResult GetUserName()
        {
            try
            {
                return Ok(User.Identity.Name);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
