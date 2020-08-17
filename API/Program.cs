using System;
using Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = CreateHostBuilder(args).Build();

      /* START  Create DB if not exist, always check when we start app*/
      using(var scope = host.Services.CreateScope())
      {
        var services = scope.ServiceProvider;
        try
        {
          var context = services.GetRequiredService<DataContext>();
          var userManager = services.GetRequiredService<UserManager<AppUser>>();
          context.Database.Migrate();
          Seed.SeedData(context, userManager).Wait();
        }
        catch (Exception ex)
        {
          var logger = services.GetRequiredService<ILogger<Program>>();
          logger.LogError(ex, "An error occured during migration");
        }
      }
      /* END  Create DB if not exist, always check when we start app*/

      host.Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
      Host.CreateDefaultBuilder(args)
      .ConfigureWebHostDefaults(webBuilder =>
      {
        webBuilder.UseKestrel(x => x.AddServerHeader = false);
        webBuilder.UseStartup<Startup>();
      });
  }
}