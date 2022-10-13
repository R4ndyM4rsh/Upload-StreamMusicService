using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpladStreamMusic.Core.Domains.Music.Repositories;
using UpladStreamMusic.Core.Domains.Music;
using Microsoft.EntityFrameworkCore;

namespace UploadStreamMusic.Data.Music.Repositories
{
  public class MusicRepository : IMusicRepository
  {
    private readonly MusicDbContext _context;
    public MusicRepository(MusicDbContext context) 
    {
      _context = context;
    }
    
    public async Task Stream(string id)
    {
      var entity = await _context.Music
        .AsNoTracking()
        .FirstOrDefaultAsync(it => it.Id == id);
      if (entity == null) 
      {
        await Task.CompletedTask;
      }
      await Task.CompletedTask;
    }

    public async Task Upload(UpladStreamMusic.Core.Domains.Music.Music music)
    {
      var entity = new MusicDbModel
      {
        Id = music.id,
        Name = music.name,
        Author = music.author,
        Image = music.image,
        Path = music.path
      };
      await _context.AddAsync(entity);
      await _context.SaveChangesAsync();
    }
  }
}
