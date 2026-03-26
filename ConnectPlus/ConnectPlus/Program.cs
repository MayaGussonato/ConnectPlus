using ConnectPlus.Interfaces;
using ConnectPlus.Repositories;
using ConnectPlus.WebAPI.BdContextConnect;
using ContatoPlus.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ConnectPlusContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

//injetao de dependencia
builder.Services.AddScoped<ITipoContatoRepository, TipoContatoRepository>();
//injetao de dependencia
builder.Services.AddScoped<IContatoRepository, ContatoRepository>();

//Adiciona Swagger
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API de Contatos",
        Description = "Aplicacao para gerenciamento de contatos",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Mayara Gussonato",
            Url = new Uri("https://github.com/MayaGussonato")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }



    });
});
builder.Services.AddOpenApi();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger(options => { });
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty; // Define a raiz para acessar o Swagger UI
    });
}

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();