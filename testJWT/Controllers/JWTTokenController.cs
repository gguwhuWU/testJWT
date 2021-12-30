using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace testJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JWTTokenController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "JWTToken", "Get ( no Authorize )" };
        }

        [HttpPut]
        [Authorize]
        public IEnumerable<string> Put()
        {
            return new string[] { "JWTToken", "Put ( has Authorize)" };
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IEnumerable<string> Post()
        {
            return new string[] { "JWTToken", "Post ( has Authorize and Roles=Admin )" };
        }

        [HttpDelete]
        [Authorize(Roles = "Admind")]
        public IEnumerable<string> Delete()
        {
            return new string[] { "JWTToken", "Post ( has Authorize and Roles=Admind )" };
        }
    }
}
