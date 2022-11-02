using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBucket
{
    internal class ChetarPlayer
    {
        public List<int> Numbers { get; set; }
        public bool RandomNewNumber(int sizeBucket, UberPlayer uberPlayer,SimplePlayer simplePlayer, NotebookPlayer notebookPlayer, UberChetarPlayer uberChetar)
        {
            Random x = new Random();
            int n = x.Next(0, 100);
            bool isNumber = false;
            while (isNumber == false)
            {
                for (int i=0; i< Numbers.Count; i++)
                {
                    if (n ==Numbers[i])
                    {
                        n = x.Next(0, 100);
                        i = 0;
                    }
                }
                for (int i = 0; i < uberPlayer.Numbers.Count; i++)
                {
                    if (n == uberPlayer.Numbers[i])
                    {
                        n = x.Next(0, 100);
                        break;
                    }
                }
                for (int i = 0; i < simplePlayer.Numbers.Count; i++)
                {
                    if (n == simplePlayer.Numbers[i])
                    {
                        n = x.Next(0, 100);
                        break;
                    }
                }
                
                for (int i = 0; i < notebookPlayer.Numbers.Count; i++)
                {
                    if (n == notebookPlayer.Numbers[i])
                    {
                        n = x.Next(0, 100);
                        break;
                    }
                }
                for (int i = 0; i < uberChetar.Numbers.Count; i++)
                {
                    if (n == uberChetar.Numbers[i])
                    {
                        n = x.Next(0, 100);
                        break;
                    }
                }
                isNumber = true;

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
