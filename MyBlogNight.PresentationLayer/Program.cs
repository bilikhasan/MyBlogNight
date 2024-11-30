using FluentValidation.AspNetCore;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.BusinessLayer.Concrete;
using MyBlogNight.BusinessLayer.Container;
using MyBlogNight.DataAccesLayer.Abstract;
using MyBlogNight.DataAccesLayer.Context;
using MyBlogNight.DataAccesLayer.EntityFramework;
using MyBlogNight.EntityLayer.Concrete;
using MyBlogNight.PresentationLayer.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.





builder.Services.AddDbContext<BlogContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<BlogContext>().AddErrorDescriber<CustomIdentityErrorValidator>();



builder.Services.ContainerDependencies();




builder.Services.AddControllersWithViews().AddFluentValidation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.UseAuthentication();     /*Sonradan eklendi.*/    //�nce login olmal� 


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");






app.UseEndpoints(endpoints =>                               /*Buras� sonradan eklend�. Area oldugu bell� olsun d�ye.*/
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});






app.Run();
