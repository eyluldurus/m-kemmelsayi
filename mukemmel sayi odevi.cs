// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        int toplam = 0;

        for (int i = 1; i < sayi; i++)
        {
            if (sayi % i == 0)
            {
                toplam += i;
            }
        }

        if (toplam == sayi)
        {
            Console.WriteLine($"{sayi} bir mükemmel sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} bir mükemmel sayı değildir.");
        }
    }
}
