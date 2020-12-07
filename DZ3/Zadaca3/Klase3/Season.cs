using System;
using System.Collections.Generic;
using System.Text;

namespace Klase3
{
    public class Season
    {
        public int Number { get; private set; }
        public Episode[] episodes;

        public Season(int number, Episode[] episodes)
        {
            Number = number;
            this.episodes = episodes;
        }

        public Episode this[int index]
        {
            get { return episodes[index]; }
        }

        public int Length()
        {
            return episodes.Length;
        }

        public override string ToString()
        {
            int totalViewers=0;
            TimeSpan totalDuration;
            for (int i = 0; i < episodes.Length; i++)
            {
                totalViewers += episodes[i].GetViewerCount();
                totalDuration += episodes[i].GetTime();
            }
            return $"Season {Number}:{Environment.NewLine}=================================================" +
                $"{Environment.NewLine}{string.Join<Episode>(Environment.NewLine, episodes)}{Environment.NewLine}Report:{Environment.NewLine}" +
                $"================================================={Environment.NewLine}Total viewers: {totalViewers}" +
                $"{Environment.NewLine}Total duration: {totalDuration}{Environment.NewLine}================================================={Environment.NewLine}";
        }
    }
}
