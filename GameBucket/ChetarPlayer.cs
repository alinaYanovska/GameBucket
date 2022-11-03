using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBucket
{
    internal class ChetarPlayer: BasePlayer
    {
        public override int RandomNewNumber(int sizeBucket, List<int> numbersPlayers)
        {
            Random x = new Random();
            int n = x.Next(0, 10);
            for (int i=0; i< numbersPlayers.Count; i++)
            {
                if (n == numbersPlayers[i])
                {
                    n = x.Next(0, 10);
                    i = 0;
                }
            }
            Numbers.Add(n);
            Console.WriteLine(n);
            return n;

        }
        
    }
}
