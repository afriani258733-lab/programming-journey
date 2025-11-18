using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> todoList = new List<string>();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==== APLIKASI JADWAL TUGAS ====");
            Console.WriteLine("1. Lihat Daftar Tugas");
            Console.WriteLine("2. Tambah Tugas");
            Console.WriteLine("3. Hapus Tugas");
            Console.WriteLine("4. Keluar");
            Console.Write("\nPilih menu (1-4): ");

            string pilihan = Console.ReadLine();
            Console.Clear();

            switch (pilihan)
            {
                case "1":
                    Console.WriteLine("=== DAFTAR TUGAS ===");
                    if (todoList.Count == 0)
                    {
                        Console.WriteLine("Belum ada tugas.");
                    }
                    else
                    {
                        for (int i = 0; i < todoList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {todoList[i]}");
                        }
                    }
                    Console.WriteLine("\nTekan ENTER untuk kembali...");
                    Console.ReadLine();
                    break;

                case "2":
                    Console.Write("Masukkan nama tugas: ");
                    string tugasBaru = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(tugasBaru))
                    {
                        todoList.Add(tugasBaru);
                        Console.WriteLine("Tugas berhasil ditambahkan!");
                    }
                    else
                    {
                        Console.WriteLine("Nama tugas tidak boleh kosong.");
                    }
                    Console.WriteLine("\nTekan ENTER untuk kembali...");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine("=== HAPUS TUGAS ===");
                    for (int i = 0; i < todoList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {todoList[i]}");
                    }

                    Console.Write("\nMasukkan nomor tugas yang ingin dihapus: ");
                    if (int.TryParse(Console.ReadLine(), out int nomor) && nomor > 0 && nomor <= todoList.Count)
                    {
                        todoList.RemoveAt(nomor - 1);
                        Console.WriteLine("Tugas berhasil dihapus!");
                    }
                    else
                    {
                        Console.WriteLine("Nomor tidak valid.");
                    }
                    Console.WriteLine("\nTekan ENTER untuk kembali...");
                    Console.ReadLine();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Keluar dari aplikasi...");
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}



            
        

    

