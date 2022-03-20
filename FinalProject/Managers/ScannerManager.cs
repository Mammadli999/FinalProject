using FinalProject.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Manager
{
    public static class ScannerManager
    {
        public static int ReadInteger(string caption)
        {
        l1:

            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (!int.TryParse(Console.ReadLine(), out int value))
            {
                PrintError("Duzgun Muelumat Deyil,Yeniden Cehd Edin");
                goto l1;
            }

            Console.ResetColor();
            return value;
        }

        public static double ReadDouble(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (!double.TryParse(Console.ReadLine(), out double value))
            {
                PrintError("Duzgun Muelumat Deyil,Yeniden Cehd Edin");
                goto l1;
            }

            Console.ResetColor();
            return value;
        }

        public static string ReadString(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string value = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(value))
            {
                PrintError("Duzgun Muelumat Deyil,Yeniden Cehd Edin");
                goto l1;
            }

            Console.ResetColor();
            return value;
        }

        public static Menu ReadMenu(string caption)
        {
        l1:
            Console.Write(caption);

            if (!Enum.TryParse(Console.ReadLine(), out Menu m))
            {
                PrintError("Menudan Secin");
                goto l1;
            }
            Console.ResetColor();
            return m;
        }

        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.Beep(5000, 1000);
            Console.ResetColor();
        }

        public static DateTime ReadDate(string caption)
        {
        l1:
            Console.Write($"{caption} [yyyy]");

            if (!DateTime.TryParseExact(Console.ReadLine(), "yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime value))
            {
                PrintError("Duzgun Muelumat Deyil,Yeniden Cehd Edin");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }

        public static FuelType FuelType(string caption)
        {
        l1:
            Console.Write(caption);

            if (!Enum.TryParse(Console.ReadLine(), out FuelType m))
            {
                PrintError("Menudan Secin");
                goto l1;
            }
            Console.ResetColor();
            return m;
        }

    }
}
