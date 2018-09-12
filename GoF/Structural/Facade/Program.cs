using System;

namespace DesignPatterns.GoF.Structural.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var producer = new EpisodeProducer("Nick");
            Console.WriteLine($"Hello board of stake holders I am producer {producer.Name}");
            Console.WriteLine("What is episode's desired duration");
            var duration = Console.ReadLine();
            Console.WriteLine("What is episode's ost name");
            var ost = Console.ReadLine();
            Console.WriteLine("What is episode's special effect");
            var se = Console.ReadLine();

            //yay facade
            var ep = producer.GetEpisode(duration, ost, se);
            ep.Play();

            Console.ReadKey();
        }
    }
}
