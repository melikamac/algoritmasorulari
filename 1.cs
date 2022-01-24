using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pozitif bir sayı giriniz=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}.sayıyı giriniz=", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    Console.WriteLine(dizi[i]+" sayısı çift bir sayıdır.");
                }
            }
        }
    }
}
