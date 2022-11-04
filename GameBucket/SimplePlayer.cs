using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameBucket
{
    internal class SimplePlayer: BasePlayer
    {
        public override int RandomNewNumber(int sizeBucket, List<int> numbersPlayers)
        {
            Random x = new Random(); 
            int n = x.Next(40, 140);
            //Numbers = new List<int>(n);
            Numbers.Add(n);
            //numbersPlayers.Add(n);
            Console.WriteLine(n);
            return n;

        }
    }
}
