using DjecijiKutakAPI.Entities;
using DjecijiKutakAPI.Repositories;
using DjecijiKutakAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private readonly IVideoRepository _videoRepository;

        public VideoController(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }

       [HttpGet]
       public async Task<List<VideoViewModel>> GetVideos()
        {
            return await _videoRepository.GetVideos();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] VideoViewModel video)
        {
            await _videoRepository.AddVideo(video);
            return Ok();
        }

        [HttpGet("{id}")]
        public string GetVideo(int id)
        {
            return "product";
        }
    }
}
