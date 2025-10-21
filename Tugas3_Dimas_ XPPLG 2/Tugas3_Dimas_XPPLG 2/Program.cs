using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas3_Danu_Tri__XPPLG_2
{
    internal class Program
    {
        /* buat Fungsikonversi untuk mengubah suhu dari celcius ke fahrenheit dengan
             F = (C x 9/5) + 32
            Tampilkan hasil konversi pada program utama! */

        static double ConvertCelciusToFahrenheit(double celcius)
        {
            double fahrenheit = (celcius * 9 / 5) + 32;
            return fahrenheit;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("program konversi suhu dari ke fahrenheit");
            Console.Write("Masukan suhu dalam celcius: ");
            double celcius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{celcius}°C= {fahrenheit}");
        }
    }
}
