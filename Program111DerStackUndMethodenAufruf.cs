//using System;

//namespace FragLernMoment_2_AddiereZahlen
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string ersteZahlAlsString;
//            string zweiteZahlAlsString;
//            double ersteZahl;
//            double zweiteZahl;
//            double resultat;

//            // Zahlen vom Benutzer eingeben lassen
//            Console.Write("Bitte gib die erste Zahl ein: ");
//            ersteZahlAlsString = Console.ReadLine();
//            Console.Write("Bitte gib die zweite Zahl ein: ");
//            zweiteZahlAlsString = Console.ReadLine();

//            // Zahlen konvertieren
//            ersteZahl = Convert.ToDouble(ersteZahlAlsString);
//            zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

//            // Methode aufrufen und nach der Ausführung das Resultat übernehmen
//            resultat = Addiere(ersteZahl, zweiteZahl);

//            // Ausgabe
//            Console.WriteLine("Die Summe der beiden eingegebenen Zahlen ist: " + resultat);

//            // Benutzer Enter drücken lassen bevor Programm beendet wird
//            Console.ReadLine();
//        }

//        static double Addiere(double ersterSummand, double zweiterSummand)
//        {
//            // Eigentliche Berechnung
//            double summe = ersterSummand + zweiterSummand;

//            // Rückgabewert
//            return summe;
//        }
//    }
//}