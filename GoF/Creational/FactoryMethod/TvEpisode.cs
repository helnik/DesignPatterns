using System;
using System.Collections.Generic;

namespace DesignPatterns.GoF.Creational.FactoryMethod
{
    /// <summary>
    /// abstract Product class
    /// </summary>
    public abstract class TvEpisode
    {
        protected List<EpisodeComponent> episodeComponents;
        protected string episodeTitle;
        public TvEpisode(List<EpisodeComponent> components, string title)
        {
            episodeComponents = components;
            episodeTitle = title;
        }
        public abstract void Play();
        public override string ToString()
        {
            string participants =  string.Empty;
            foreach (var ec in episodeComponents)
            {
                participants += $"{ec.CreditName}, ";
            }
            participants = participants.Remove(participants.LastIndexOf(','));
            return $"Title: {episodeTitle}. Credits: {participants}";
        }
    }

    /// <summary>
    /// Concrete Product implementation 1
    /// </summary>
    public class WestWorldEpisode : TvEpisode
    {
        public WestWorldEpisode(List<EpisodeComponent> components, string title) : base(components, title) { }        

        public override void Play()
        {
            Console.WriteLine($"Showing all new WestWorld episode! \n{base.ToString()}\n");
        }
    }

    /// <summary>
    /// Concrete Product implementation 2
    /// </summary>
    public class FlashEpisode : TvEpisode
    {
        public FlashEpisode(List<EpisodeComponent> components, string title) : base(components, title) { }
        
        public override void Play()
        {
            Console.WriteLine($"Showing all new The Flash episode! \n{base.ToString()}\n");
        }
    }
}
