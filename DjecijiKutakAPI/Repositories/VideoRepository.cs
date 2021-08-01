using DjecijiKutakAPI.Data;
using DjecijiKutakAPI.Entities;
using DjecijiKutakAPI.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Repositories
{
    public class VideoRepository : IVideoRepository
    {
        private readonly StoreContext _dbContext;
        public VideoRepository(StoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<VideoViewModel> AddVideo(VideoViewModel video,  CancellationToken cancellationToken = default)
        {
            var newVideo = new Video
            {
                YoutubeID = video.YoutubeID,
                Title = video.Title,
                IsFree = video.IsFree
            };
            await _dbContext.Videos.AddAsync(newVideo, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return new VideoViewModel(newVideo);
        }

        public async Task<List<VideoViewModel>> GetVideos(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Videos.Select(x => new VideoViewModel(x)).ToListAsync(cancellationToken);
        }
    }
}
