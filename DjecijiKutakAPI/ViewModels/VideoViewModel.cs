using DjecijiKutakAPI.Entities;
namespace DjecijiKutakAPI.ViewModels
{
    public class VideoViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string YoutubeID { get; set; }
        public string IframeUrl { get; set; }
        public bool IsFree { get; set; }
        public VideoViewModel()
        {

        }
        public VideoViewModel(Video video)
        {
            Id = video.Id;
            Title = video.Title;
            YoutubeID = video.YoutubeID;
            IsFree = video.IsFree;
            IframeUrl = video.IframeUrl;
        }
    }
}
