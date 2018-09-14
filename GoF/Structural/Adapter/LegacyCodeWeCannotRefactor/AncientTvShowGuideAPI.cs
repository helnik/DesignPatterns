namespace LegacyCodeWeCannotRefactor
{
    /// <summary>
    /// The Adaptee
    /// Legacy code we cannot modify
    /// Instead of returning an object with properties it returns method results
    /// </summary>
    public class AncientTvShowGuideAPI
    {
        public string GetCritics(string title)
        {
            switch (title.ToUpper())
            {
                case ("DOCTOR WHO"):
                    return "The most epic show of all times";
                case ("FIREFLY"):
                    return "Must watch";
                case ("Battlestar Galactica"):
                    return ("Dr. Gaius Baltar is a God");
                default:
                    return "No comments";
            }
        }

        public string GetFirstAirDate(string title)
        {
            switch (title.ToUpper())
            {
                case ("DOCTOR WHO"):
                    return "23 November 1963"; //yeah longest sci-fi show ever!
                case ("FIREFLY"):
                    return "20 December 2002";
                case ("Battlestar Galactica"):
                    return ("Dr. Gaius Baltar is a God");
                default:
                    return "8 December 2003";
            }
        }

        public string GetRatings(string title)
        {
            switch (title.ToUpper())
            {
                case ("DOCTOR WHO"):
                    return "8,7"; //yeah longest sci-fi show ever!
                case ("FIREFLY"):
                    return "9";
                case ("Battlestar Galactica"):
                    return ("8,7");
                default:
                    return "~";
            }
        }
    }
}
