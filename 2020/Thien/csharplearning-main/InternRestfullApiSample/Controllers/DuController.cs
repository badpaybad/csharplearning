using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternRestfullApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuController : ControllerBase
    {
        [HttpGet]
        [Route("getall")]
        public IEnumerable<string> GetAll(string v) {
            var db = new TestGuidMongoDbContext();

            db.TestMongoEntities.Insert(new RobotCloud.CoreMongoDb.TestMongoEntity { Fullname = v, Id = Guid.NewGuid(), Title = "hello" });

            var all = db.TestMongoEntities.Select(i => i.Fullname).ToList();

            return all;
        }

       /* [HttpPost]
        [Route("insertjson")]
        public IEnumerable<string> InsertJson([FromBody] JsonSampleRequest request)
        {
            return new List<string>() { "json", "FromBody", request.Name };
        }*/

    }
}
