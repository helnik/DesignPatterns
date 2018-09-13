using System;
using System.Collections.Generic;

namespace DesignPatterns.GoF.Creational.AbstractFactory
{
    class Program
    {
        private static Dictionary<string, ITvProgrammFactory> channelsRepository = new Dictionary<string, ITvProgrammFactory>()
        {
            {"M", new MensTvFactory() },
            {"W", new WomensTvFactory()},
            {"K", new KidsTvFactory()}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Choose between (M)en's, (W)omen's or (K)id's channel");
            string seletion = Console.ReadKey().KeyChar.ToString().ToUpper();
            if (channelsRepository.TryGetValue(seletion, out ITvProgrammFactory factory))
            {
                WatchTv(factory);
            }
            else
            {
                throw new NotImplementedException("This channel is closed by ESR");
            }
            Console.ReadKey();
        }

        private static void WatchTv(ITvProgrammFactory factory)
        {
            Console.WriteLine();
            var morning = factory.GetMorningTime();
            var primeTime = factory.GetPrimeTime();
            morning.ShowMorningStuff();
            primeTime.Show();
        }

    }
}
