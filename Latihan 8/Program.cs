//NAMA  : Adwitiya Tikta Pramasti
//NIM   : 102022400179
//KELAS : SI-48-09

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("===== WDP =====");

        int jumlahKategori = 0;
        while (true)
        {
            Console.Write("jumlah kategori produk:");
            string? inputJumlahKategori = Console.ReadLine();
            if (int.TryParse(inputJumlahKategori, out jumlahKategori) && jumlahKategori > 0)
                break;
            else
                Console.WriteLine("Input tidak valid");
        }

        var kategoriData = new Dictionary<string, List<(string, double, int)>>();

        for (int i = 0; i < jumlahKategori; i++)
        {
            Console.WriteLine($"");
            Console.WriteLine($"Kategori ke-{i + 1}:");

            string namaKategori;
            while (true)
            {
                Console.Write("Nama kategori: ");
                namaKategori = Console.ReadLine() ?? "";
                if (!string.IsNullOrWhiteSpace(namaKategori))
                    break;
                else
                    Console.WriteLine("Nama tidak valid");
            }

            int jumlahProduk = 0;
            while (true)
            {
                Console.Write("Jumlah produk dalam kategori ini: ");
                string? inputJumlahProduk = Console.ReadLine();
                if (int.TryParse(inputJumlahProduk, out jumlahProduk) && jumlahProduk > 0)
                    break;
                else
                    Console.WriteLine("Input tidak valid");
            }

            var produkList = new List<(string, double, int)>();

            for (int j = 0; j < jumlahProduk; j++)
            {
                Console.WriteLine($"Produk ke-{j + 1}:");

                string namaProduk;
                while (true)
                {
                    Console.Write("Nama produk: ");
                    namaProduk = Console.ReadLine() ?? "";
                    if (!string.IsNullOrWhiteSpace(namaProduk))
                        break;
                    else
                        Console.WriteLine("input tidak valid");
                }

                double hargaSatuan = 0;
                while (true)
                {
                    Console.Write("Harga satuan: ");
                    string? inputHargaSatuan = Console.ReadLine();
                    if (double.TryParse(inputHargaSatuan, out hargaSatuan) && hargaSatuan > 0)
                        break;
                    else
                        Console.WriteLine("Input tidak valid");
                }

                int jumlahTerjual = 0;
                while (true)
                {
                    Console.Write("Jumlah terjual:");
                    string? inputJumlahTerjual = Console.ReadLine();
                    if (int.TryParse(inputJumlahTerjual, out jumlahTerjual) && jumlahTerjual >= 0)
                        break;
                    else
                        Console.WriteLine("Input tidak valid");
                }

                produkList.Add((namaProduk, hargaSatuan, jumlahTerjual));
            }

            kategoriData[namaKategori] = produkList;
        }

        Console.WriteLine("=== Penjualan ===");

        double totalPenjualanToko = 0;
        string? kategoriTerbaik = null;
        double penjualanKategoriTertinggi = 0;

        foreach (var kategori in kategoriData)
        {
            double totalPenjualanKategori = 0;
            string? produkTerlaris = null;
            double penjualanTertinggi = 0;

            Console.WriteLine($"");
            Console.WriteLine($"Kategori: {kategori.Key}");

            foreach (var produk in kategori.Value)
            {
                double nilaiPenjualan = produk.Item2 * produk.Item3;
                totalPenjualanKategori += nilaiPenjualan;

                Console.WriteLine($"Nama produk: {produk.Item1}");
                Console.WriteLine($"Harga satuan: {produk.Item2}");
                Console.WriteLine($"Jumlah terjual: {produk.Item3}");

                if (nilaiPenjualan > penjualanTertinggi)
                {
                    penjualanTertinggi = nilaiPenjualan;
                    produkTerlaris = produk.Item1;
                }
            }

            if (produkTerlaris != null)
            {
                Console.WriteLine($"Produk dengan nilai penjualan tertinggi di kategori {kategori.Key}: {produkTerlaris} dengan nilai penjualan Rp{penjualanTertinggi}");
            }

            totalPenjualanToko += totalPenjualanKategori;

            if (totalPenjualanKategori > penjualanKategoriTertinggi)
            {
                penjualanKategoriTertinggi = totalPenjualanKategori;
                kategoriTerbaik = kategori.Key;
            }
        }

        Console.WriteLine("");
        Console.WriteLine($"Total nilai penjualan toko: Rp{totalPenjualanToko}");
        if (kategoriTerbaik != null)
        {
            Console.WriteLine($"Kategori dengan nilai penjualan tertinggi: {kategoriTerbaik} dengan total penjualan Rp{penjualanKategoriTertinggi}");
        }
    }
}