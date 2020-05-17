using System;

namespace Sıcaklık_Çevirici_Programı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            string seç;
            double Celcius, Kelvin, Fahrenheit, CelKel, CelFah, KelCel, KelFah, FahCel, FahKel;
            Console.WriteLine("--'Sıcaklık Dönüştürücü Program'--");

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.Write("+ 'Hangi Değerden Dönüştürmek İstediğinizi Yazınız: ");
            seç = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            if (seç == "Celcius")
            {               
                Console.Write("Bir derece giriniz: ");
                Celcius = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                CelKel = Celcius + 273.15;
                CelFah = Celcius * 1.8 + 32;

                Console.WriteLine("Celcius Değeri = " + Celcius);
                Console.WriteLine("Kelvin Değeri = " + CelKel);
                Console.WriteLine("Fahrenheit Değeri = " + CelFah);
            }

            else if (seç == "Kelvin")
            {
                Console.Write("Bir derece giriniz: ");
                Kelvin = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                KelCel = Kelvin - 273 * 15;
                KelFah = 9 / 5 * (Kelvin - 273) + 32;

                Console.WriteLine("Celcius Değeri = " + KelCel);
                Console.WriteLine("Kelvin Değeri = " + Kelvin);
                Console.WriteLine("Fahrenheit Değeri = " + KelFah);
            }

            else if (seç == "Fahrenheit")
            {
                Console.Write("Bir derece giriniz: ");
                Fahrenheit = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                FahCel = (Fahrenheit - 32) / 1 * 8;
                FahKel = (Fahrenheit + 459.67) * 5 / 9;

                Console.WriteLine("Celcius Değeri = " + FahCel);
                Console.WriteLine("Kelvin Değeri = " + FahKel);
                Console.WriteLine("Fahrenheit Değeri = " + Fahrenheit);
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Yapan: Xowly");

            Console.ReadKey();

        }
    }
}
