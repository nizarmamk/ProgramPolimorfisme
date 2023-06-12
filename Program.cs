using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfisme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer = null;
            Console.WriteLine("Select a Printer : ");
            Console.WriteLine("1. Espon");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Choose Printer Number [1...3] : ");

            int printNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (printNum == 1)
            {
                printer = new Epson();
            }
            else if (printNum == 2)
            {
                printer = new Canon();
            }
            else if (printNum == 3)
            {
                printer = new LaserJet();
            }
            else
            {
                Console.WriteLine("Wrong input, please try again!\n");
            }

            if (printer != null)
            {
                printer.Show();
                printer.Print();
            }

            Console.ReadKey();
        }
    }
}
