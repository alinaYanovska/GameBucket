using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBucket
{
    internal class UberChetarPlayer
    {
        public List<int> Numbers { get; set; }
        public bool RandomNewNumber(int sizeBucket, UberPlayer uberPlayer, SimplePlayer simplePlayer, NotebookPlayer notebookPlayer, UberChetarPlayer uberChetar)
        {
            int n = 0;
            if (Numbers.Count != 0)
            {
                n = Numbers[Numbers.Count - 1];
                n++;
            }
            else
            {
                n = 1;
            }
            bool isNumber = false;
            while (isNumber == false)
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    if (n == Numbers[i])
                    {
                        n++;
                        i = 0;
                    }
                }
                for (int i = 0; i < uberPlayer.Numbers.Count; i++)
                {
                    if (n == uberPlayer.Numbers[i])
                    {
                        n++;
                        break;
                    }
                }
                for (int i = 0; i < simplePlayer.Numbers.Count; i++)
                {
                    if (n == simplePlayer.Numbers[i])
                    {
                        n++;
                        break;
                    }
                }

                for (int i = 0; i < notebookPlayer.Numbers.Count; i++)
                {
                    if (n == notebookPlayer.Numbers[i])
                    {
                        n++;
                        break;
                    }
                }
                for (int i = 0; i < uberChetar.Numbers.Count; i++)
                {
                    if (n == uberChetar.Numbers[i])
                    {
                        n++;
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

