//NAMA  : ADWITIYA TIKTA PRAMASTI
//NIM   : 102022400179
//KELAS : SI-48-09

using System;

class Hewan {
    static void Main() {
        //Program Array 2 Dimensi
        Console.WriteLine("Array 2 Dimensi:");
        string[,] hewan2D_0179 = {
            { "Kucing", "Anjing", "Gajah", "Kuda", "Harimau" },
            { "Singa", "Zebra", "Jerapah", "Ular", "Buaya" }
        };
        Console.WriteLine();

        for (int baris_0179 = 0; baris_0179 < hewan2D_0179.GetLength(0); baris_0179++) {
            for (int kolom_0179 = 0; kolom_0179 < hewan2D_0179.GetLength(1); kolom_0179++) {
                Console.Write(hewan2D_0179[baris_0179, kolom_0179] + " ");
            }
            Console.WriteLine();
        }

        //Pencarian pada Array 2 Dimensi
        Console.WriteLine();
        Console.Write("Apakah hewan ada di dalam Array 2 dimensi: ");
        string cariHewan2D_0179 = Console.ReadLine();
        bool ditemukan2D_0179 = false;

        for (int baris_0179 = 0; baris_0179 < hewan2D_0179.GetLength(0); baris_0179++) {
            for (int kolom_0179 = 0; kolom_0179 < hewan2D_0179.GetLength(1); kolom_0179++) {
                if (hewan2D_0179[baris_0179, kolom_0179].Equals(cariHewan2D_0179, StringComparison.OrdinalIgnoreCase)) {
                    ditemukan2D_0179 = true;
                    break;
                }
            }
            if (ditemukan2D_0179) break;
        }

        Console.WriteLine();
        Console.WriteLine(ditemukan2D_0179 ? $"Hewan {cariHewan2D_0179} ditemukan di array 2 dimensi." : $"Hewan {cariHewan2D_0179} tidak ditemukan di array 2 dimensi.");
        Console.WriteLine();

         /* Penjelasan:
           - Array 2 dimensi adalah array dengan baris dan kolom.
           - Deklarasi : Array 2 dimensi `hewan2D_0179` menyimpan 10 elemen hewan, dibagi dalam 2 baris dan 5 kolom.
           - Pencetakan: Elemen dicetak menggunakan nested loop (`for`) untuk mengakses setiap elemen berdasarkan baris dan kolom.
        */

        Console.WriteLine("=============================================");
        Console.WriteLine();

        //Program Array 3 Dimensi
        Console.WriteLine("Array 3 Dimensi:");
        string[,,] hewan3D_0179 = {
            {
                { "Kucing", "Anjing" }, { "Gajah", "Kuda" }, { "Harimau", "Singa" }
            },
            {
                { "Zebra", "Jerapah" }, { "Ular", "Buaya" }, { "Panda", "Koala" }
            }
        };
        Console.WriteLine();

        for (int dimensi1_0179 = 0; dimensi1_0179 < hewan3D_0179.GetLength(0); dimensi1_0179++) {
            for (int dimensi2_0179 = 0; dimensi2_0179 < hewan3D_0179.GetLength(1); dimensi2_0179++) {
                for (int dimensi3_0179 = 0; dimensi3_0179 < hewan3D_0179.GetLength(2); dimensi3_0179++) {
                    Console.Write(hewan3D_0179[dimensi1_0179, dimensi2_0179, dimensi3_0179] + " ");
                }
                Console.WriteLine();
            }
        }

        //Pencarian pada Array 3 Dimensi
        Console.WriteLine();
        Console.Write("Apakah hewan ada di dalam array 3 dimensi: ");
        string cariHewan3D_0179 = Console.ReadLine();
        bool ditemukan3D_0179 = false;

        for (int dimensi1_0179 = 0; dimensi1_0179 < hewan3D_0179.GetLength(0); dimensi1_0179++) {
            for (int dimensi2_0179 = 0; dimensi2_0179 < hewan3D_0179.GetLength(1); dimensi2_0179++) {
                for (int dimensi3_0179 = 0; dimensi3_0179 < hewan3D_0179.GetLength(2); dimensi3_0179++) {
                    if (hewan3D_0179[dimensi1_0179, dimensi2_0179, dimensi3_0179].Equals(cariHewan3D_0179, StringComparison.OrdinalIgnoreCase)) {
                        ditemukan3D_0179 = true;
                        break;
                    }
                }
                if (ditemukan3D_0179) break;
            }
            if (ditemukan3D_0179) break;
        }

        Console.WriteLine();
        Console.WriteLine(ditemukan3D_0179 ? $"Hewan {cariHewan3D_0179} ditemukan di array 3 dimensi." : $"Hewan {cariHewan3D_0179} tidak ditemukan di array 3 dimensi.");
        Console.WriteLine();

        /* Penjelasan:
           - Array 3 dimensi adalah array yang memiliki elemen dalam tiga tingkatan indeks.
           - Deklarasi : Array 3 dimensi `hewan3D_0179` menyimpan 10 elemen hewan, diatur dalam 2 layer, masing-masing berisi 3 grup, dan setiap grup memiliki 2 hewan.
           - Pencetakan: Elemen dicetak menggunakan nested loop tiga tingkat untuk mengakses indeks layer, grup, dan elemen.
        */
    }
}
