using System.Collections.Generic;

namespace DjecijiKutakAPI.Entities
{
    public class Video : BaseEntity
    {
        public string Title { get; set; }
        public string YoutubeID { get; set; }
        public string IframeUrl { get; set; }
        public bool IsFree { get; set; }
        public IList<Favorite> Favorites { get; set; }
    }
}
