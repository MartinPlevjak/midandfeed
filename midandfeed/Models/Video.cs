using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace midandfeed.Models
{
    public class Video
    {
        public int ID { get; set; }
        [Display(Name = "Názov videa")]
        public string VideoName { get; set; }
        [Display(Name = "Zadaj adresu videa")]
        public string Url { get; set; }
        public string YouTubeVideoId
        {
            get
            {
                var youtubeMatch =
                    new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)")
                    .Match(this.Url);
                return youtubeMatch.Success ? youtubeMatch.Groups[1].Value : string.Empty;
            }
        }

    }
}