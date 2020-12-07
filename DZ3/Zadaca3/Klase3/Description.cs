using System;

namespace Klase3
{
    public class Description
    {
        private int number;
        public TimeSpan time;
        private string name;

        public Description(int number, double time, string name)
        {
            this.number = number;
            this.time = TimeSpan.FromMinutes(time);
            this.name = name;
        }

        public override string ToString()
        {
            return $"{number},{time},{name}";
        }
    }
}
