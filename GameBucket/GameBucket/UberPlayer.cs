using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBucket
{
    internal class UberPlayer
    {
        public List<int> Numbers { get; set; }
        public bool RandomNewNumber(int sizeBucket)
        {
            int n = 0;
            if (Numbers.Count != 0)
            {
                n = Numbers[Numbers.Count - 1];
                n++;
                Numbers.Add(n);
            }
            else 
            {
                n = 1;
                Numbers.Add(n); 
            }
            if (n == sizeBucket)
            {
                return true;
            }
            return false;

        }
    }
}
