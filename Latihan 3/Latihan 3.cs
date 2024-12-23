//NAMA  : Adwitiya Tikta Pramasti
//NIM   : 102022400179
//KELAS : SI-48-09

using System;

class Program
{
    static void Main()
    {
        string correctUsername = "adwitiya"; 
        string correctPassword = "102022400179"; 
        int percobaan = 3;

        while (percobaan > 0)
        {
            Console.Write("Masukkan Username: ");
            string username = Console.ReadLine() ?? string.Empty;

            Console.Write("Masukkan Password: ");
            string password = Console.ReadLine() ?? string.Empty;

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("=============================");
                Console.WriteLine("=== Selamat, anda berhasil login! ===");
                break;
            }
            else
            {
                percobaan--;

                if (username != correctUsername && password != correctPassword)
                {
                    Console.WriteLine("=== Username dan Password salah, login gagal ===");
                }
                else if (username != correctUsername)
                {
                    Console.WriteLine("=== Username salah, login gagal ===");
                }
                else if (password != correctPassword)
                {
                    Console.WriteLine("=== Password salah, login gagal ===");
                }

                if (percobaan > 0)
                {
                    Console.WriteLine($"Percobaan tersisa ({percobaan})x");
                }
                else
                {
                    Console.WriteLine("========================");
                    Console.WriteLine("=== Coba lagi besok! ===");
                }
            }
        }
    }
}

