using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tugas2_Danu_Tri_X_PPLG_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai pertama: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan nilai kedua: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan nilai ketiga: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double hasil = rata_rata(a, b, c);
            Console.WriteLine($"\nrata-rata = {hasil}");
        }

        static double rata_rata(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}
