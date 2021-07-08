using System;
using System.Collections.Generic;
using System.Linq;

namespace testGLS_Peter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter your numbers

            List<int> userLottoVol2 = new List<int>();
            List<int> kindOfWinners = new List<int>();
            for (int i=1; i<=6; i++)
            {
                Console.WriteLine($"Enter number {i}");
                userLottoVol2.Add(Convert.ToInt32(Console.ReadLine()));
            }

            //  userLottoVol2.ForEach(Console.WriteLine);


            for (int numberOfGames = 0; numberOfGames <= 14; numberOfGames++)
            {

                //Let's play
                Random rnd = new Random();
                List<int> myLottoVol2 = new List<int>();
                int numberOfDuplicates = 0;

                while (myLottoVol2.Count < 6)
                {
                    int numberToPushVol2 = rnd.Next(1, 9);

                    bool alreadyExistNumber = myLottoVol2.Contains(numberToPushVol2);
                    //      Console.WriteLine($"Number to push: {numberToPushVol2}");
                    //      Console.WriteLine($"Already exists : {alreadyExistNumber}");
                    if (alreadyExistNumber)
                    {
                        numberOfDuplicates++;
                    }
                    else
                    {
                        myLottoVol2.Add(numberToPushVol2);

                    }

                }
                //   Console.WriteLine($"Number of duplicates: {numberOfDuplicates}");
                //    myLottoVol2.ForEach(Console.WriteLine);

                List<int> GoodNumbers = userLottoVol2.Intersect(myLottoVol2).ToList(); //prościej: order by, max
                                                                                       //   Console.WriteLine($"Good hits!");
                                                                                       //    GoodNumbers.ForEach(Console.WriteLine);

                int howManyGoodNumbers = GoodNumbers.Count;

                kindOfWinners.Add(howManyGoodNumbers);

                Console.WriteLine("[{0}]", string.Join(", ", kindOfWinners));


         
            
           

                //

                //  Console.WriteLine($"Number of games: {numberOfGames}, number winners: {howManyGoodNumbers}");
                //  Console.WriteLine($"Number of good hits, 1 number, 2 numbers, 3 numbers etc.:");
                //   kindOfWinners.ForEach(Console.WriteLine);

                /*   if (kindOfWinners==3) {

                   }*/


            }
            for(int i =1; i<=6; i++) {
                if (kindOfWinners.IndexOf(i) > 0)
                {
                    Console.WriteLine($"After {kindOfWinners.IndexOf(i)} draw lots you have hit {i} numbers");
                } else
                {
                    Console.WriteLine($"You did not hit any {i} numbers");
                }
            }
           
           /* if (kindOfWinners.IndexOf(5) > 0)
            {
              Console.WriteLine($"After {kindOfWinners.IndexOf(5)} draw lots you have hit 5 numbers");
            }

          
            if (kindOfWinners.IndexOf(6) > 0)
            {
              Console.WriteLine($"After {kindOfWinners.IndexOf(6)} draw lots you have hit 6 numbers");
            } else
            {
              Console.WriteLine($"You did not hit 6 numbers");
            }
*/







            var groups = kindOfWinners.GroupBy(v => v);
            foreach (var group in groups)
            {
                Console.WriteLine($"Value {group.Key} has {group.Count()} items", group.Key, group.Count());
            }



























            /*
                        Random rnd = new Random();
                     //   var numberToRand = 36;
                        //int number1 = rnd.Next(1, numberToRand);
                        int[] lottoArray = new int[6];
                      //  List<int> sequence = Enumerable.Range(1, 36).ToList();

                        Console.WriteLine("Over the loop");

                        for (int i = 0; i < lottoArray.Length; i++)
                        {
                            Console.WriteLine($"Number of interation: {i}");
                            int numberToPush = rnd.Next(1, 12);
                            Console.WriteLine($"Wylosowano {numberToPush}");

                            for (int j=0; j<i; j++)
                            {
                                Console.WriteLine($"Number of interation inside: {j}");

                                if (numberToPush != lottoArray[j])
                                {
                                    lottoArray[j] = numberToPush;

                                } else
                                {
                                    Console.WriteLine("else");
                                }


                            }


                            //Losowanie bez powtórzeń



                           Console.WriteLine(lottoArray[i]);
                        }
                        Console.WriteLine("Out of the loop");

                        Console.WriteLine("[{0}]", string.Join(", ", lottoArray));

            *//*






















                        int x = -3;
                        //  string path = "C:\televisions\sony\bravia.txt";
                        string pathWithAt = @"C:\televisions\sony\bravia.txt";

                        Console.WriteLine("Hello World 4!");
                        Console.WriteLine("Temperature on " + x);
                        //  Console.WriteLine(path);
                        Console.WriteLine(pathWithAt);
                        Console.WriteLine($"int uses {sizeof(int)}");


                        string[] myNames;

                        myNames = new string[4];

                        myNames[0] = "Struś";
                        myNames[1] = "Lucilla";
                        myNames[2] = "Rebeca";
                        myNames[3] = "Purra";



                        //       Console.WriteLine(myNames[2]);

                        //   for (int i = 0; i<myNames.Length; i++)
                        //    {
                        //        Console.WriteLine(myNames[i]);
                        //   }

                        foreach (string i in myNames)
                        {
                            Console.WriteLine(i);
                        }
                        //

                        int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };

                        foreach (int i in numbers)
                        {
                            System.Console.Write("{0} ", i);
                        }
                        // Output: 4 5 6 1 2 3 -2 -1 0


                        string authorName = "Tomasz";
                        // the following throws a NullReferenceException
                        int xx2 = authorName.Length;
                        // instead of throwing an exception, null is assigned to y
                        int? yy2 = authorName?.Length;
                        Console.WriteLine($"Number of letters in name:  {xx2}");
                        int numberOfApples = 3;
                        Console.WriteLine($"liczba jabłek  {numberOfApples}");


                        //User can set posiotion of console log:
                        //         string bananasText = "Bananas";
                        //     int bananasCount = 56789;




                        Console.Write("Type your first name and press ENTER: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Type your age and press ENTER: ");
                        string age = Console.ReadLine();
                        Console.WriteLine(
                         $"Hello {firstName}, you look good for {age}.");


                        //do



                        //for

                        for (int y = 1; y <= 10; y++)
                        {
                            System.Console.Write(y);
                        };

                        //foreach

                        string[] names = { "Adam", "Barry", "Charlie" };

                        foreach (string name in names)
                        {
                            Console.WriteLine($"{name} has {name.Length} characters.");
                        }


                        int a = 10; // 0000 1010
                        int b = 6; // 0000 0110
                        Console.WriteLine($"a = {a}");
                        Console.WriteLine($"b = {b}");
                        Console.WriteLine($"a & b = {a & b}"); // 2-bit column only
                        Console.WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns
                        Console.WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns

                        //
                        int age3 = 47;
                        // How many operators in the following statement?
                        char firstDigit = age3.ToString()[0];


                        //

                        var bytes = new byte[5];
                        Console.WriteLine(bytes);
                        // rand.NextBytes(bytes);
                        //    Console.WriteLine("Five random byte values:");
                        //    foreach (byte byteValue in bytes)
                        //    Console.Write("{0, 5}", byteValue);
                        //    Console.WriteLine();


                        //

                        //  int x = 0;
                        //     while (x < 10)
                        //      {
                        //          WriteLine(x);
                        //         x++;
                        //     }



                        //*/
        }
    }
}
//
//char - one letter,
//string - string, block of text,
//uint = 2 // only >= 0
//int = -2 // all total numbers
//
//Variables:
//int population = 66_000_000; // 66 million in UK 
//double weight = 1.88; // in kilograms
//decimal price = 4.99M; // in pounds sterling
//string fruit = "Apples"; // strings use double-quotes
//char letter = 'Z'; // chars use single-quotes
//bool happy = true; // Booleans have value of true or false
//
//All these variables can by dynamic-typing: 
//var population = 66_000_000
//var fruit = "Apples"
//var happy = true


// 
//
//
//
//

