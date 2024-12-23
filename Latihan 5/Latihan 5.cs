//NAMA  : ADWITIYA TIKTA PRAMASTI
//NIM   : 102022400179
//KELAS : SI-48-09

using System;

class NilaiMatematika {
    static void Main(string[] args) {
        int[,] nilaiUjian = new int[3,2];
        bool running = true;
        Console.WriteLine("===PROGRAM MENCATAT NILAI UJIAN MTK===");
        while (running) {
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Input Nilai Ujian");
            Console.WriteLine("2. Tampilkan Nilai Ujian");
            Console.WriteLine("3. Keluar");
            Console.Write("Pilih opsi:");
            int pilihan = int.Parse(Console.ReadLine());
            switch (pilihan) {
                case 1:
                    InputNilai(nilaiUjian);
                    break;
                case 2:
                    TampilkanNilai(nilaiUjian);
                    break;
                case 3:
                    running = false;
                    Console.WriteLine("Program dihentikan");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid");
                    break;
            }
        }
    }
    static void InputNilai(int[,] nilai) {
            Console.WriteLine();
            Console.WriteLine("Masukkan Nilai Ujian Matematika");
            Console.WriteLine();
        for (int i = 0; i < nilai.GetLength(0); i++) {
            Console.WriteLine($"Kelas {i + 1}:");
            for (int j = 0; j < nilai.GetLength(1); j++) {
                Console.Write($"Masukkan nilai siswa {j + 1}:");
                nilai[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
    static void TampilkanNilai(int[,] nilai) {
            Console.WriteLine();
            Console.WriteLine("Data Nilai Ujian Matematika");
            Console.WriteLine();
        for (int i = 0; i < nilai.GetLength(0); i++) {
            int totalNilai = 0;
            Console.WriteLine($"Kelas {i + 1}:");
            for (int j = 0; j < nilai.GetLength(1); j++) {
                Console.WriteLine($"Siswa {j + 1}:{nilai[i, j]}");
                totalNilai += nilai[i, j];
            }
            Console.WriteLine($"Total nilai kelas {i + 1}:{totalNilai}");
            Console.WriteLine();
        }
    }
}
