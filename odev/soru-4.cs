using System;

namespace soru_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            // Cümledeki toplam kelime ve harf sayısını Console'a yazdırın.
            Console.WriteLine("Bir cümle yazınız:");
            string giris = Console.ReadLine();


            Console.WriteLine("Harf Sayısı: " + giris.Length);
            string[] kelimeler = giris.Split(' ');
            Console.WriteLine("Kelime Sayısı: " + kelimeler.Length);
        }
    }
}