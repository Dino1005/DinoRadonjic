using System;

namespace Klase2
{
    public class Description
    {
        private int number;
        private TimeSpan time;
        private string name;

        public Description(int number, TimeSpan time, string name)
        {
            this.number = number;
            this.time = time;
            this.name = name;
        }

        public override string ToString()
        {
            return $"{number},{time},{name}";
        }
    }
}
