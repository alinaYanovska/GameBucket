using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBucket
{
    public class NotebookPlayer:BasePlayer
    {
        //public List<int>? Numbers { get; set; }
        public override int RandomNewNumber(int sizeBucket)
        {
            Random x = new Random();
            int n = x.Next(0, 10);
            
            for (int i = 0; i < Numbers.Count; i++)
            {
                if (n == Numbers[i])
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
