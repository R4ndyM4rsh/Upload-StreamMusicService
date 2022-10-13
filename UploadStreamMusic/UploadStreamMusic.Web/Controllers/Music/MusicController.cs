using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UpladStreamMusic.Core.Domains.Music.Services;

namespace UploadStreamMusic.Web.Controllers.Music
{
  [ApiController]
  [Route("[controller]")]
  public class MusicController
  {

    private readonly IMusicService _musicService;

    public MusicController(IMusicService musicService)
    {
      _musicService = musicService;
    }

    [HttpPost]
    public async Task UpdloadMusic(UpladStreamMusic.Core.Domains.Music.Music music) 
    {
      await _musicService.Upload(music);
    }
  }
}
