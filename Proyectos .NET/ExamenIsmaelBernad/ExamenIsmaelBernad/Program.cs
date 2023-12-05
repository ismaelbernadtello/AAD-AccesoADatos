using ExamenIsmaelBernad.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//incorporamos una linea para relacionar el interfaz IAlumnoRepositorio y la clase AlumnoRepositorio
//builder.Services.AddSingleton<IAlumnoRepositorio, AlumnoRepositorio>();
//para conectarnos a la base de datos, queremos usar 
builder.Services.AddTransient<IProvinciaRepositorio, ProvinciaRepositorioBD>();

//creamos este objeto para poder llamar en el futuro al connecttion string
IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .Build();

//metemos la base de datos al builder nuget EntityFrameworkCore.SqlServer
builder.Services.AddDbContextPool<ProvinciaDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("GeografiaDbConnection")));




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
