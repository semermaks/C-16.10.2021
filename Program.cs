using System;
using static System.Console;
using System.Linq;

namespace Hag_Dz_16._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Zadanie 1:");


            string[] strings = new string[] {"Your time is out!",
            "Programming is a crazy worjewkjw hobby", "Returning now wow non\n"};
            foreach (var str in strings) WriteLine(str);

            char C = 'W';
            char tmpC = char.Parse(C.ToString().ToLower());

            var Zadanie1 = from str in strings
                           let words = str.Split(' ')
                           from word in words
                           where word.Length >1 && word.First() == tmpC && word.Last() == tmpC
                           select word;
            WriteLine("char C = 'W';");
            WriteLine("подходящие по заданию слова: ");
            foreach(var el in Zadanie1)
            {
                WriteLine(el + " ");
            }
            
            var testArray = new int[20];
            var rnd = new Random();
            WriteLine("\n\nZadanie 2:");
            WriteLine("Исходный массив:");
            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = rnd.Next(-100,100);
                Write(testArray[i] + " ");
            }

            var Zadanie2 = from num in testArray
                           where num >= 0 && num / 100 <= 0
                           select num;

            double serednee = 0;
            foreach (var el in Zadanie2)
            {
                serednee += el;
            }
            WriteLine();
            if (Zadanie2.Count() != 0)
            {
                serednee /= Zadanie2.Count();
                WriteLine("Подходящие по заданию цифры: ");
                foreach (var el in Zadanie2)
                {
                    WriteLine(el + " ");
                }
                WriteLine("Среднее арифетическое: ");
                WriteLine("\n" + serednee);
            }
            else WriteLine(0 + "\n" + 0);
        }
    }
}
