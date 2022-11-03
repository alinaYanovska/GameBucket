using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBucket
{
    public abstract class BasePlayer
    {
        public string Name { get; set; }
        public BasePlayer TypeOfPlayer { get; set; }
        public List<int>? Numbers { get; set; }
        public List<int>? AllNumbers { get; set; }

        public abstract int RandomNewNumber(int sizeBucket);
    }
}
