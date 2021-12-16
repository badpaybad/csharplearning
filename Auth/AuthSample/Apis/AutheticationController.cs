using AuthSample.Dal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthSample.Apis
{
    [Route("api/[controller]")]
    [ApiController]

    public class AutheticationController : ControllerBase
    {

        [HttpPost]
        [Route("Login")]
        public string Login(string uid, string pwd)
        {
            using (var db = new AuthDbContext())
            {
                var existed = db.Users.Where(i => i.Username == uid && i.Password == pwd).FirstOrDefault();
                if (existed == null)
                {
                    return string.Empty;
                }

                var token = Guid.NewGuid().ToString();

                HttpContext.Session.SetString(token, JsonConvert.SerializeObject(existed));

                db.TokenSesssions.Insert(new TokenSesssion
                {
                    UserId = existed.UserId,
                    Username = existed.Username,
                    Tokens = token,
                    ExpiredAt = DateTime.Now.AddHours(3)
                });

                return token;
            }
        }

        [HttpPost]
        [Route("Logout")]
        [SampleAuthorization()]
        public string Logout()
        {

            return "ok";
        }


        [HttpPost]
        [Route("ChangeUserFullname")]
        [SampleAuthorization("account")]
        public string ChangeUserFullname(string fullname)
        {
            var user = (User)HttpContext.Items["currentUser"];

            throw new NotImplementedException();
        }
    }

}
