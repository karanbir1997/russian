using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russian
{
    class main
    {
        public int loaded;
        public int Spinner;
        public int shooter;

        public int restart = 2;
        int ran;
        public int spiner()
        {
            Random spiner = new Random();
            return ran = spiner.Next(1, 7);// this code is chooses the random number between 1-7

        }
        public int spinner(int Spined)
        {
            if (Spined == 6)//this code returns the value of spined 
            {
                Spined = 1;
            }
            else
            {
                Spined++;
            }
            return Spined;

        }
    }
}
