using System;
using System.Collections.Generic;

namespace DesignPatterns.GoF.Creational.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Producer p1 = new WestWorldProducer();
            Producer p2 = new FlashProducer();

            var episodePlayList = new List<TvEpisode>
            {
                p1.ProdudeEpisode("Weird Timeline"),
                p1.ProdudeEpisode("Another Timeline"),
                p1.ProdudeEpisode("You Dont Get Anything At This Point")
            };
            PlayAllEpisodes(episodePlayList);
                        
            episodePlayList.Add(p2.ProdudeEpisode("Walk Barry! Walk!"));
            episodePlayList.Add(p2.ProdudeEpisode("Run Barry! Run!"));
            episodePlayList.Add(p2.ProdudeEpisode("Do a Barrel Roll Bary!"));
            PlayAllEpisodes(episodePlayList);

            Console.ReadKey();
        }

        private static void PlayAllEpisodes(List<TvEpisode> episodePlayList)
        {
            foreach(var ep in episodePlayList)
            {
                ep.Play();                
            }
            episodePlayList.Clear();
        }
    }
}
