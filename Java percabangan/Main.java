//NAMA  : ADWITIYA TIKTA PRAMASTI
//NIM   : 102022400179
//KELAS : SI-48-09

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Masukkan nilai UTS: ");
        int nilaiUts = scanner.nextInt();

        if (nilaiUts >= 179) {
            System.out.println("Lulus UTS");
        } else {
            System.out.println("Tidak Lulus UTS");
        }
        System.out.println("Batas nilai untuk lulus adalah: 0179");
    }
}
