﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Printer_State_Pattern_4
{
    public class PrinterPaperRunOutState : IPrinterState
    {
        public void FillWithPaper(Printer printer)
        {
            Console.WriteLine("The printer filled with paper.");
            printer.State = new PrinterWaitState();
        }
    

        public void Print(Printer printer)
        {
            Console.WriteLine("The printer is leer with paper!!!");
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
