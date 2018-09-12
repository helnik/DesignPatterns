namespace DesignPatterns.GoF.Creational.Builder
{
    /// <summary>
    /// abstract builder
    /// </summary>
    public abstract class EpisodeBuilder
    {
        public TvEpisode Episode { get { return episode; } }
        protected TvEpisode episode;

        public virtual void AddTitle(string title)
        {
            episode.Title = title;
        }
        public abstract void FilmVideo();
        public abstract void RecordAudio();
        public abstract void ProduceSpecialEffect();
    }

    /// <summary>
    /// concrete builder 1
    /// </summary>
    public class FireflyBuilder : EpisodeBuilder
    {
        public FireflyBuilder()
        {
            episode = new TvEpisode("Firefly");
        }

        public override void FilmVideo()
        {
            episode.VideoFootage = new VideoFootage { DurationInMinutes = "60" };
        }

        public override void ProduceSpecialEffect()
        {
            episode.SpecialEffect = SpecialEffect.Explosion;
        }

        public override void RecordAudio()
        {
            episode.Audio = new Audio { OST = "EPICK" };
        }
    }

    /// <summary>
    /// concrete builder 2
    /// </summary>
    public class DoctorWhoBuilder : EpisodeBuilder
    {
        public DoctorWhoBuilder()            
        {
            episode = new TvEpisode("Doctor Who");
        }

        public override void FilmVideo()
        {
            episode.VideoFootage = new VideoFootage { DurationInMinutes = "45" };
        }

        public override void ProduceSpecialEffect()
        {
            episode.SpecialEffect = SpecialEffect.Cgi;
        }

        public override void RecordAudio()
        {
            episode.Audio = new Audio { OST = "UBER MEGA SUPER COOL" };
        }
    }
}
