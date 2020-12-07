using System;
using System.Collections.Generic;
using System.Text;

namespace Klase3
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string season)
        {
            Console.WriteLine(season);
        }
    }
}
