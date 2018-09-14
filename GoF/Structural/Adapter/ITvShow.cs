using System;

namespace DesignPatterns.GoF.Structural.Adapter
{
    /// <summary>
    /// The target
    /// </summary>
    public interface ITvShow
    {
        string Title { get; }
        string Critics { get; set; }
        string OriginalAirDate { get; set; }
        string Rating { get; set; }
        void DisplayShowInfo();
    }

    public class TvShow : ITvShow
    {
        public string Title { get; }
        public string Critics { get; set; }
        public string OriginalAirDate { get; set; }
        public string Rating { get; set; }

        public TvShow(string title)
        {
            Title = title;
        }

        public void DisplayShowInfo()
        {
            Console.WriteLine("No Info");
        }
    }
}
