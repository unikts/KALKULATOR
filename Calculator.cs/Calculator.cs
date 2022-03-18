using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("|============================|");
            Console.WriteLine("|    Pilih Menu Kalkulator   |");
            Console.WriteLine("|============================|");
            Console.WriteLine("|        1. Penambahan       |");
            Console.WriteLine("|        2. Pengurangan      |");
            Console.WriteLine("|        3. Perkalian        |");
            Console.WriteLine("|        4. Pembagian        |");
            Console.WriteLine("|============================|");

            Console.Write("Inputkan nomor menu [1..4]: ");
            int menu = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inputkan nilai a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    {
                        Console.WriteLine($"Hasil Penambahan: {a} + {b} = " + (a + b));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Hasil Pengurangan: {a} - {b} = " + (a - b));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"Hasil Perkalian: {a} * {b} = " + (a * b));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine($"Hasil Pembagian: {a} / {b} = " + (a / b));
                        break;
                    }
                default:
                    {
                    Console.WriteLine("Maaf Menu yang Anda Pilih Tidak Tersedia!");
                    break;
                    }
            }
            Console.WriteLine("\nTekan Sembarang Key Untuk Keluar");
            Console.ReadKey();
        }
    }
}