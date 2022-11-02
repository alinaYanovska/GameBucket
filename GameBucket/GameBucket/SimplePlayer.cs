using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameBucket
{
    internal class SimplePlayer
    {
        public List <int> Numbers { get; set; }
        public bool RandomNewNumber(int sizeBucket)
        {
            Random x = new Random(); 
            int n = x.Next(0,100);
            Numbers.Add(n);
            if(n == sizeBucket)
            {

                return true;
            }
            return false;

        }
    }
}
