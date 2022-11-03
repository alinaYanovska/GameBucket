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
        public void CreatePlayer()
        {
            Console.WriteLine("Количество играков ");
            Random x = new Random();
            int countPlayerRND = 2;// x.Next(2, 8);
            AllPlayer = new BasePlayer[countPlayerRND];
            for (int i = 0; i < countPlayerRND; i++)
            {
                Console.WriteLine("Выберите тип игрока \n 1. Simple\n 2. Notebook\n  3. Chetar\n  4.Uber\n  5.UberChetar");
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
                        AllPlayer[i] = new SimplePlayer();
                        AllPlayer[i].Numbers = new List<int>();
                        break;
                    case 4:
                        AllPlayer[i] = new SimplePlayer();
                        AllPlayer[i].Numbers = new List<int>();
                        break;
                    case 5:
                        AllPlayer[i] = new SimplePlayer();
                        AllPlayer[i].Numbers = new List<int>();
                        break;
                }
                Console.WriteLine("Введите имя игрока");
                AllPlayer[i].Name = Console.ReadLine();
            }
        }
        public void SearcheNumber(Game newGame)
        {
            Console.WriteLine("Размер корзины");
            AllNumberPlayers = new List<int>();
            Bucket = 5;
            Console.WriteLine(Bucket);

            //int number;
            

            bool isWinner = false;

            while (!isWinner)
            {
                for (int i = 0; i < newGame.AllPlayer.Length; i++)
                {
                    Console.Write(newGame.AllPlayer[i].Name);
                    int k = newGame.AllPlayer[i].RandomNewNumber(Bucket, AllNumberPlayers);
                    AllNumberPlayers.Add(k);
                    if (k == Bucket)
                    {
                        isWinner = true;
                        break;
                    }
                    isWinner = false;
                }
            }
            Console.WriteLine("You Win");
        }
    }
}
