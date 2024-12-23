//NAMA  : ADWITIYA TIKTA PRAMASTI
//NIM   : 102022400179
//KELAS : SI-48-09

using System;

class VoidFunction {
    // Void function untuk menampilkan salam dan perkenalan
    static void TampilkanPerkenalan(string nama, string asal) {
        Console.WriteLine($"Halo, {nama}! Selamat datang di aktivitas 7");
        Console.WriteLine($"Senang bertemu dengan anda yang berasal dari {asal}");
        Console.WriteLine("Semoga kedepannya ngodingnya bisa speedrun :)");
    }

    static void Main() {
        // Membaca nama dari input pengguna
        Console.Write("Masukkan nama anda:");
        string? nama = Console.ReadLine(); 
        nama = nama ?? "Tidak Diketahui";

        // Membaca asal dari input pengguna
        Console.Write("Masukkan asal anda:");
        string? asal = Console.ReadLine();
        asal = asal ?? "Tidak Diketahui";

        // Menampilkan salam dan perkenalan
        TampilkanPerkenalan(nama,asal);
    }
}
