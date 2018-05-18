using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class Leerling
    {
        public string Naam { get; set; }
        public string Klas { get; set; }

        public override string ToString()
        {
            return $"{Naam} ({Klas})";
        }
    }
}
