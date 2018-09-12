namespace DesignPatterns.GoF.Creational.Builder
{
    /// <summary>
    /// Director
    /// </summary>
    public class EpisodeProducer
    {
        public void AssembleEpisodeParts(EpisodeBuilder builder, string title)
        {
            builder.FilmVideo();
            builder.RecordAudio();
            builder.ProduceSpecialEffect();
            builder.AddTitle(title);
        }
    }
}
