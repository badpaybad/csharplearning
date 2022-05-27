using AuthSample.Dal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace AuthSample.Apis
{
    [Route("api/[controller]")]
    [ApiController]

    public class AutheticationController : ControllerBase
    {
        static Dictionary<string, string> _authDb = new Dictionary<string, string>() {
            {"dunp","123456" }
        };

        static Dictionary<string, DateTime> _tokenDb = new Dictionary<string, DateTime>();

        [HttpPost]
        [Route("Login")]
        public string Login([FromForm] string uid,[FromForm] string pwd)
        {
            _authDb.TryGetValue(uid, out var dbpwd);

            if (dbpwd != pwd)
            {
                return string.Empty;
            }

            var acls = new List<string>();

            //vào db lay acls theo uid
            acls.Add("DoSth1");

            var token = JwtTokenGenerator.GenerateToken(uid, uid, uid, uid, acls);

            _tokenDb[token] = DateTime.Now.AddDays(30);


                return token;
            }
        

        [HttpPost]
        [Route("DoSth")]
        [SampleAuthorization("DoSth")]

        public string DoSth()
        {
         
            //do nghiep vu

            return "ok";
        }


        [HttpPost]
        [Route("ChangeUserFullname")]

        [SampleAuthorization("ChangeUserFullname")]
        public string ChangeUserFullname(string fullname)
        {
            var user = (User)HttpContext.Items["currentUser"];

            throw new NotImplementedException();
        }
    }

}
