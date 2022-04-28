using System;

namespace soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin. 
            // Sonrasında kullanıcıdan girdiği ilk sayı kadar pozitif sayı girmesini isteyin. 
            // Kullanıcının girmiş olduğu sayılardan, başlangıçta girdiği ikinci sayıya eşit ya da tam bölünenleri Console'a yazdırın.
            Console.WriteLine("1. sayıyı giriniz:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} adet sayı giriniz:", x);
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz:", i + 1);
                int giris = Convert.ToInt32(Console.ReadLine());
                if ((giris == y) || (giris % y == 0))
                {
                    Console.WriteLine("Giriş yaptığınız sayı, giriş yaptığınız 2. sayıya eşit ya da sayıyı tam bölüyor.");
                }
            }
        }
    }
}