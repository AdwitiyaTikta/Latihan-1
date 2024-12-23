using System;

//NAMA: Adwitiya Tikta Pramasti
//NIM: 102022400179
//KELAS: SI-48-09

class Program
{
    static void Main()
    {
        Console.WriteLine("=== MENENTUKAN ANGKA GENAP ===");
        Console.WriteLine("=== Menggunakan For Loop, While Loop, Do/While Loop ===");
        Console.WriteLine("");

        // Menggunakan For Loop
        Console.WriteLine("=== For Loop ===");
        for (int F0179 = 1; F0179 <= 30; F0179++)
        {
            if (F0179 % 2 == 0) // Mengecek apakah angka genap
            {
                Console.WriteLine(F0179 + " Angka Genap");
            }
        }

        Console.WriteLine("");
        Console.WriteLine("=== While Loop ===");
        int W0179 = 1;
        while (W0179 <= 30)
        {
            if (W0179 % 2 == 0) // Mengecek apakah angka genap
            {
                Console.WriteLine(W0179 + " Angka Genap");
            }
            W0179++;
        }

        Console.WriteLine("");
        Console.WriteLine("=== Do/While Loop ===");
        int DW0179 = 1;
        do
        {
            if (DW0179 % 2 == 0) // Mengecek apakah angka genap
            {
                Console.WriteLine(DW0179 + " Angka Genap");
            }
            DW0179++;
        } while (DW0179 <= 30);

        Console.WriteLine("");
        Console.WriteLine("=== MENCETAK ANGKA GENAP 1 S/D 30 SELESAI ===");
    }
}
