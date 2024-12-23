//NAMA  : ADWITIYA TIKTA PRAMASTI
//NIM   : 102022400179
//KELAS : SI-48-09

using System;

class Statistik {
    static void Main(string[] args) {
        (int a,int b,int c) = InputAngka();
        double rataRata = HitungRataRata(a,b,c);
        int angkaTertinggi = CariAngkaTertinggi(a,b,c);
        int angkaTerendah = CariAngkaTerendah(a,b,c);
        int total = HitungTotal(a,b,c);
        DisplayResults(rataRata,angkaTertinggi,angkaTerendah,total);
    }

    static (int,int,int) InputAngka() {
        Console.WriteLine("========= Input Angka =========");
        Console.WriteLine("Masukkan tiga angka berbeda:");
        int a = InputSatuAngka("Angka pertama:");
        int b = InputSatuAngka("Angka kedua:");
        int c = InputSatuAngka("Angka ketiga:");
        return (a,b,c);
    }

    static int InputSatuAngka(string pesan) {
        int angka;
        while (true) {
            Console.Write(pesan);
            string input = Console.ReadLine() ?? "";
            if (int.TryParse(input, out angka)) break;
            Console.WriteLine("Input tidak valid. Harap masukkan angka");
        }
        return angka;
    }

    static double HitungRataRata(int a,int b,int c) { return (a+b+c)/3.0; }

    static int CariAngkaTertinggi(int a,int b,int c) {
        int max = a;
        if (b>max) max = b;
        if (c>max) max = c;
        return max;
    }

    static int CariAngkaTerendah(int a,int b,int c) {
        int min = a;
        if (b<min) min = b;
        if (c<min) min = c;
        return min;
    }

    static int HitungTotal(int a,int b,int c) { return a+b+c; }

    static void DisplayResults(double rataRata, int angkaTertinggi, int angkaTerendah, int total) {
        Console.WriteLine("==================");
        Console.WriteLine("Hasil Perhitungan:");
        Console.WriteLine($"Rata-rata: {rataRata:F2}");
        Console.WriteLine($"Angka Tertinggi: {angkaTertinggi}");
        Console.WriteLine($"Angka Terendah: {angkaTerendah}");
        Console.WriteLine($"Jumlah Total: {total}");
    }
}
