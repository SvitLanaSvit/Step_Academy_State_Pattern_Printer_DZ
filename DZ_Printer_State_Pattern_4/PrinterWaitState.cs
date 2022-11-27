using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Printer_State_Pattern_4
{
    public class PrinterWaitState : IPrinterState
    {
        public void FillWithPaper(Printer printer)
        {
            Console.WriteLine("The printer fills with paper. Wait.");
        }

        public void Print(Printer printer)
        {
            Console.WriteLine("The printer received the task. Printing is in progress.");
            printer.State = new PrinterPrintState();
        }

        public void TurnOff(Printer printer)
        {
            Console.WriteLine("The printer is off.");
            printer.State = new PrinterTurnOffState();
        }

        public void TurnOn(Printer printer)
        {
            Console.WriteLine("The printer is already on.");
            printer.State = new PrinterTurnOnState();
        }
    }
}
