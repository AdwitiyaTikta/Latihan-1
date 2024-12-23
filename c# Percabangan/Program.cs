//NAMA  : ADWITIYA TIKTA PRAMASTI
//NIM   : 102022400179
//KELAS : SI-48-09

using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan nilai UTS: ");
        int nilaiUts = int.Parse(Console.ReadLine());

        if (nilaiUts >= 0179)
        {
            Console.WriteLine("Lulus UTS");
        }
        else
        {
            Console.WriteLine("Tidak Lulus UTS");
        }
    }
}

