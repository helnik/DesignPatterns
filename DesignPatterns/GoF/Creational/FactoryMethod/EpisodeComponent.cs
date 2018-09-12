namespace DesignPatterns.GoF.Creational.FactoryMethod
{
    public abstract class EpisodeComponent
    {
        public string CreditName { get; set; }
    }

    public class SpecialEffect : EpisodeComponent { }
    public class Scriptwriter : EpisodeComponent { }
    public class Cascadeur : EpisodeComponent { }
    public class Actor : EpisodeComponent { }
    public class CameraMan : EpisodeComponent { }    
}
