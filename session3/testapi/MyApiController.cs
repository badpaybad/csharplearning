using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using cloud.core;
using cloud.core.mongodb;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;


namespace testapi.Namespace;

[Route("api/[controller]")]
[ApiController]
public class MyApiController : ControllerBase
{
    [Route("Sum")]
    [HttpGet]
    public async Task<long> SumGet(long a, long b)
    {
        return a + b;
    }
    [Route("Sum")]
    [HttpPost]
    public async Task<long> SumPost(SumRequest request)
    {
        return request.a + request.b;
    }

    
    [Route("SumForm")]
    [HttpPost]
    public async Task<long> SumForm([FromForm] SumRequest request, string ?dunp)
    {
        //dunp will be query string
        return request.a + request.b;
    }
}

public class SumRequest
{
    public long a { get; set; }
    public long b { get; set; }
}

