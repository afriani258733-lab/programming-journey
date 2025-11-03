using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik5._2_sitiafriani_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] angka = new int[5];
            Console.WriteLine("Masukkan nilai ke-1: ");
            angka[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai ke-2: ");
            angka[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai ke-3: ");
            angka[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai ke-4: ");
            angka[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai ke-5: ");
            angka[4] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
