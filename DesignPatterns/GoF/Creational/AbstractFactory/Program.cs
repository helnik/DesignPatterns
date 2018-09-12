using System;
using System.Collections.Generic;

namespace DesignPatterns.GoF.Creational.AbstractFactory
{
    class Program
    {
        private static Dictionary<string, AbstractTvFactory> channelsRepository = new Dictionary<string, AbstractTvFactory>()
        {
            {"M", new MensTvFactory() },
            {"W", new WomensTvFactory()},
            {"K", new KidsTvFactory()}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Choose between (M)en's, (W)omen's or (K)id's channel");
            string seletion = Console.ReadKey().KeyChar.ToString().ToUpper();
            if (channelsRepository.TryGetValue(seletion, out AbstractTvFactory factory))
            {
                WatchTv(factory);
            }
            else
            {
                throw new NotImplementedException("This channel is closed by ESR");
            }
            Console.ReadKey();
        }

        private static void WatchTv(AbstractTvFactory factory)
        {
            Console.WriteLine();
            var morning = factory.GetMorningTime();
            var primeTime = factory.GetPrimeTime();
            morning.ShowMorningStuff();
            primeTime.Show();
        }

    }
}
