using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegacyCodeWeCannotRefactor;

namespace DesignPatterns.GoF.Structural.Adapter
{
    /// <summary>
    /// The Adapter
    /// Implements ITvShow and
    /// Hold a reference to the adaptee to 
    /// Do work and fill data
    /// </summary>
    public class TvShowApiAdapter : ITvShow
    {
        private AncientTvShowGuideAPI ancientTvShowGuideApi;
        public string Title { get; }
        public string Critics { get; set; }
        public string OriginalAirDate { get; set; }
        public string Rating { get; set; }

        public TvShowApiAdapter(string showTitle)
        {
            Title = showTitle;
        }

        public void DisplayShowInfo()
        {
            ancientTvShowGuideApi = new AncientTvShowGuideAPI();
            Critics = ancientTvShowGuideApi.GetCritics(Title);
            OriginalAirDate = ancientTvShowGuideApi.GetFirstAirDate(Title);
            Rating = ancientTvShowGuideApi.GetRatings(Title);

            Console.WriteLine($"Show {Title} first aired at {OriginalAirDate}. Critics say it is {Critics} and has a rating of {Rating} stars in IMDB");
        }
    }
}
