//NAMA  : ADWITIYA TIKTA PRAMASTI
//NIM   : 102022400179
//KELAS : SI-48-09

using System;

class List {
    static void Main() {
        // Program Latihan 1: List<int>
        Console.WriteLine("Latihan 1: List<int>");
        Console.WriteLine();
        List<int> angka_0179 = new List<int> { 10, 20, 30, 40, 50 };
        if (angka_0179.Count > 0) {
            angka_0179.RemoveAt(0);
        }
        angka_0179.Add(60);
        Console.WriteLine("Isi List setelah diubah:");
        foreach (int angka in angka_0179) {
            Console.WriteLine(angka);
        }

        // Program Latihan 2: List<string>
        Console.WriteLine();
        Console.WriteLine("Latihan 2: List<string>");
        Console.WriteLine();
        List<string> mahasiswa_0179 = new List<string> { "bara", "aurel", "widia", "rayula", "kai" };
        Console.WriteLine("Daftar mahasiswa:");
        foreach (string nama in mahasiswa_0179) {
            Console.WriteLine(nama);
        }
        Console.WriteLine();
        Console.Write("Masukkan nama mahasiswa yang ingin dicari: ");
        string cariNama_0179 = Console.ReadLine();
        if (mahasiswa_0179.Contains(cariNama_0179)) {
            Console.WriteLine($"{cariNama_0179} adalah mahasiswa yang terdaftar.");
        } else {
            Console.WriteLine($"{cariNama_0179} tidak terdaftar.");
        }
    }
}
