using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class BesteldGerecht
    {
        public enum Grootte
        {
            klein = 1,
            groot = 2
        }
        public enum GroottePrijs
        {
            klein = 0,
            groot = 3
        }

        public enum Extras
        {
            brood = 1,
            kaas = 1,
            look = 1
        }
    }
}
