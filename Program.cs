using System;

namespace dizi_ornekleri2
{
    class Program
    {
        static void Main(string[] args)
        {
            //index sayısı belli dizi içine kullanıcıdan sayı alıp, tek çiftleri ayırıp hesaplatma
            int tsayiAdet = 0;
            int csayiAdet =0;
            int tsayiToplam = 0;
            int csayiToplam = 0;
            int[] sayilar = new int[4];

            for (int i = 0; i < 4 ; i++)
            {
                Console.Write("Dizinin "+(i+0)+". elemanını giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int k in sayilar)
            {
                if ((k%2) == 0)
                {
                    csayiAdet++;
                    csayiToplam += k;
                }
                else
                {
                    tsayiAdet++;
                    tsayiToplam += k;
                }
            }
                if (tsayiToplam > csayiToplam)
                {
                    Console.WriteLine("Tek sayıların toplamı çift sayıların toplamından büyüktür");
                }
                else
                {
                    Console.WriteLine("Çift sayıların toplamı tek sayıların toplamından büyüktür");
                }
                Console.WriteLine("Dizi içerisinde "+csayiAdet+" tane çift sayı vardır");
                Console.WriteLine("Dizi içerisindeki çift sayıların toplamı :"+csayiToplam);

                Console.WriteLine("Dizi içerisinde "+tsayiAdet+" tane tek sayı vardır");
                Console.WriteLine("Dizi içerisindeki tek sayıların toplamı :"+tsayiToplam);


























        }
    }
}
