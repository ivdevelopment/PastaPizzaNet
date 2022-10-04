﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMakenOefening
{
    internal class Bier
    {
        public int BierNr { get; set; }
        public string Biernaam { get; set; }
        public float Alcohol { get; set; }
        public Brouwer Brouwer { get; set; } //associatie met een brouwer
        public override string ToString()
        {
            return $"{Biernaam}: {Alcohol}% alcohol";
        }
    }
}
