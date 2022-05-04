using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // //1'den başlayarak Consoledan girilen sayıya kadar (sayı dahil) ortalamalarını hesaplayıp, Consolea yazdıran program.
            // Console.WriteLine("Bir sayı giriniz:");
            // int sayi = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam = 0;
            // while (sayac <= sayi)
            // {
            //     toplam += sayac;
            //     sayac ++;
            // }

            // Console.WriteLine(toplam/sayi);

            // // A'dan Z'ye kadar tüm harfleri Consolea yazdıran program.
            // char character = 'A';
            // while (character < 'Z')
            // {
            //     Console.WriteLine(character);
            //     character ++;
            // }

            //
            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}