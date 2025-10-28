using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fungsi_hitung_luas_sitiafriani_xpplg1
{
    internal class Program
    {
        static double HitungLuas(double panjang, double lebar)
        {
            double luas = panjang * lebar;
            return luas;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan panjang: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar: ");
            double l = Convert.ToDouble(Console.ReadLine());

            double hasil = HitungLuas(p, l);
            Console.WriteLine("Luas persegi panjang adalah: " + hasil);
        }
    }
}
