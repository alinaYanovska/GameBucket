using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBucket
{
    internal class UberChetarPlayer : BasePlayer
    {
        public override int RandomNewNumber(int sizeBucket, List<int> numbersPlayers)
        {
            int n = 0;
            if (Numbers.Count != 0)
            {
                n = Numbers[Numbers.Count - 1];
                n++;
            }
            else
            {
                n = 40;
            }
            
            for (int i = 0; i < numbersPlayers.Count; i++)
            {
                if (n == numbersPlayers[i])
                {
                    n++;
                    i = 0;
                }
            }
               
            Numbers.Add(n);
            Console.WriteLine(n);
            return n;

        }

    }
}

