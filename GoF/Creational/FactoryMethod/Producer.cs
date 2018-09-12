using System.Collections.Generic;

namespace DesignPatterns.GoF.Creational.FactoryMethod
{
    /// <summary>
    /// abstract Creator class = Episode Factory
    /// </summary>
    public abstract class Producer
    {
        private List<EpisodeComponent> episodeComponents = new List<EpisodeComponent>();
        public List<EpisodeComponent> EpisodeComponents { get { return episodeComponents; } }

        public Producer()
        {
            AddEpisodeComponents();
        }
        
        protected abstract void AddEpisodeComponents();

        /// <summary>
        /// Factory Method
        /// </summary>
        public abstract TvEpisode ProdudeEpisode(string title);
    }

    /// <summary>
    /// concrete Creator Implementation 1
    /// </summary>
    public class WestWorldProducer : Producer
    {  
        protected override void AddEpisodeComponents()
        {
            EpisodeComponents.Add(new Scriptwriter { CreditName = "John Nolan"});
            EpisodeComponents.Add(new Actor { CreditName = "Evan Rachel Wood"});
            EpisodeComponents.Add(new Actor { CreditName = "Ed Harris"});
            EpisodeComponents.Add(new Actor { CreditName = "Jeffrey Wright"});
            EpisodeComponents.Add(new CameraMan{ CreditName = "John Doe"});
        }
        public override TvEpisode ProdudeEpisode(string title)
        {
            return new WestWorldEpisode(EpisodeComponents, title);
        }
    }

    /// <summary>
    /// concrete Creator Implementation 2
    /// </summary>
    public class FlashProducer : Producer
    {   
        protected override void AddEpisodeComponents()
        {
            EpisodeComponents.Add(new Scriptwriter { CreditName = "A clever man"});
            EpisodeComponents.Add(new Actor { CreditName = "Grant Gustin"});
            EpisodeComponents.Add(new Actor { CreditName = "Tom Cavanagh"});
            EpisodeComponents.Add(new SpecialEffect { CreditName = "Stan Lee"});
            EpisodeComponents.Add(new CameraMan { CreditName = "Joahana Doe"});
            EpisodeComponents.Add(new Cascadeur { CreditName = "Flexible Guy"});
        }
        public override TvEpisode ProdudeEpisode(string title)
        {
            return new FlashEpisode(EpisodeComponents, title);
        }
    }
}
