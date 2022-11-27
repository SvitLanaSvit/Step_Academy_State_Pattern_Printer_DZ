using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Printer_State_Pattern_4
{
    public class Printer
    {
        public IPrinterState State { get; set; }

        public Printer(IPrinterState state) 
        { 
            State = state;
        }

        public void TurnOn()
        {
            State.TurnOn(this);
        }

        public void TurnOff()
        {
            State.TurnOff(this);
        }

        public void Print()
        {
            State.Print(this);
        }

        public void FillWithPaper()
        {
            State.FillWithPaper(this);
        }
    }
}
