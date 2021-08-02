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
       public async Task<IActionResult> GetVideos()
        {
            var videos = await _videoRepository.GetVideos();
            return Ok(videos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var video = await _videoRepository.GetVideoById(id);
            return Ok(video);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] VideoViewModel video)
        {
            await _videoRepository.AddVideo(video);
            return Ok();
        }
       

        [HttpGet("{searchTerm}")]
        public async Task<IActionResult> Search(string searchTerm)
        {
            var videos = await _videoRepository.Search(searchTerm);
            return Ok(videos);
        }
    }
}
