using System;

namespace soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin. 
            // Sonrasında kullanıcıdan girdiği sayı kadar pozitif sayı girmesini isteyin. 
            // Kullanıcının girmiş olduğu sayılardan çift olanlar Console'a yazdırın.
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} adet sayı giriniz: ", n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: ", i + 1);
                int giris = Convert.ToInt32(Console.ReadLine());
                if (giris % 2 == 0)
                {
                    Console.WriteLine("Çift sayı girdiniz.");
                }
            }
        }
    }
}