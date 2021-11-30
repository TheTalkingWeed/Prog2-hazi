using System;

namespace Hazi1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Fizz Buzz
            for ( int i = 0; i <= 100;i++) {
                if (i % 3 == 0) Console.WriteLine("fizz");
                if (i % 5 == 0) Console.WriteLine("buzz");
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("Fizzbuzz");
                else Console.WriteLine(i);
                }
            ///-----------------///

            //ezenél kisseb pozitiv szamok
            int sum = 0;
            for (int i = 0; i <= 1000; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
/*ha a szám osztható 3-mal, akkor a szám helyett azt írjuk ki, hogy "fizz"
ha a szám osztható 5-tel, akkor a szám helyett azt írjuk ki, hogy "buzz"
ha a szám 3-mal és 5-tel is osztható, akkor a szám helyett azt írjuk ki, hogy "fizzbuzz"
(alapesetben csak maga a szám legyen kiírva)*/