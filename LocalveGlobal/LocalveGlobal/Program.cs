using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalveGlobal
{
    class Program
    {
        //public static int sayi2;
        static void Main(string[] args)
        {
            int sayi2 = 0;
            int sayi = 5;
            if (sayi == 5)
            {
                sayi2 = 20;
            }

            Console.WriteLine(sayi2);
            Console.ReadLine();
        }
    }
}
