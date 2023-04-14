using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using COMP367Quiz4.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<COMP367Quiz4Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("COMP367Quiz4Context") ?? throw new InvalidOperationException("Connection string 'COMP367Quiz4Context' not found.")));


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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseAuthorization();

app.MapRazorPages();

app.Run();
