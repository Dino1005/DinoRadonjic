using System;
using System.Globalization;

namespace Klase2
{
    public class TvUtilities
    {
        private static double GenerateRandomScore()
        {
            Random ran = new Random();
            return ran.NextDouble() * 10;
        }

        public static void Sort(Episode[] episodes)
        {
            Array.Sort(episodes, delegate (Episode ep1, Episode ep2) {
                return ep2.GetAverageScore().CompareTo(ep1.GetAverageScore());
            });
        }

        public static Episode Parse(string episodesInputs)
        {
            string[] inputs = episodesInputs.Split(',');
            Description description = new Description(Int32.Parse(inputs[3]), TimeSpan.Parse(inputs[4]), inputs[5]);
            return new Episode(Int32.Parse(inputs[0]), double.Parse(inputs[1], CultureInfo.GetCultureInfo("en-US")), double.Parse(inputs[2], CultureInfo.GetCultureInfo("us-HR")), description); ;
        }

     
    }
}
