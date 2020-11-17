using System;

namespace Klase2
{
    public class Episode
    {
        private int vcount;
        private double tscore;
        private double mscore;
        private readonly Description description;

        public int GetViewerCount() { return vcount; }
        public double GetMaxScore() { return mscore; }


        public Episode(int vcount, double tscore, double mscore, Description description)
        {
            this.vcount = vcount;
            this.tscore = tscore;
            this.mscore = mscore;
            this.description = description;
        }

        public double GetAverageScore() { return tscore / (double)vcount; }

        public void AddView(double score)
        {
            vcount++;
            tscore += score;
            if (mscore < score)
                mscore = score;
        }

        public override string ToString()
        {
            return $"{vcount},{tscore},{mscore},{description}";
        }
    }
}
