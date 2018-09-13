using System;

namespace DesignPatterns.GoF.Creational.AbstractFactory
{
    /// <summary>
    /// Abstract show
    /// </summary>
    public interface IPrimeTime
    {
        void Show();
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class MensPrimeTime : IPrimeTime
    {        

        public void Show()
        {
            Console.WriteLine("Showing: Football");
        }
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class WomensPrimeTime : IPrimeTime
    {

        public void Show()
        {
            Console.WriteLine("Showing: Sex and the city");
        }
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class KidShow : IPrimeTime
    {

        public void Show()
        {
            Console.WriteLine("Showing: Dragonball");
        }
    }
}
