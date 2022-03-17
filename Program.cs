using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";
            int a, b, menu;
            Console.WriteLine("\n+---------------------------------------+\n");
            Console.WriteLine("\tPILIH MENU KALKULATOR");
            Console.WriteLine("\n+---------------------------------------+\n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("\n+---------------------------------------+\n");
            Console.WriteLine("Input Menu Pilihan [ 1 s.d 4 ] : ");
            menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n+---------------------------------------+\n");
            switch (menu)
            {
                case 1 :
                    Console.WriteLine("Inputkan Nilai a : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Inputkan Nilai b : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b ));
                    break;
                case 2:
                    Console.WriteLine("Inputkan Nilai a : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Inputkan Nilai b : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine("Inputkan Nilai a : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Inputkan Nilai b : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + Perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine("Inputkan Nilai a : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Inputkan Nilai b : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + Pembagian(a, b));
                    break;
                default:
                    Console.WriteLine("Maaf, Menu yang anda pilih tidak tersedia.");
                    break;
            }
            Console.WriteLine("\n+---------------------------------------+\n");
            Console.WriteLine(" # Tekan sembarang key untuk keluar  # ");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
