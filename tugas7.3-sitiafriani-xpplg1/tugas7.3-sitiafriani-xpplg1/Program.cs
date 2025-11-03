using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas7._3_sitiafriani_xpplg1
{
    internal class Program
    {
       
            /**
   * Metode KonversiSuhu: Mengubah suhu dari Celcius ke Fahrenheit.
   * Menggunakan rumus: F = (C * 9/5) + 32.
   * * @param celcius Suhu dalam derajat Celcius.
   * @return Suhu yang sudah dikonversi dalam derajat Fahrenheit.
   */
            public static double KonversiSuhu(double celcius)
            {
                // Pastikan 9/5 dihitung sebagai operasi floating-point (1.8)
                // Rumus: F = (Celcius * 1.8) + 32
                double fahrenheit = (celcius * 9.0 / 5.0) + 32;

                // Mengembalikan hasil konversi
                return fahrenheit;
            }

            // Titik masuk utama program untuk demonstrasi
            public static void Main(string[] args)
            {
                Console.WriteLine("--- Demonstrasi Fungsi KonversiSuhu (C ke F) ---");

                // Contoh 1: Titik didih air (100°C)
                double suhuCelcius1 = 100;
                double hasilFahrenheit1 = KonversiSuhu(suhuCelcius1);
                Console.WriteLine($"{suhuCelcius1}°C sama dengan {hasilFahrenheit1}°F"); // Output: 212°F

                // Contoh 2: Titik beku air (0°C)
                double suhuCelcius2 = 0;
                double hasilFahrenheit2 = KonversiSuhu(suhuCelcius2);
                Console.WriteLine($"{suhuCelcius2}°C sama dengan {hasilFahrenheit2}°F"); // Output: 32°F

                // Contoh 3: Suhu ruangan (25°C)
                double suhuCelcius3 = 25;
                double hasilFahrenheit3 = KonversiSuhu(suhuCelcius3);
                Console.WriteLine($"{suhuCelcius3}°C sama dengan {hasilFahrenheit3}°F"); // Output: 77°F

                Console.ReadKey(); // Agar jendela konsol tidak langsung tertutup

            }
    }
}
