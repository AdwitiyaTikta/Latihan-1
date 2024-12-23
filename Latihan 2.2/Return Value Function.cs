//NAMA  : ADWITIYA TIKTA PRAMASTI
//NIM   : 102022400179
//KELAS : SI-48-09

using System;

class ReturnValue {
    // Fungsi untuk menghitung luas permukaan kubus
    static int HitungLuasPermukaan(int sisi) {
        return 6*sisi*sisi;  // Luas permukaan kubus: 6*s^2
    }

    // Fungsi untuk menghitung keliling salah satu sisi kubus
    static int HitungKeliling(int sisi) {
        return 4*sisi;  // Keliling salah satu sisi kubus: 4*s
    }

    static void Main() {
        int sisi = 5;  // Sisi kubus

        // Menghitung luas permukaan kubus
        int luasPermukaan = HitungLuasPermukaan(sisi);
        Console.WriteLine($"Luas permukaan kubus dengan sisi {sisi} adalah: {luasPermukaan}");

        // Menghitung keliling salah satu sisi kubus
        int keliling = HitungKeliling(sisi);
        Console.WriteLine($"Keliling salah satu sisi kubus dengan sisi {sisi} adalah: {keliling}");
    }
}

