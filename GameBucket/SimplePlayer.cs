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
        //public string Name { get; set; }
        //public List<int>? Numbers { get; set; } 
        public override int RandomNewNumber(int sizeBucket)
        {
            Random x = new Random(); 
            int n = x.Next(0,10);
            //Numbers = new List<int>(n);
            Numbers.Add(n);
            Console.WriteLine(n);
            return n;

        }
    }
}
