using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle giriniz=");
            string cumle = Console.ReadLine();
            string[] kelimeS = cumle.Split(" ");
            Console.WriteLine("Cümlede {0} kelime vardır.", kelimeS.Length);
            int harfS = 0;
            for (int i = 0; i<kelimeS.Length;i++){
                char[] harfDizi = kelimeS[i].ToCharArray();
                harfS += harfDizi.Length;
            }
            Console.WriteLine("Cümlede {0} harf vardır.",harfS);
        }
    }
}
