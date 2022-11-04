using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBucket
{
    internal class UberPlayer: BasePlayer
    {
        public override int RandomNewNumber(int sizeBucket, List<int> numbersPlayers)
        {
            int n = 0;
            if (Numbers.Count != 0)
            {
                n = Numbers[Numbers.Count - 1];
                n++;
                Numbers.Add(n);
                Console.WriteLine(n);
            }
            else 
            {
                n = 40;
                Numbers.Add(n);
                Console.WriteLine(n);
            }
            return n;

        }
    }
}
