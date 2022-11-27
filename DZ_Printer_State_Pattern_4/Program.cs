using DZ_Printer_State_Pattern_4;

Printer printer = new Printer(new PrinterTurnOffState());
printer.TurnOn();
printer.TurnOn();
printer.Print();
printer.Print();
printer.TurnOff();
printer.TurnOn();
printer.FillWithPaper();
printer.FillWithPaper();
printer.FillWithPaper();
printer.Print();
printer.FillWithPaper();
printer.Print();
printer.FillWithPaper();
printer.Print();
printer.Print();
printer.Print();
printer.Print();
printer.Print();
printer.Print();
printer.TurnOff();
printer.Print();
printer.FillWithPaper();

Console.ReadLine();