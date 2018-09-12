namespace DesignPatterns.GoF.Structural.Facade
{
    /// <summary>
    /// sub system 1
    /// </summary>
    public class FilmStudio
    {
        public Video Film(string duration)
        {
            return new Video
            {
                Duration = duration
            };
        }
    }

    /// <summary>
    /// sub system 2
    /// </summary>
    public class AudioStudio
    {
        public Audio Record(string ostName)
        {
            return new Audio
            {
                Ost = ostName
            };
        }
    }

    /// <summary>
    /// sub system 3
    /// </summary>
    public class SpecialEffectStudio
    {
        public SpecialEffect Specialize(string type)
        {
            return new SpecialEffect
            {
                Type = type
            };
        }
    }
}
