//NAMA  : ADWITIYA TIKTA PRAMASTI
//NIM   : 102022400179
//KELAS : SI-48-09

using System;

class Podomoro {
    static void Main(string[] args) {
        StartOrder();
    }

    static void StartOrder() {
        List<(string, int)> pesanan = new List<(string, int)>(); // Pesanan tetap disimpan di sini

        while (true) {
            Console.WriteLine("\nSelamat datang di Warteg Podomoro :)");
            Console.WriteLine("Silakan pilih kategori:");
            Console.WriteLine("1. Makanan");
            Console.WriteLine("2. Minuman");
            Console.WriteLine("3. Selesai");

            Console.Write("Pilih kategori (1-3): ");
            string pilihan = Console.ReadLine();

            if (pilihan == "1") pesanan.AddRange(OrderMakanan());
            else if (pilihan == "2") pesanan.AddRange(OrderMinuman());
            else if (pilihan == "3") {
                DisplayTotal(pesanan);
                break;
            } else {
                Console.WriteLine("Pilihan tidak valid, sistem akan kembali ke menu utama.");
            }
        }
    }

    static List<(string, int)> OrderMakanan() {
        List<(string, int)> pesananMakanan = new List<(string, int)>();
        while (true) {
            Console.WriteLine("\nMenu Makanan:");
            Console.WriteLine("1. Ayam Kampung = Rp 10.000");
            Console.WriteLine("2. Sop Sayur = Rp 8.000");
            Console.WriteLine("3. Rolade Daging = Rp 7.000");
            Console.WriteLine("4. Kembali");

            Console.Write("Pilih makanan (1-4): ");
            string pilihan = Console.ReadLine();

            if (pilihan == "1") pesananMakanan.Add(("Ayam Kampung", 10000));
            else if (pilihan == "2") pesananMakanan.Add(("Sop Sayur", 8000));
            else if (pilihan == "3") pesananMakanan.Add(("Rolade Daging", 7000));
            else if (pilihan == "4") break;
            else Console.WriteLine("Pilihan tidak valid.");
        }

        return pesananMakanan;
    }

    static List<(string, int)> OrderMinuman() {
        List<(string, int)> pesananMinuman = new List<(string, int)>();
        while (true) {
            Console.WriteLine("\nMenu Minuman:");
            Console.WriteLine("1. Es Teh = Rp 4.000");
            Console.WriteLine("2. Es Jeruk = Rp 7.000");
            Console.WriteLine("3. Es Kopi = Rp 5.000");
            Console.WriteLine("4. Kembali");

            Console.Write("Pilih minuman (1-4): ");
            string pilihan = Console.ReadLine();

            if (pilihan == "1") pesananMinuman.Add(("Es Teh", 4000));
            else if (pilihan == "2") pesananMinuman.Add(("Es Jeruk", 7000));
            else if (pilihan == "3") pesananMinuman.Add(("Es Kopi", 5000));
            else if (pilihan == "4") break;
            else Console.WriteLine("Pilihan tidak valid.");
        }

        return pesananMinuman;
    }

    static void DisplayTotal(List<(string, int)> pesanan) {
        Console.WriteLine("\nPesanan Anda:");
        int total = 0;

        foreach (var item in pesanan) {
            Console.WriteLine($"{item.Item1} - Rp {item.Item2:N0}");
            total += item.Item2;
        }

        Console.WriteLine($"Total Harga: Rp {total:N0}");
        Console.WriteLine("Terima kasih telah memesan di Warteg Podomoro, jangan datang lagi ya ^^");
    }
}
