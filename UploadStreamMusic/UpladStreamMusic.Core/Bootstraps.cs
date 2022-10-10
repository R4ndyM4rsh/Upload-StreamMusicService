using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpladStreamMusic.Core.Domains.Music.Services;

namespace UpladStreamMusic.Core
{
  public static class Bootstraps
  {
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
      services.AddScoped<IMusicService, MusicService>();
      return services;
    }
  }
}
