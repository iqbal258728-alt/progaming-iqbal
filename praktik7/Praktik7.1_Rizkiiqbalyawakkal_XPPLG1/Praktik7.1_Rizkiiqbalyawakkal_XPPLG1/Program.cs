using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik7._1_Rizkiiqbalyawakkal_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ini adalah metode 'Kali' yang menerima tiga argumen bertipe double
 public static void Kali(double bilangan1, double bilangan2, double bilangan3)
        {
            // 1. Hitung hasil perkalian
            double hasilPerkalian = bilangan1 * bilangan2 * bilangan3;

            // 2. Tampilkan hasilnya ke konsol
            Console.WriteLine($"Hasil perkalian dari {bilangan1}, {bilangan2}, dan  adalah: {hasilPerkalian}");
        }

        // Titik masuk utama program
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Contoh Penggunaan Fungsi Kali ---");

            // Contoh 1: Bilangan bulat
            Kali(5, 4, 2);

            // Contoh 2: Bilangan desimal
            Kali(10.5, 2.0, 3.5);

            // Contoh 3: Dengan nilai negatif
            Kali(-3, 5, 2);

            Console.ReadKey(); // Agar jendela konsol tidak langsung tertutup
        }
    }
}
