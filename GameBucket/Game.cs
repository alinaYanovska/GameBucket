using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBucket
{
    internal class Game
    {
        public BasePlayer[] AllPlayer { get; set; }
        public List<int>? AllNumberPlayers { get; set; }
        public int Bucket { get; set; }
        public int KolAtt { get; set; }//количество попыток
        
        public void CreatePlayer()
        {
            Console.WriteLine("Количество играков ");
            Random x = new Random();
            int countPlayerRND = x.Next(2, 8);
            Console.WriteLine(countPlayerRND);
            AllPlayer = new BasePlayer[countPlayerRND];
            KolAtt = 0;
            for (int i = 0; i < countPlayerRND; i++)
            {
                Console.WriteLine("Выберите тип игрока \n 1. Simple\n 2. Notebook\n 3. Chetar\n 4.Uber\n 5.UberChetar");
                double type = Convert.ToDouble(Console.ReadLine());
                switch (type)
                {
                    case 1:
                        AllPlayer[i] = new SimplePlayer();
                        AllPlayer[i].Numbers = new List<int>();
                        break;
                    case 2:
                        AllPlayer[i] = new NotebookPlayer();
                        AllPlayer[i].Numbers = new List<int>();
                        break;
                    case 3:
                        AllPlayer[i] = new ChetarPlayer();
                        AllPlayer[i].Numbers = new List<int>();
                        break;
                    case 4:
                        AllPlayer[i] = new UberPlayer();
                        AllPlayer[i].Numbers = new List<int>();
                        break;
                    case 5:
                        AllPlayer[i] = new UberChetarPlayer();
                        AllPlayer[i].Numbers = new List<int>();
                        break;
                }
                Console.WriteLine("Введите имя игрока");
                AllPlayer[i].Name = Console.ReadLine();
            }
        }
        public bool SearcheNumber(Game newGame)
        {
            Console.WriteLine("Размер корзины^ ");
            newGame.AllNumberPlayers = new List<int>();
            Random x = new Random(); 
            newGame.Bucket = x.Next(40, 140);;
            Console.WriteLine(Bucket);

            bool isWinner = false;

            do
            {
                for (int i = 0; i < newGame.AllPlayer.Length; i++)
                {
                    Console.Write(newGame.AllPlayer[i].Name + " ");
                    int k = newGame.AllPlayer[i].RandomNewNumber(Bucket, AllNumberPlayers);
                    newGame.AllNumberPlayers.Add(k);
                    KolAtt++;
                    if (k == Bucket)
                    {
                        isWinner = true;
                        Console.WriteLine($"Победил игрок {AllPlayer[i].Name} угадал число корзины: {Bucket} ");
                        return true;
                    }
                    else if (KolAtt == 100)
                    {
                        isWinner = ClosestNumber(newGame);
                        return true;
                    }
                }
            } while (!isWinner || KolAtt != 100);
            return true;
        }
        public bool ClosestNumber(Game newGame)
        {
            AllNumberPlayers.Add(Bucket);
            AllNumberPlayers.Sort();
            int numBucket=AllNumberPlayers.IndexOf(Bucket);
            if(numBucket!=0 && numBucket != AllNumberPlayers.Count - 1) 
            { 
                int el1 = AllNumberPlayers[numBucket - 1];
                int el2 = AllNumberPlayers[numBucket + 1];
                el1 = Bucket - el1;
                el2 = el2- Bucket;
                if (el1 == el2)
                {
                    el1 = AllNumberPlayers[numBucket - 1];
                    el2 = AllNumberPlayers[numBucket + 1];
                    for (int i = 0; i < newGame.AllPlayer.Length; i++)
                    {
                        for (int j = 0; j < AllPlayer[i].Numbers.Count; j++)
                        {
                            if (AllPlayer[i].Numbers[j] == el1)
                            {
                                Console.WriteLine($"Победил игрок {AllPlayer[i].Name} его число {AllPlayer[i].Numbers[j]} было самое близкое к {Bucket} ");
                                return true;
                            }
                            if (AllPlayer[i].Numbers[j] == el2)
                            {
                                Console.WriteLine($"Победил игрок {AllPlayer[i].Name} его число {AllPlayer[i].Numbers[j]} было самое близкое к  {Bucket}");
                                return true;
                            }
                        }
                    }
                }
                else if (el1 < el2)
                {
                    el1 = AllNumberPlayers[numBucket - 1];
                    for (int i = 0; i < newGame.AllPlayer.Length; i++)
                    {
                        for (int j = 0; j < AllPlayer[i].Numbers.Count; j++)
                        {
                            if (AllPlayer[i].Numbers[j] == el1)
                            {
                                Console.WriteLine($"Победил игрок {AllPlayer[i].Name} его число {AllPlayer[i].Numbers[j]} было самое близкое к {Bucket}");
                                return true;
                            }
                        }
                    }
                }
                else if (el1 < el2)
                {
                    el2 = AllNumberPlayers[numBucket + 1];
                    for (int i = 0; i < newGame.AllPlayer.Length; i++)
                    {
                        for (int j = 0; j < AllPlayer[i].Numbers.Count; j++)
                        {
                            if (AllPlayer[i].Numbers[j] == el2)
                            {
                                Console.WriteLine($"Победил игрок {AllPlayer[i].Name} его число {AllPlayer[i].Numbers[j]} было самое близкое к {Bucket}");
                                return true;
                            }
                        }
                    }
                }
            
            }
            else if (numBucket == 0)
            {
                int el = AllNumberPlayers[numBucket + 1];
                for (int i = 0; i < newGame.AllPlayer.Length; i++)
                {
                    for (int j = 0; j < AllPlayer[i].Numbers.Count; j++)
                    {
                        if (AllPlayer[i].Numbers[j] == el)
                        {
                            Console.WriteLine($"Победил игрок {AllPlayer[i].Name} его число {AllPlayer[i].Numbers[j]} было самое близкое к {Bucket} ");
                            return true;
                        }
                    }
                }

            }
            else
            {
                int el = AllNumberPlayers[numBucket - 1];
                for (int i = 0; i < newGame.AllPlayer.Length; i++)
                {
                    for (int j = 0; j < AllPlayer[i].Numbers.Count; j++)
                    {
                        if (AllPlayer[i].Numbers[j] == el)
                        {
                            Console.WriteLine($"Победил игрок {AllPlayer[i].Name} его число {AllPlayer[i].Numbers[j]} было самое близкое к {Bucket} ");
                            return true;
                        }
                    }
                }
            }
                return false;
        }
    }
}
