using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSample
{
    public class AuthDomain
    {
        public static JwtSecurityToken ValidateToken(HttpContext httpContext)
        {
            if (!httpContext.Request.Headers.ContainsKey("Authorization")) throw new UnauthorizedAccessException();

            var token = httpContext.Request.Headers["Authorization"].ToString().Substring(6).Trim();

            var jwt = new JwtSecurityToken(token);

            if (jwt.ValidTo < DateTime.Now)
            {
                throw new UnauthorizedAccessException();
            }

            return jwt;
        }

        public static bool ValidateAcl(string aclContext, JwtSecurityToken jwt)
        {
            jwt.Payload.TryGetValue("myacl", out var val);
            jwt.Payload.TryGetValue("username", out var uid);

            var username = uid.ToString();
            var acls = new List<string>();
            return acls.Contains(aclContext);

        }
    }
}
