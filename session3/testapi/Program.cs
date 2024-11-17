
using Microsoft.Extensions.FileProviders;

using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Concurrent;
using Microsoft.AspNetCore.Mvc.Razor;


var uploadsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "uploads");
if (!Directory.Exists(uploadsFolder)) Directory.CreateDirectory(uploadsFolder);

var wwwrootFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot");
if (!Directory.Exists(wwwrootFolder)) Directory.CreateDirectory(wwwrootFolder);


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


//mvc .cshtml Add services to the container.
builder.Services.AddControllersWithViews()
.AddRazorRuntimeCompilation();
// builder.Services.AddMvc().AddRazorRuntimeCompilation();


builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Word Processing API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type=Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});

builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    ////options.LowercaseQueryStrings = true
});

builder.Services.Configure<Microsoft.AspNetCore.Http.Features.FormOptions>(options =>
{
    options.ValueLengthLimit = int.MaxValue;
    options.MultipartBodyLengthLimit = int.MaxValue; // if don't set default value is: 128 MB
    options.MultipartHeadersLengthLimit = int.MaxValue;
    options.MultipartHeadersCountLimit = int.MaxValue;

});
builder.Services.Configure<IISServerOptions>(options =>
{
    options.MaxRequestBodySize = int.MaxValue;
    options.MaxRequestBodyBufferSize = int.MaxValue;
});
builder.Services.Configure<Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServerOptions>(options =>
{
    options.Limits.MaxRequestBodySize = int.MaxValue; // if don't set default value is: 30 MB
    options.Limits.MaxRequestLineSize = int.MaxValue;
    options.Limits.MaxRequestBufferSize = int.MaxValue;
    options.Limits.MaxResponseBufferSize = int.MaxValue;
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}

app.UseSwagger();
app.UseSwaggerUI();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(uploadsFolder),
    ServeUnknownFileTypes = true,
    RequestPath = new PathString("/uploads"),
});

// app.UseHttpsRedirection();// cause with use docker will run only http:// nginx ingress will handle https and proxy pass

app.UseCors(a => a.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().SetPreflightMaxAge(TimeSpan.FromDays(1)));

app.UseAuthorization(); // todo: must implement custom auth
/*public class CustomAuthorizationAttribute : Attribute, IAsyncAuthorizationFilter {
    public virtual Task OnAuthorizationAsync(AuthorizationFilterContext context){}
}*/



// mvc .cshtml 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{lang?}");

app.MapControllers();


//anuglar usage need copy file built cmd: "ng build" in folder dist into wwwroot. 
//Check "context" proxy.conf.js in angular prj
//check "navigationUrls" ngsw-config.json
app.MapFallbackToFile("/admin/index.html");

app.Run();
