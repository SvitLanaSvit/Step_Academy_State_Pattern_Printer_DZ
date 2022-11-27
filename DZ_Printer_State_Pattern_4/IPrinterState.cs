using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Printer_State_Pattern_4
{
    public interface IPrinterState
    {
        void TurnOn(Printer printer);
        void TurnOff(Printer printer);
        void Print(Printer printer);
        void FillWithPaper(Printer printer);
    }
}
