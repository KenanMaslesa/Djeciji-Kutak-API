using DjecijiKutakAPI.Entities;
using DjecijiKutakAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Repositories
{
    public interface IVideoRepository
    {
        Task<List<VideoViewModel>> GetVideos(CancellationToken cancellationToken = default);
        Task<VideoViewModel> AddVideo(VideoViewModel video, CancellationToken cancellationToken = default);
    }
}
