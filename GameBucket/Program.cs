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

Console.WriteLine("Размер корзины");
int bucket = 5;
Console.WriteLine(bucket);
int number;
List<int> allNumber = new List<int>();

bool isWinner = false;

while (!isWinner)
{
    for (int i = 0; i < newGame.AllPlayer.Length; i++)
    {
        Console.Write(newGame.AllPlayer[i].Name);
        int k = newGame.AllPlayer[i].RandomNewNumber(bucket);
        allNumber.Add(k);
        if (k == bucket)
        {
            isWinner= true;
            break;
        }
        isWinner = false;
    }
}
Console.WriteLine("You Win");
Console.WriteLine("rrrrrrr");
foreach (int i in newGame.AllPlayer[0].Numbers)
{
    
    Console.Write(i);
}




//

//SimplePlayer player1 = new SimplePlayer();
//player1.Numbers = new List<int>();

//UberChetarPlayer player2 = new UberChetarPlayer();
//player2.Numbers = new List<int>();


//
//foreach (int i in player1.Numbers)
//{
//    Console.WriteLine(i);
//}

//UberPlayer player2 = new UberPlayer();
//player1.Numbers = new List<int>();
//while (!isWinner)
//{
//    isWinner = player1.RandomNewNumber(bucket, out number);
//}
//Console.WriteLine("You Win");
//foreach (int i in player1.Numbers)
//{
//    Console.WriteLine(i);
//}



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