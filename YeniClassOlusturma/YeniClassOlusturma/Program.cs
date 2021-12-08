using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniClassOlusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            Yeni inst = new Yeni();

            inst.birinci = 10;
            inst.ikinci = 20;


            Console.WriteLine(inst.birinci + inst.ikinci);
            Console.WriteLine(inst.toplama());

            //10 un 2. kuvveti
            //en küçük değer
            //mutlak değer

            float bir = 10f;
            float iki = 2f;

            Console.WriteLine(Math.Pow(bir, iki)); //100
            Console.WriteLine(Math.Min(20, 10));  //10
            Console.WriteLine(Math.Abs(-25.4f));  //25.4



            Console.ReadLine();
        }

        class Yeni
        {
            public int birinci;
            public int ikinci;

            public int toplama()
            {
                return birinci + ikinci;
            }
        }
    }
}
