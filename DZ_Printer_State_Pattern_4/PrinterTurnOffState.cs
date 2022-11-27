using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Printer_State_Pattern_4
{
    public class PrinterTurnOffState : IPrinterState
    {
        public void FillWithPaper(Printer printer)
        {
            Console.WriteLine("The printer is off. Turn on.");
        }

        public void Print(Printer printer)
        {
            Console.WriteLine("The printer cann`t print. It is off. Turn on.");
        }

        public void TurnOff(Printer printer)
        {
            Console.WriteLine("The printer is already off.");
        }

        public void TurnOn(Printer printer)
        {
            Console.WriteLine("The printer is on.");
            printer.State = new PrinterTurnOnState();
        }
    }
}
