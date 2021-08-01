using DjecijiKutakAPI.Entities;
namespace DjecijiKutakAPI.ViewModels
{
    public class VideoViewModel
    {
        public string Title { get; set; }
        public string YoutubeID { get; set; }
        public string IframeUrl { get; set; }
        public bool IsFree { get; set; }
        public VideoViewModel()
        {

        }
        public VideoViewModel(Video video)
        {
            Title = video.Title;
            YoutubeID = video.YoutubeID;
            IsFree = video.IsFree;
        }
    }
}
