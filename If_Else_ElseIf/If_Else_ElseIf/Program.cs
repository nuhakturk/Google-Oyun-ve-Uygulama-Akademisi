using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_ElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //20 ye kadar sayi olan bir zar
            //15-20 arasında büyük zarar
            //10-15 arasında orta boyut zarar
            //5-10 zarar yok
            //0-5 kendime zarar
            //4. veya 5. zar 18 üstünde gelirse ek zarar vereceğiz

            Random zar = new Random();

            int birinciAtis = zar.Next(1, 21);
            int ikinciAtis = zar.Next(1, 21);
            int ucuncuAtis = zar.Next(1, 21);
            int dorduncuAtis = zar.Next(1, 21);
            int besinciAtis = zar.Next(1, 21);

            float ortalama = (birinciAtis + ikinciAtis + ucuncuAtis) / 3f;

            if (ortalama > 15)
            {
                Console.WriteLine("Büyük Zarar Verdin");
            }
            else if (ortalama <= 15 && ortalama > 10)
            {
                Console.WriteLine("Orta Boyutta Zarar Verdin");
            }
            else if (ortalama <= 10 && ortalama > 5)
            {
                Console.WriteLine("Zarar Yok");
            }
            else if (ortalama <= 5 && ortalama > 2)
            {
                Console.WriteLine("Kendine Zarar Verdin");
            }
            else
            {
                Console.WriteLine("2 den küçük olduğunda çalışacak");
            }
            Console.WriteLine(ortalama);

            

            if (dorduncuAtis >= 18 || besinciAtis >= 18) // false veya false > false döner diğer durumlar true döner!
            {
                Console.WriteLine("Ek Zarar Verdin");
            }

            Console.WriteLine(birinciAtis + " " + ikinciAtis + " " + ucuncuAtis + " " + dorduncuAtis + " " + besinciAtis);

            if (ortalama >= 10)
            {
                Console.WriteLine("ortalama 10 un üzerinde");
                if (birinciAtis > 12)
                {
                    Console.WriteLine("Birinci atış 12 nin üzerinde");
                    if (ikinciAtis > 15)
                    {
                        Console.WriteLine("Nested if orneği");
                    }
                    else if (ikinciAtis > 12)
                    {
                        Console.WriteLine("İkinci atış 12 nin üzerinde");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
