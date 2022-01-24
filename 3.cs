using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz=");
            int n = int.Parse(Console.ReadLine());
            string[] dizi = new string[n];
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0}. kelimeyi giriniz=", i + 1);
                dizi[i] = Console.ReadLine();
            }
            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
