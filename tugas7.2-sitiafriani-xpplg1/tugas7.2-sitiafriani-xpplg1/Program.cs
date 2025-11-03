using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas7._2_sitiafriani_xpplg1
{
    internal class Program
    {


        /**
* Metode RataRata: Menerima tiga nilai (double) dan mengembalikan hasil rata-ratanya.
* * @param nilai1 Nilai pertama.
* @param nilai2 Nilai kedua.
* @param nilai3 Nilai ketiga.
* @return Hasil rata-rata dari ketiga nilai.
*/
        public static double RataRata(double nilai1, double nilai2, double nilai3)
        {
            // Hitung total penjumlahan ketiga nilai
            double total = nilai1 + nilai2 + nilai3;

            // Hitung rata-rata (Total dibagi 3) dan kembalikan hasilnya
            return total / 3.0;
        }

        // Titik masuk utama program untuk demonstrasi
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Demonstrasi Fungsi RataRata ---");

            // Contoh 1: Menghitung rata-rata nilai bulat
            double hasil1 = RataRata(80, 90, 100);
            Console.WriteLine($"Rata-rata dari 80, 90, dan 100 adalah: {hasil1}"); // Output: 90

            // Contoh 2: Menghitung rata-rata nilai desimal
            double hasil2 = RataRata(75.5, 88.0, 92.5);
            Console.WriteLine($"Rata-rata dari 75.5, 88.0, dan 92.5 adalah: {hasil2}"); // Output: 85.333...

            Console.ReadKey(); // Agar jendela konsol tidak langsung tertutup
        }
    }
}

