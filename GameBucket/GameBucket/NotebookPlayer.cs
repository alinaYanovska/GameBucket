using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBucket
{
    internal class NotebookPlayer
    {
        public List<int> Numbers { get; set; }
        public bool RandomNewNumber(int sizeBucket)
        {
            Random x = new Random();
            int n = x.Next(0, 100);
            
            for (int i = 0; i < Numbers.Count; i++)
            {
                if (n == Numbers[i])
                {
                    n = x.Next(0, 100);
                    i = 0;
                }
            }
            Numbers.Add(n);
            if (n == sizeBucket)
            {
                return true;
            }
            return false;

        }
    }
}
