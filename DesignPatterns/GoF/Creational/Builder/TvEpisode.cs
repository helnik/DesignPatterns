namespace DesignPatterns.GoF.Creational.Builder
{
    /// <summary>
    /// The product
    /// </summary>
    public class TvEpisode
    {
        public string ShowName { get; }
        public string Title { get; set; }
        public VideoFootage VideoFootage { get; set; } 
        public Audio Audio { get; set; }
        public SpecialEffect SpecialEffect { get; set; }

        public TvEpisode(string showName)
        {
            ShowName = showName;
        }
        public override string ToString()
        {
            return $@"Brand new episode of {ShowName} titled: {Title} with video duration of {VideoFootage.DurationInMinutes}min, music theme {Audio.OST} and tons of {SpecialEffect.ToString()} special effect";
        }
    }

    public class VideoFootage
    {
        public string DurationInMinutes { get; set; }
    }

    public class Audio
    {
        public string OST { get; set; }
    }

    public enum SpecialEffect
    {
       None = 0,
       Explosion = 1,
       Wave = 2,
       Cgi = 3
    }
}
