using System;

namespace DesignPatterns.GoF.Structural.Facade
{
    /// <summary>
    /// Facade
    /// </summary>
    public class EpisodeProducer
    {
        public readonly string Name;
        private FilmStudio filmStudio;
        private AudioStudio audioStudio;
        private SpecialEffectStudio specialEffectStudio;        

        public EpisodeProducer(string name)
        {
            Name = name;
            filmStudio = new FilmStudio();
            audioStudio = new AudioStudio();
            specialEffectStudio = new SpecialEffectStudio();
        }

        public Episode GetEpisode(string videoDuration, string ostName, string SpecialEffectType)
        {
            Console.WriteLine("Producer asks for an episode");
            Episode ep = new Episode();
            Console.WriteLine("Producer asks for episodes duration");
            ep.Video = filmStudio.Film(videoDuration);
            Console.WriteLine("Producer asks for ost");
            ep.Audio = audioStudio.Record(ostName);
            Console.WriteLine("Producer asks for special effects");
            ep.SpecialEffect = specialEffectStudio.Specialize(SpecialEffectType);

            return ep;
        }
    }
}
