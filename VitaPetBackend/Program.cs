using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using VitaPetBackend.DataAccess;
using VitaPetBackend.Repositorios.TipoDocumento;
using VitaPetBackend.Repositorios.Usuario;
using VitaPetBackend.Services.TipoDocumento;
using VitaPetBackend.Services.Usuario;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSwaggerGen(c =>
//{
//    //c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sales API", Version = "v1" });
//    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//    {
//        //Description = @"JWT Authorization header using the Bearer scheme. <br /> <br />
//        //              Enter 'Bearer' [space] and then your token in the text input below.<br /> <br />
//        //              Example: 'Bearer 12345abcdef'<br /> <br />",
//        //Name = "Authorization",
//        //In = ParameterLocation.Header,
//        ////Type = SecuritySchemeType.ApiKey,
//        //Scheme = "Bearer"
//        Name = "Authorization",
//        Type = SecuritySchemeType.Http,
//        Scheme = "bearer",
//        BearerFormat = "JWT",
//        In = ParameterLocation.Header,
//        Description = "JWT Authorization header using the Bearer scheme."
//    });
//    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
//      {
//        {
//          new OpenApiSecurityScheme
//          {
//            Reference = new OpenApiReference
//              {
//                Type = ReferenceType.SecurityScheme,
//                Id = "Bearer"
//              },
//              //Scheme = "oauth2",
//              //Name = "Bearer",
//              //In = ParameterLocation.Header,
//            },
//            new List<string>()
//          }
//        });
//});

// Agrega configuracion del token para accesos
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:ValidIssuer"],
        ValidAudience = builder.Configuration["Jwt:ValidAudience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

builder.Services.AddDbContext<DbVitaPetContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DataBaseConnection"));
}, ServiceLifetime.Scoped);

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped< ITipoDocumentoService, TipoDocumentoService>();

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ITipoDocumentoRepository, TipoDocumentoRepository>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
