using AuthSample.Dal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AuthSample
{
    public class JwtTokenGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userIdentity">may be user.Id or user.Username</param>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string GenerateToken(string userIdentity, string username, string userId, string tenantId)
        {
            var userSerialise = JsonConvert.SerializeObject(new { username, userId, tenantId });

            var claims = new[] {
            new Claim(ClaimTypes.NameIdentifier, userIdentity),
            new Claim(ClaimTypes.UserData, userSerialise),
            };

            var appKey ="123";

            var key = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(appKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
              appKey,
              appKey,
              claims,
              expires: DateTime.Now.AddDays(30),
              signingCredentials: creds);

            token.Payload["userId"] = userId;
            token.Payload["username"] = username;

            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
    public class SampleAuthorizationAttribute : Attribute, IAsyncAuthorizationFilter // IAuthorizationFilter
    {
        string _acl = string.Empty;

        public SampleAuthorizationAttribute()
        {

        }
        public SampleAuthorizationAttribute(string acl)
        {
            _acl = acl;
        }
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Request.Headers.ContainsKey("Authorization") == false)
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            var token = context.HttpContext.Request.Headers["Authorization"].ToString();

            token = token.Substring(6).Trim();

            DateTime now = DateTime.Now.AddHours(-3);

            //var currentUser= context.HttpContext.Session.GetString(token);

            //if (string.IsNullOrEmpty(currentUser))
            //{

            //    context.Result = new UnauthorizedResult();
            //    return;
            //}

            //var user = JsonConvert.DeserializeObject<User>(currentUser);

            using (var db = new AuthDbContext())
            {
                var existed = db.TokenSesssions.Where(i => i.Tokens == token && (i.ExpiredAt >= now || i.ExpiredAt <= DateTime.MinValue)).FirstOrDefault();

                if (existed == null)
                {
                    context.Result = new UnauthorizedResult();
                    return;
                }

                var currentUrl = context.HttpContext.Request.Path;

                if (existed.Username == "admin")
                {

                    return;
                }

                if (!string.IsNullOrEmpty(_acl))
                {
                    var listAcl = db.UserAcls.Where(i => i.UserId == existed.UserId).ToList();

                    var listAclByUrl = db.UserAcls.Where(i => i.UserId == existed.UserId && i.Permission == currentUrl).ToList();

                    if (listAcl.Count == 0)
                    {
                        context.Result = new UnauthorizedResult();
                        return;
                    }
                }
            }

            //context.HttpContext.Items["currentUser"] = user;

        }
    }

}
