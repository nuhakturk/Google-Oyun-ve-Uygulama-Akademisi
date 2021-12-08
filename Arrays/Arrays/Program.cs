using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] siparisNo = new string[3]; //memory de array boyutu kadar yer açılır.

            siparisNo[0] = "INZ123";
            siparisNo[1] = "GOOGLE2";
            siparisNo[2] = "GOOGLE3";

            siparisNo[0] = "INZ345"; //değişiklik
            */

            string[] siparisNo = {"birinci siparis", "ikinci siparis", "ucuncu siparis"};
            int[] fiyat = { 250, 300, 700 };
            int toplamFiyat = 0;
            int say = 0;

            Console.WriteLine(siparisNo[2]);
            Console.WriteLine("Dizi Uzunluğu: " + siparisNo.Length);

            foreach (string siparis in siparisNo)
            {
                Console.WriteLine(siparis); //3 kere donecek
            }

            foreach (var sipFiyat in fiyat)
            {
                toplamFiyat += sipFiyat;
                say++;
            }

            Console.WriteLine(toplamFiyat + " " + say);
            
            Console.ReadLine();
        }
    }
}
