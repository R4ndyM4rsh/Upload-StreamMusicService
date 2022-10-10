using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpladStreamMusic.Core.Domains.Music.Repositories
{
  public interface IMusicRepository
  {
    public Task Upload(Music music);
    public Task Stream(string id);
  }
}
