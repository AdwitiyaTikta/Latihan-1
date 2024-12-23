//NAMA  : ADWITIYA TIKTA PRAMASTI
//NIM   : 102022400179
//KELAS : SI-48-09

using System;
class MobileLegends {
    static void Main(string[] args) {
        string[] heroNames = {"Floryn","Roger","Lunox","Julian","Ling"};
        int[,] heroStats = new int[5, 3];
        Console.WriteLine("===Masukkan statistik untuk setiap hero mobile legends===");
        for (int i = 0; i < heroNames.Length; i++) {
            Console.WriteLine();
            Console.WriteLine($"Masukkan nilai statistik untuk hero: {heroNames[i]}");
            Console.Write("Attack:");
            heroStats[i,0] = int.Parse(Console.ReadLine());
            Console.Write("Defense:");
            heroStats[i,1] = int.Parse(Console.ReadLine());
            Console.Write("Magic:");
            heroStats[i,2] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("===HASIL ANALISIS===");
        Console.WriteLine();
        Console.WriteLine("Daftar Hero dan Statistiknya:");
        DisplayHeroStats(heroNames, heroStats);
        int maxAttackIndex = 0;
        for (int i = 1; i < heroNames.Length; i++) {
            if (heroStats[i,0] > heroStats[maxAttackIndex,0]) maxAttackIndex = i;
        }
        Console.WriteLine();
        Console.WriteLine($"Hero dengan Attack ter-OP: {heroNames[maxAttackIndex]} (Attack: {heroStats[maxAttackIndex, 0]})");
        Console.WriteLine();
        Console.WriteLine("Hero berdasarkan abjad:");
        SortHeroesByName(heroNames, heroStats);
        DisplayHeroStats(heroNames, heroStats);
    }
    static void DisplayHeroStats(string[] names, int[,] stats) {
        Console.WriteLine("Hero\t\tAttack\tDefense\tMagic");
        for (int i = 0; i < names.Length; i++) {
            Console.WriteLine($"{names[i]}\t\t{stats[i,0]}\t{stats[i,1]}\t{stats[i,2]}");
        }
    }
    static void SortHeroesByName(string[] names, int[,] stats) {
        for (int i = 0; i < names.Length - 1; i++) {
            for (int j = i + 1; j < names.Length; j++) {
                if (string.Compare(names[i], names[j], StringComparison.Ordinal) > 0) {
                    string tempName = names[i];
                    names[i] = names[j];
                    names[j] = tempName;
                    for (int k = 0; k < 3; k++) {
                        int tempStat = stats[i, k];
                        stats[i, k] = stats[j, k];
                        stats[j, k] = tempStat;
                    }
                }
            }
        }
    }
}
