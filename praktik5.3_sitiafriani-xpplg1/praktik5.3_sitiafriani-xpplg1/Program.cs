using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik5._3_sitiafriani_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nama = new string[3];
            int[] nilai = new int[3];

            Console.WriteLine("Masukkkan nama siswa ke-1");
            nama[0] = Console.ReadLine();
            Console.WriteLine("Masukkan nilai siswa ke-1");
            nilai[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukkkan nama siswa ke-2");
            nama[1] = Console.ReadLine();
            Console.WriteLine("Masukkan nilai siswa ke-2");
            nilai[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkkan nama siswa ke-3");
            nama[2] = Console.ReadLine();
            Console.WriteLine("Masukkan nilai siswa ke-3");
            nilai[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=== Data Siswa ===");
            Console.WriteLine("Nama: " + nama[0] + " | Nilai: " + nilai[0]);
            Console.WriteLine("Nama: " + nama[1] + " | Nilai: " + nilai[1]);
            Console.WriteLine("Nama: " + nama[2] + " | Nilai: " + nilai[2]);
        }
    }
}
