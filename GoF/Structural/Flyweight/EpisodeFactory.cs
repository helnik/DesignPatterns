using System;
using System.Collections.Generic;

namespace DesignPatterns.GoF.Structural.Flyweight
{
    /// <summary>
    /// Flyweight factory
    /// </summary>
    public class EpisodeFactory
    {
        private Dictionary<char, Episode> episodessDictionary = new Dictionary<char, Episode>();

        public Episode GetEpisode(char choise)
        {
            Episode ep = null;
            if (episodessDictionary.TryGetValue(choise, out ep))
            {
                return ep;
            }
            else
            {
                switch (choise)
                {
                    case ('F'):
                        ep = new FunnyEpisode();
                        break;
                    case ('S'):
                        ep = new SadEpisode();
                        break;
                    default:
                        throw new NotImplementedException("There is not an indicative episode for this feeling");
                }
                episodessDictionary.Add(choise, ep);
                return ep;
            }
        }
    }
}
