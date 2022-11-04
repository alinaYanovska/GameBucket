// See https://aka.ms/new-console-template for more information
using GameBucket;
using System.Xml.Linq;

//Console.WriteLine("Количество играков ");
//Random x = new Random();
//int countPlayerRND = 2;// x.Next(2, 8);
//BasePlayer[] countPlayer = new BasePlayer[countPlayerRND];
 

//for(int i = 0; i < countPlayerRND; i++)
//{
//    Console.WriteLine("Выберите тип игрока \n 1. Simple\n 2. Notebook\n  3. Chetar\n  4.Uber\n  5.UberChetar");
//    double type= Convert.ToDouble(Console.ReadLine());
//    switch (type)
//    {
//        case 1:
//            countPlayer[i] = new SimplePlayer();
//            countPlayer[i].Numbers = new List<int>();
//            break;
//        case 2:
//            countPlayer[i] = new NotebookPlayer();
//            countPlayer[i].Numbers = new List<int>();
//            break;
//        case 3:
//            countPlayer[i] = new SimplePlayer();
//            countPlayer[i].Numbers = new List<int>();
//            break;
//        case 4:
//            countPlayer[i] = new SimplePlayer();
//            countPlayer[i].Numbers = new List<int>();
//            break;
//        case 5:
//            countPlayer[i] = new SimplePlayer();
//            countPlayer[i].Numbers = new List<int>();
//            break;
//    }
//    Console.WriteLine("Введите имя игрока");
//    countPlayer[i].Name = Console.ReadLine();
//}
Game newGame= new Game();
newGame.CreatePlayer();
bool endGame=newGame.SearcheNumber(newGame);
if (endGame)
    Console.WriteLine("end game");

//SimplePlayer player1 = new SimplePlayer();
//player1.Numbers= new List<int>();
//bool isWinner = false;
//while (!isWinner)
//{ 
//    isWinner = player1.RandomNewNumber(bucket); 
//}
//Console.WriteLine("You Win");
//foreach(int i in player1.Numbers)
//{
//    Console.WriteLine(i);
//}