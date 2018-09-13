using System;
using System.Collections.Concurrent;

namespace DesignPatterns.Other.Creational.Multiton
{
    public sealed class EpisodeMultiton
    {
        private static  readonly ConcurrentDictionary<string, Lazy<FavoriteEpisode>> episodeInstances = new ConcurrentDictionary<string, Lazy<FavoriteEpisode>>();

        private EpisodeMultiton() { }

        public static FavoriteEpisode GetTvInstance(string key)
        {
            Lazy<FavoriteEpisode> instance = episodeInstances.GetOrAdd(key, k => new Lazy<FavoriteEpisode>(() => new FavoriteEpisode(k)));
            return instance.Value;
        }
    }
    
    /// <summary>
    /// Generic Implementation
    /// https://stackoverflow.com/questions/16716181/is-this-a-lazy-thread-safe-generic-multiton 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class Multiton<T> where T : class, new()
    {
        private static readonly ConcurrentDictionary<object, Lazy<T>> _instances = new ConcurrentDictionary<object, Lazy<T>>();

        public static T GetInstance(object key)
        {
            Lazy<T> instance = _instances.GetOrAdd(key, k => new Lazy<T>(() => new T()));
            return instance.Value;
        }

        private Multiton()
        {
        }
    }
}
