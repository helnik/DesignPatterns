using System;

namespace DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// Abstract prototype
    /// </summary>
    public interface ITvShowPrototype
    {
        //choose either swallow or deep
        //if object has reference type, changes to that type will change original object also
        ITvShowPrototype SwallowClone();
        
        ITvShowPrototype DeepClone();
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class PopularTvShow : ITvShowPrototype
    {
        private string genre;
        private string title;
        private string durationInMinutes;
        private Additional additional;

        public PopularTvShow(string showGenre, string showTitle, string durationInMin, string summary, bool isPrimeTime)
        {
            genre = showGenre;
            title = showTitle;
            durationInMinutes = durationInMin;
            additional = new Additional
            {
                IsPrimeTime = isPrimeTime,
                Summary = string.IsNullOrEmpty(summary) ? "A good show" : summary
            };
        }

        public ITvShowPrototype SwallowClone()
        {
            Console.WriteLine($"Showing on repeat: {this.ToString()}");
            return (PopularTvShow) MemberwiseClone();
        }

        public ITvShowPrototype DeepClone()
        {
            Console.WriteLine($"Showing on repeat (deep): {this.ToString()}");
            return new PopularTvShow(this.genre, this.title, this.durationInMinutes, this.additional.Summary, this.additional.IsPrimeTime);
        }

        public void ChangeAdditionalInfo(string summary, bool isPrimeTime)
        {
            additional.IsPrimeTime = isPrimeTime;
            additional.Summary = summary;
        }

        public override string ToString()
        {
            return $@"Show: {this.title}, Genre: {this.genre}, Duration: {this.durationInMinutes}min. Additional Info:
                      Summary:{additional.Summary}, PrimeTime: {additional.IsPrimeTime}";
        }
    }
}
