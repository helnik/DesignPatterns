using System;

namespace DesignPatterns.GoF.Structural.Flyweight
{
    /// <summary>
    /// abstract flyweight class
    /// </summary>
    public abstract class Episode
    {
        protected string ShowName;
        protected string EpisodeTitle;
        protected string Duration;        

        public abstract void Play();
    }

    /// <summary>
    /// concrete flyweight 1
    /// </summary>
    public class FunnyEpisode : Episode
    {
        public FunnyEpisode()
        {
            ShowName = "Doctor Who";
            EpisodeTitle = "Funniest episode of the series";
            Duration = "45";             

            Console.WriteLine("Filmed funny episode");
        }

        public override void Play()
        {
            Console.WriteLine($"Playing: {ShowName} episode {EpisodeTitle} for the next {Duration}min");
        }
    }

    /// <summary>
    /// concrete flyweight 2
    /// </summary>
    public class SadEpisode : Episode
    {
        public SadEpisode()
        {
            ShowName = "House M.D.";
            EpisodeTitle = "Sadest episode of the series";
            Duration = "60";             

            Console.WriteLine("Filmed sad episode");
        }

        public override void Play()
        {
            Console.WriteLine($"Playing: {ShowName} episode {EpisodeTitle} for the next {Duration}min");
        }
    }
}
