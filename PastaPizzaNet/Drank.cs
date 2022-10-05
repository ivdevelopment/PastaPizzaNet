using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    internal abstract class Drank : IBedrag
    {
        public Drank()
        {
        }
            public enum Dranksoorten
        {
            water, limonade, cola, koffie, thee
        }
        public Dranksoorten Dranken { get; set; }
        public decimal Prijs { get; set; }


        public abstract decimal BerekenBedrag();
    }
}
