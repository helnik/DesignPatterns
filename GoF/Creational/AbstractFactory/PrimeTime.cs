using System;

namespace DesignPatterns.GoF.Creational.AbstractFactory
{
    /// <summary>
    /// Abstract show
    /// </summary>
    public abstract class PrimeTime
    {
        public abstract void Show();
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class MensPrimeTime : PrimeTime
    {        

        public override void Show()
        {
            Console.WriteLine("Showing: Football");
        }
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class WomensPrimeTime : PrimeTime
    {

        public override void Show()
        {
            Console.WriteLine("Showing: Sex and the city");
        }
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class KidShow : PrimeTime
    {

        public override void Show()
        {
            Console.WriteLine("Showing: Dragonball");
        }
    }
}
