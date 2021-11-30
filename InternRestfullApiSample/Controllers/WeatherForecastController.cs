using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternRestfullApiSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InternRestfullApiSample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpGet]
        [Route("getall")]
        public IEnumerable<string> GetAll()
        {
            return new List<string>() { "nguyen phan du" };
        }


        [HttpPost]
        [Route("insert")]
        public IEnumerable<string> Insert(string ten)
        {
            return new List<string>() { "nguyen phan du" ,"post", ten};
        }

        [HttpPost]
        [Route("insertjson")]
        public IEnumerable<string> InsertJson([FromBody] JsonSampleRequest request)
        {

            return new List<string>() { "json", "FromBody", request.Name};
        }


        [HttpPost]
        [Route("insertform")]
        public IEnumerable<string> InsertFormData([FromForm] JsonSampleRequest request)
        {
            return new List<string>() { "FormData", "FromForm", request.Name };
        }
    }
}
