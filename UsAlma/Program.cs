using System;

namespace UsAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            double top = 1, taban, us;
            Console.WriteLine("Taban giriniz = ");
            taban = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("üs giriniz = ");
            us = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= us; i++)
            {
                top = top * taban;
            }
            Console.WriteLine(taban + " Üssü " + us + " = {0} ", top);

            Console.ReadKey();
        }
    }
}
