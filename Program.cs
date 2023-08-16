using TelephoneDirectory.Data;
using TelephoneDirectory.Data.Interfaces;
using TelephoneDirectory.Data.Repository;
using Microsoft.EntityFrameworkCore;
using TelephoneDirectory.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddMvc(options => {
    options.EnableEndpointRouting = false;
    options.Filters.Add(typeof(ExceptionFilterAttribute));
    });
builder.Services.AddTransient<IPerson, PersonRepository>();


var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseMvc(routes => {
    routes.MapRoute(name: "default", template: "{controller=Home}/{action=Search}/{id?}");
});

using(var scope = app.Services.CreateScope())
{
    ApplicationDbContext content = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>()!;

    DbObjects.Initial(content);
}

app.Run();