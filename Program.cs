using TelephoneDirectory.Data;
using TelephoneDirectory.Data.Interfaces;
using TelephoneDirectory.Data.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
builder.Services.AddTransient<ICity, CityRepository>();
builder.Services.AddTransient<IPerson, PersonRepository>();

var app = builder.Build();

app.UseExceptionHandler("/Error");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

using(var scope = app.Services.CreateScope())
{
    ApplicationDbContext content = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>()!;

    DbObjects.Initial(content);
}

app.Run();