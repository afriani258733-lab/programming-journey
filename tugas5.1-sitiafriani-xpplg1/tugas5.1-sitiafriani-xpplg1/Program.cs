using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas5._1_sitiafriani_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nma = new string[3];
            char[] jk = new char[3];
            string[] kelas = new string[3];

            Console.Write("Masukkan nama siswa ke-1: ");
            nma[0] = Console.ReadLine();
            Console.Write("Masukkan jenis kelamin (L/P): ");
            jk[0] = char.Parse(Console.ReadLine());
            Console.Write("Masukkan kelas: ");
            kelas[0] = Console.ReadLine();

            Console.Write("Masukkan nama siswa ke-2: ");
            nma[1] = Console.ReadLine();
            Console.Write("Masukkan jenis kelamin (L/P): ");
            jk[1] = char.Parse(Console.ReadLine());
            Console.Write("Masukkan kelas: ");
            kelas[1] = Console.ReadLine();

            Console.Write("Masukkan nama siswa ke-3: ");
            nma[2] = Console.ReadLine();
            Console.Write("Masukkan jenis kelamin (L/P): ");
            jk[2] = char.Parse(Console.ReadLine());
            Console.Write("Masukkan kelas: ");
            kelas[2] = Console.ReadLine();

            Console.WriteLine("\n=== Data Siswa ===");
            Console.WriteLine($"Nama: {nma[0]} | Jenis Kelamin: {jk[0]} | Kelas: {kelas[0]}");
            Console.WriteLine($"Nama: {nma[1]} | Jenis Kelamin: {jk[1]} | Kelas: {kelas[1]}");
            Console.WriteLine($"Nama: {nma[2]} | Jenis Kelamin: {jk[2]} | Kelas: {kelas[2]}");
        }
    }
}
        
    

