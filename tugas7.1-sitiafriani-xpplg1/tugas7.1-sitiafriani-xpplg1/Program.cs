using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas7._1_sitiafriani_xpplg1
{
    internal class Program
    {
            static int Perkalian(int a, int b, int c)
            {
                return a * b * c;
            }
            static void Main(string[] args)
            {
                Console.Write("Masukkan angka pertama:");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan angka kedua:");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan angka ketiga:");
                int z = Convert.ToInt32(Console.ReadLine());

                int hasil = Perkalian(x, y, z);
                Console.WriteLine("Hasil penjumlahan: " + hasil);

            }
    }
}
