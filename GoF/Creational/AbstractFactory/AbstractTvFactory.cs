namespace DesignPatterns.GoF.Creational.AbstractFactory
{
    /// <summary>
    /// Abstract Factory. Define methods to create the objects
    /// </summary>
    public abstract class AbstractTvFactory
    {
        public abstract MorningTime GetMorningTime();
        public abstract PrimeTime GetPrimeTime();
    }

    /// <summary>
    /// Concrete Factory. Creates concrete objects
    /// </summary>
    public class MensTvFactory : AbstractTvFactory
    {
        public override MorningTime GetMorningTime()
        {
            return new MensMorning();
        }
        public override PrimeTime GetPrimeTime()
        {
            return new MensPrimeTime();
        }
    }

    /// <summary>
    /// Concrete Factory. Creates concrete objects
    /// </summary>
    public class WomensTvFactory : AbstractTvFactory
    {
        public override MorningTime GetMorningTime()
        {
            return new WomensMorning();
        }
        public override PrimeTime GetPrimeTime()
        {
            return new WomensPrimeTime();
        }
    }

    /// <summary>
    /// Concrete Factory. Creates concrete objects
    /// </summary>
    public class KidsTvFactory : AbstractTvFactory
    {
        public override MorningTime GetMorningTime()
        {
            return new KidsMorning();
        }
        public override PrimeTime GetPrimeTime()
        {
            return new KidShow();
        }
    }
}
