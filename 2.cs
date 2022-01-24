using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci sayıyı giriniz=");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz=");
            int sayi2 = int.Parse(Console.ReadLine());
            int[] dizi = new int[sayi1];

            for (int i = 0; i < sayi1; i++)
            {
                Console.Write("{0}.sayıyı giriniz=",i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }
            for (int x = 0; x < dizi.Length; x++)
            {
                if (dizi[x] % sayi2 == 0){
                    Console.WriteLine(dizi[x]+" "+sayi2+" sayısına tam bölünmektedir");
                }
                else if(dizi[x]==sayi2)
                {
                    Console.WriteLine(dizi[x]+" "+sayi2+" sayısına eşittir");
                }
            }

        }
    }
}
