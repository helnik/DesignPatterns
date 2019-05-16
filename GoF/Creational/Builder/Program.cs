using System;

namespace DesignPatterns.GoF.Creational.Builder
{
    class Program
    {

        static void printUsage()
        {
            Console.WriteLine("This is an implementation of the Builder pattern");
            Console.WriteLine("Please sit down and relax");
        }

        static void Main(string[] args)
        {
            printUsage();
            //director
            var produder = new EpisodeProducer();
            EpisodeBuilder builder;

            //do some fireflies episodes
            builder = new FireflyBuilder();
            produder.AssembleEpisodeParts(builder, "Serenity");
            Console.WriteLine(builder.Episode.ToString());
            produder.AssembleEpisodeParts(builder, "The Train Job");
            Console.WriteLine(builder.Episode.ToString());

            //do some doctor who
            builder = new DoctorWhoBuilder();
            produder.AssembleEpisodeParts(builder, "The Name of the Doctor");
            Console.WriteLine(builder.Episode.ToString());
            produder.AssembleEpisodeParts(builder, "The Day of the Doctor");
            Console.WriteLine(builder.Episode.ToString());
            produder.AssembleEpisodeParts(builder, "The Time of the Doctor");
            Console.WriteLine(builder.Episode.ToString());
            Console.ReadKey();
        }
    }
}
