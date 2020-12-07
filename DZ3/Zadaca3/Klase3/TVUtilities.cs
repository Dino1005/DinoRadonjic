using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.IO;

namespace Klase3
{
    public static class TvUtilities
    {
        public static double GenerateRandomScore()
        {
            Random ran = new Random();
            return Math.Round(ran.NextDouble() * 10, 2);
        }

        public static void Sort(Episode[] episodes)
        {
            Array.Sort(episodes, delegate (Episode ep1, Episode ep2)
            {
                return ep2.GetAverageScore().CompareTo(ep1.GetAverageScore());
            });
        }

        public static Episode Parse(string episodesInputs)
        {
            string[] inputs = episodesInputs.Split(',');
            Description description = new Description(Int32.Parse(inputs[3]), Double.Parse(inputs[4]), inputs[5]);
            return new Episode(Int32.Parse(inputs[0]), double.Parse(inputs[1], CultureInfo.GetCultureInfo("en-US")), double.Parse(inputs[2], CultureInfo.GetCultureInfo("us-HR")), description); ;
        }

        public static Episode[] LoadEpisodesFromFile(string fileName)
        {
            string[] episodesInputs = File.ReadAllLines(fileName);
            Episode[] episodes = new Episode[episodesInputs.Length];
            for (int i = 0; i < episodes.Length; i++)
            {
                episodes[i] = TvUtilities.Parse(episodesInputs[i]);
            }
            return episodes;
        }



    }
}
