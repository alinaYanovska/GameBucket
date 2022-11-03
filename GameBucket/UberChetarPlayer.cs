using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBucket
{
    internal class UberChetarPlayer
    {
        public List<int>? Numbers { get; set; }
        public bool RandomNewNumber(int sizeBucket, List<int> allNumber, out int n)
        {
            n = 0;
            if (Numbers.Count != 0)
            {
                n = Numbers[Numbers.Count - 1];
                n++;
            }
            else
            {
                n = 1;
            }
            
            for (int i = 0; i < allNumber.Count; i++)
            {
                if (n == allNumber[i])
                {
                    n++;
                    i = 0;
                }
            }
               
            Numbers.Add(n);
            Console.WriteLine(n);
            if (n == sizeBucket)
            {
                return true;
            }
            return false;

        }

    }
}

