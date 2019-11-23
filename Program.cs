using System;

namespace ConsoleApp2._876
{
    class Program
    {
       static void Main()
        {
            int a, b;
            a = 0;
            b = 0;
            Console.WriteLine("Lütfen birinci sayıyı giriniz");

            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı giriniz");

            b = Int32.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Girdiğiniz iki sayıdan büyük olan sayı: " + a);
            }
            else if(a==b)
            {
                Console.WriteLine("Girdiğiniz iki sayı birbirine eşittir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz iki sayıdan büyük olan sayı: " + b);
            }
            Console.ReadLine();
            Main();
        }
    }
}
