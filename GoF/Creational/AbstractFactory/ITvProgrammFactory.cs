namespace DesignPatterns.GoF.Creational.AbstractFactory
{
    /// <summary>
    /// Abstract Factory. Define methods to create the objects
    /// </summary>
    public interface ITvProgrammFactory
    {
        IMorningTime GetMorningTime();
        IPrimeTime GetPrimeTime();
    }

    /// <summary>
    /// Concrete Factory. Creates concrete objects
    /// </summary>
    public class MensTvFactory : ITvProgrammFactory
    {
        public IMorningTime GetMorningTime()
        {
            return new MensMorning();
        }
        public IPrimeTime GetPrimeTime()
        {
            return new MensPrimeTime();
        }
    }

    /// <summary>
    /// Concrete Factory. Creates concrete objects
    /// </summary>
    public class WomensTvFactory : ITvProgrammFactory
    {
        public IMorningTime GetMorningTime()
        {
            return new WomensMorning();
        }
        public IPrimeTime GetPrimeTime()
        {
            return new WomensPrimeTime();
        }
    }

    /// <summary>
    /// Concrete Factory. Creates concrete objects
    /// </summary>
    public class KidsTvFactory : ITvProgrammFactory
    {
        public IMorningTime GetMorningTime()
        {
            return new KidsMorning();
        }
        public IPrimeTime GetPrimeTime()
        {
            return new KidShow();
        }
    }
}
