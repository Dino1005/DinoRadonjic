using System;

namespace Klase1
{
    public class Episode
    {
        private int vcount;
        private double tscore;
        private double mscore;

        public int GetViewerCount() { return vcount; }
        public double GetMaxScore() { return mscore; }

        public Episode() { }

        public Episode(int vcount, double tscore, double mscore)
        {
            this.vcount = vcount;
            this.tscore = tscore;
            this.mscore = mscore;
        }

        public double GetAverageScore() { return tscore/(double)vcount; }

        public void AddView(double score)
        {
            vcount++;
            tscore += score;
            if (mscore < score)
                mscore = score;
        }


    }
}
