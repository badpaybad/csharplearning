using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        public static string GenerateToken(string userIdentity, string username, string userId, string tenantId, List<string> acls)
        {
            var userSerialise = JsonConvert.SerializeObject(new { username, userId, tenantId });

            var claims = new[] {
            new Claim(ClaimTypes.NameIdentifier, userIdentity),
            new Claim(ClaimTypes.UserData, userSerialise),
            };

            var appKey = "12345678-abcde-123456-123456-123456";

            //var key = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(appKey));
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(appKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
              appKey,
              appKey,
              claims,
              expires: DateTime.Now.AddDays(30),
              signingCredentials: creds);

            token.Payload["userId"] = userId;
            token.Payload["username"] = username;
            token.Payload["myacl"] =  acls;




            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}
