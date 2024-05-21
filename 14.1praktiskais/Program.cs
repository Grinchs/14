using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _14._1praktiskais
{
    class Program
    {

        // try bloks definē kodu, kurā var rasties izņēmumi.
        // catch bloks tiek izpildīts, ja try blokā notiek izņēmums,
        // un tas ļauj programmētājam apstrādāt un reaģēt uz šādām kļūdām.


        static void Main(string[] args)
        {
            try
            {
                // Izņēmums: dalīšana ar 0
                int a = 10;
                int b = 0;
                int result = a / b;
                Console.WriteLine($"Rezultāts: {result}"); // Šī rindiņa netiks izpildīta

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Izņēmums: {ex.GetType().Name}");
                Console.WriteLine($"Kļūdas paziņojums: {ex.Message}");
            }

            try
            {
                // Izņēmums: nepareiza konvertēšana
                string str = "abc";
                int num = int.Parse(str);
                Console.WriteLine($"Pārveidots skaitlis: {num}"); // Šī rindiņa netiks izpildīta
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Izņēmums: {ex.GetType().Name}");
                Console.WriteLine($"Kļūdas paziņojums: {ex.Message}");
            }

            try
            {
                // Izņēmums: neeksistējošs fails
                string[] lines = System.IO.File.ReadAllLines("neeksistejoss_fails.txt");
                Console.WriteLine($"Pirmā rindiņa: {lines[0]}"); // Šī rindiņa netiks izpildīta
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine($"Izņēmums: {ex.GetType().Name}");
                Console.WriteLine($"Kļūdas paziņojums: {ex.Message}");
            }

            try
            {
                // Izņēmums: masīva vai simbolrindas indekss ārpus robežām
                int[] arr = { 1, 2, 3 };
                Console.WriteLine($"4. elements: {arr[3]}"); // Šī rindiņa netiks izpildīta
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Izņēmums: {ex.GetType().Name}");
                Console.WriteLine($"Kļūdas paziņojums: {ex.Message}");
            }
        }
    }
}
