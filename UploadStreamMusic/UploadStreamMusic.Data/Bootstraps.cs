using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpladStreamMusic.Core.Domains.Music.Repositories;
using UploadStreamMusic.Data.Music;
using UploadStreamMusic.Data.Music.Repositories;

namespace UploadStreamMusic.Data
{
  public static class Bootstraps
  {
    public static IServiceCollection AddData(this IServiceCollection services)
    {
      services.AddScoped<IMusicRepository, MusicRepository>();
      services.AddDbContext<MusicDbContext>(options => options
      .UseNpgsql(
        "Host=localhost;Port=5432;Database=musicService;Username=postgres;Password=12345"));

      return services;
    }

  }
}
