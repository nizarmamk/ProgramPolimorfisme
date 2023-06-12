using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfisme
{
    public class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("PrinterWindows Display Dimension : 9.5*12");
        }

        public virtual void Print()
        {
            Console.WriteLine();
            Console.WriteLine("PrinterWindows is printing...");
        }
    }

    // Child Class 1
    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson Display Dimension : 10*11");
        }

        public override void Print()
        {
            Console.WriteLine("Epson Printer is printing...");
        }
    }

    // Child Class 2
    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon Display Dimension : 9.5*12");
        }

        public override void Print()
        {
            Console.WriteLine("Canon Printer is printing...");
        }
    }

    // Child Class 3
    public class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet Display Dimension : 12*12");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet Printer is printing...");
        }
    }
}
