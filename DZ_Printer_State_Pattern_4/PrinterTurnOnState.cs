using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Printer_State_Pattern_4
{
    public class PrinterTurnOnState : IPrinterState
    {
        public void FillWithPaper(Printer printer)
        {
            Console.WriteLine("The printer fills with paper.");
            printer.State = new PrinterPaperRunOutState();
        }

        public void Print(Printer printer)
        {
            Console.WriteLine("The printer prints.");
            printer.State = new PrinterPrintState();
        }

        public void TurnOff(Printer printer)
        {
            Console.WriteLine("The printer is off.");
            printer.State = new PrinterTurnOffState();
        }

        public void TurnOn(Printer printer)
        {
            Console.WriteLine("The printer waits a task.");
            printer.State = new PrinterWaitState();
        }
    }
}
