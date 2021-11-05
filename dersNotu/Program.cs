using System;

namespace dersNotu
{
    class Program
    {
        static void Main(string[] args)
        {
            int not;
            Console.WriteLine("Notunuzu giriniz.");
            not = int.Parse(Console.ReadLine());
            if (not<=100&& not>=90)
            {
                Console.WriteLine("AA ile dersi geçtiniz");

            }
            else if (not<90 && not>=80)
            {
                Console.WriteLine("BA ile dersi geçtiniz.");

            }
            else if (not < 80 && not >= 70)
            {
                Console.WriteLine("BB ile dersi geçtiniz.");

            }
            else if (not < 70 && not >= 60)
            {
                Console.WriteLine("CB ile dersi geçtiniz.");

            }
            else if (not < 60 && not >= 50)
            {
                Console.WriteLine("CC ile dersi geçtiniz.");

            }
            else if (not < 50 && not >= 40)
            {
                Console.WriteLine("DC ile dersi geçtiniz.");

            }
            else
            {
                Console.WriteLine("Dersi geçemediniz.");
            }
            Console.ReadKey();

        }
    }
}
