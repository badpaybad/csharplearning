using AuthSample.Dal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSample
{
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
