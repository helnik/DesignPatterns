using System;

namespace DesignPatterns.Other.Creational.DependencyInjection
{
    /// <summary>
    /// abstract serice, will be used for constructor injection
    /// </summary>
    public interface ITvEpisode
    {
        void Play();
    }

    /// <summary>
    /// concrete implementation
    /// </summary>
    public class CommunityEpisode : ITvEpisode
    {
        public void Play()
        {
            Console.WriteLine("Playing newest Community episode");
        }
    }

    /// <summary>
    /// concrete implementation
    /// </summary>
    public class DexterEpisode : ITvEpisode
    {
        public void Play()
        {
            Console.WriteLine("Playing newest Dexter episode");
        }
    }
}
