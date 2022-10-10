using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadStreamMusic.Data.Music
{
  public class MusicDbContext : DbContext
  {
    public DbSet<MusicDbModel> Music { set; get; }

    public MusicDbContext(DbContextOptions options) : base(options)
    {

    }
    public class Factory : IDesignTimeDbContextFactory<MusicDbContext>
    {
      public MusicDbContext CreateDbContext(string[] args)
      {
        var options = new DbContextOptionsBuilder()
          .UseNpgsql("Host=localhost;Port=5432;Database=musicService;Username=postgres;Password=12345")
          .Options;
        return new MusicDbContext(options);
      }
    }

  }
}
