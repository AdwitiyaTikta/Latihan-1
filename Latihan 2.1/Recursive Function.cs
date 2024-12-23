//NAMA  : ADWITIYA TIKTA PRAMASTI
//NIM   : 102022400179
//KELAS : SI-48-09

using System;

class RecursiveFunction {
    //Metode rekursif untuk menghitung faktorial
    static int HitungFaktorial(int n) {
        if (n <= 1) {
            Console.Write("1"); 
            return 1;
        }

        Console.Write($"{n} * ");
        return n * HitungFaktorial(n - 1);
    }

    static void Main() { 
        int angka = 5; // Angka yang akan dihitung faktorialnya
        Console.Write($"Faktorial dari {angka} adalah: "); 
        int hasil = HitungFaktorial(angka); // Hitung faktorial
        Console.WriteLine($" = {hasil}"); // Cetak hasil faktorial setelah semua proses selesai
    }
}
