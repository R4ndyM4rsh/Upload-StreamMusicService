using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpladStreamMusic.Core.Domains.Music.Repositories;

namespace UploadStreamMusic.Data.Music.Repositories
{
  public class MusicRepository : IMusicRepository
  {
    public Task Stream(string id)
    {
      throw new NotImplementedException();
    }

    public Task Upload(UpladStreamMusic.Core.Domains.Music.Music music)
    {
      throw new NotImplementedException();
    }
  }
}
