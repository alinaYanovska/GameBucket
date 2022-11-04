using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBucket
{
    public class NotebookPlayer:BasePlayer
    {
        public override int RandomNewNumber(int sizeBucket, List<int> numbersPlayers)
        {
            Random x = new Random();
            int n = x.Next(40, 140);
            
            for (int i = 0; i < Numbers.Count; i++)
            {
                if (n == Numbers[i])
                {
                    n = x.Next(40, 140);
                    i = 0;
                }
            }
            Numbers.Add(n);
            Console.WriteLine(n);
            return n;

        }
    }
}
