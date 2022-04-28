using System;

namespace soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin. 
            // Sonrasında kullanıcıdan girdiği sayı kadar kelime girmesi isteyin. 
            // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru Console'a yazdırın.
            List<string> kelimeler = new List<string>();

            Console.WriteLine("Bir sayı giriniz:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} adet kelime giriniz:", x);
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("{0}. kelimeyi giriniz:", i + 1);
                string giris = Console.ReadLine();
                kelimeler.Add(giris);
            }

            for (int i = kelimeler.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(kelimeler[i]);
            }
        }
    }
}