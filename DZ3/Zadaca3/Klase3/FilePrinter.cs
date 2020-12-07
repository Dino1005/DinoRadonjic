using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Klase3
{
    public class FilePrinter : IPrinter
    {
        public string FileName { get; private set; }

        public FilePrinter(string fileName)
        {
            FileName = fileName;
        }
        public void Print(string season)
        {
            File.WriteAllText(FileName, season);
        }
    }
}
