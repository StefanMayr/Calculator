using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zeige Begrüßungstext an
            MyCalculatorClass calculator = new MyCalculatorClass();
            double Result = 0.0;

            // Erste Zahl eingeben => Funktion in Klasse InputHelper
            double Number1 = InputHelper.ReadDouble("Geben Sie die erste Zahl ein:");

            // Zweite Zahl eingeben => Funktion in Klasse InputHelper
            double Number2 = InputHelper.ReadDouble("Geben Sie die zweite Zahl ein:");

            // Zeige Auswahl an Berechnungen an 

            Console.WriteLine("Wählen Sie die gewünschte Rechnung aus: ");
            Console.WriteLine(calculator.SupportedOperations());
            // => Abfrage der Berechnungsmöglichkeiten von Calculator

            char operation = '+'; // TODO - read from console 

            // Berechnung eingeben (z.B. + oder Add, ...)

            //=> Funktion in Klasse InputHelper

            // Berechnung durchführen

            Result = calculator.Calculate(Number1, Number2, operation);

            // => Zahlen an Calculator geben und berechnen
            
            Console.WriteLine("Das Ergebnis ist: {0}",Result);
            
            // Berechnungsergebnis ausgeben


            // Ausgabe der letzten 5 Rechnungen

            Console.WriteLine("Die letzten 5 Ergebnisse waren: ");
            // => Abfrage der letzten 5 Ergebnisse


        }
    }
}

