using System;

namespace testGLS_Peter
{
    class Program
    {
        static void Main(string[] args)
        {
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

