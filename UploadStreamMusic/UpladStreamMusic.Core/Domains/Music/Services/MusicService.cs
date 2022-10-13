using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpladStreamMusic.Core.Domains.Music.Repositories;

namespace UpladStreamMusic.Core.Domains.Music.Services
{
  public class MusicService : IMusicService
  {
    private readonly IMusicRepository _musicRepository;
    public MusicService(IMusicRepository musicRepository) 
    {
      _musicRepository = musicRepository;
    }
    public async Task Stream(string id)
    {
      await _musicRepository.Stream(id);
    }

    public async Task Upload(Music music)
    {
      if (music == null) 
      {
        throw new Exception("Файл отсутствует");
      }
      await _musicRepository.Upload(music);
    }
  }
}
