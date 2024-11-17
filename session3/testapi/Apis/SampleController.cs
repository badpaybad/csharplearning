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

using testapi.sampledbmanipulation;

namespace testapi.Apis;

[Route("api/[controller]")]
[ApiController]
public class SampleController : ControllerBase
{
    [Route("GetAll")]
    [HttpGet]
    public async Task<ApiResponse<List<SampleGetAllResponse>>> GetAll()
    {
        var db = new SampleMongodbConnect();

        var query = db.Samples.AsQueryable();

        query = query.Where(x => x.Name != "");

        var total = query.Count();

        var data = query.Select(i => new SampleGetAllResponse
        {
            Id = i.Id.ToString(),
            Name = i.Name,
            Version = i.Version,
            Settings = i.Settings,

        }).ToList();

        return new ApiResponse<List<SampleGetAllResponse>>
        {
            Code = 1,
            Data = data,
            DataCount = total
        };
    }
    [Route("Create")]
    [HttpPost]
    //[CustomAuthorization] //todo: must do your own auth
    public async Task<ApiResponse<SampleCreateResponse>> Create(SampleCreateRequest request)
    {
        // do business must not related to select data return UI

        // if want to do async UI, should enqueu data to process in other process, then inside process after created should push noti to UI 
        var id = await new SampleDomain().Create(request.Name, request.Version);


        // facade to get data return UI, if do async UI , just return success ( bool ), then inside process after created should push noti to UI
        var db = new SampleMongodbConnect();
        var data = db.Samples.FirstOrDefault(x => x.Id == id);

        return new ApiResponse<SampleCreateResponse>
        {
            Code = 1,
            Data = new SampleCreateResponse
            {
                Id = data.Id.ToString(),
                Name = data.Name,
                Version = data.Version,
            }
        };


    }
    [Route("ChangeInfo")]
    [HttpPost]
    public async Task<ApiResponse<bool>> ChangeInfo(SampleChangeInfoRequest request)
    {
        try
        {
            ObjectId.TryParse(request.Id, out var id);

            await new SampleDomain().ChangeInfo(id, request.Name, request.Version);
            return new ApiResponse<bool>
            {
                Code = 1,
                Data = true
            };
        }
        catch (Exception ex)
        {
            return new ApiResponse<bool>
            {
                Code = 0,
                CodeMsg = ex.Message
            };
        }
    }


    [Route("ChangeSettings")]
    [HttpPost]
    public async Task<ApiResponse<bool>> ChangeSettings(SampleChangeSettingsRequest request)
    {
        ObjectId.TryParse(request.Id, out var id);

        await new SampleDomain().ChangeSettings(id, request.Settings);
        return new ApiResponse<bool>
        {
            Code = 1,
            Data = true
        };
    }
}
public class SampleGetAllResponse
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Version { get; set; }
    public object Settings { get; set; }
}
public class SampleChangeInfoRequest
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Version { get; set; }
}

public class SampleChangeSettingsRequest
{
    public string Id { get; set; }
    public object Settings { get; set; }

}
public class SampleCreateRequest
{
    public string Name { get; set; }
    public string? Version { get; set; } //optional param
}
public class SampleCreateResponse
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Version { get; set; }
}