using System;

namespace FragLernMoment_2_AddiereZahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            string ersteZahlAlsString;
            string zweiteZahlAlsString;
            double ersteZahl;
            double zweiteZahl;
            double resultat;

            /// Visual Studio (2017) Tipps und tricks 
            /// -> Gehe zu definition ->beim methode aufruf seine definition direkt springen. [F12]
            /// -> Alle Verweise suchen -> sehen alle aufrufe von Variablen,Methoden,Klassen..[SHIFT(UMSCHALT) + F12]
            ///    Es kann limitiert auf dieses aktuelles Dok., aktuelles Projekt, geöffnete Doks... begrentzt aufgerufen sein
            ///   ...
            /// ->Code ausschnitte: cw für Console.Writeline zum Beispiel direkt geschrieben zu kriegen.
            ///   Code Snippets ist auch seine name. Symboll ist so ein leeres Quadrat, mit zweimal tab werden ausgefuehrt
            ///   http://bit.ly/2U9EqKf
            ///   ...
            ///   TABULATIONEN bzw Indentation wird automatisch standarisiert mit 
            ///   STRG+K, STRG+D
            ///   bzw STRG+K,D
            ///   .
            ///   Kommentieren / unkommentieren via Buttons oben.
            ///   STRG+K,C     /  STRG+K,U 



            // Zahlen vom Benutzer eingeben lassen
            Console.Write("Bitte gib die erste Zahl ein: ");
            ersteZahlAlsString = Console.ReadLine();
            Console.Write("Bitte gib die zweite Zahl ein: ");
            zweiteZahlAlsString = Console.ReadLine();

            // Zahlen konvertieren
            ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            // Methode aufrufen und nach der Ausführung das Resultat übernehmen
            resultat = Addiere(ersteZahl, zweiteZahl);

            // Ausgabe
            Console.WriteLine("Die Summe der beiden eingegebenen Zahlen ist: " + resultat);

            // Benutzer Enter drücken lassen bevor Programm beendet wird
            Console.ReadLine();
        }

        static double Addiere(double ersterSummand, double zweiterSummand) //Verweise und Aufrufhierarchie koennen dafuer sehr Hilfreich sein
        {
            // Eigentliche Berechnung
            double summe = ersterSummand + zweiterSummand;

            // Rückgabewert
            return summe;
        }

        /// mit LEGO Steie geklaert. THEORIE STACK
        /// ganz am Anfang haben wir ganz unten ein Stein, der Stack ist.
        /// Beim Konsolenanwendung Starten wird der StackFrame dadrauf angelegt.
        /// es ist wie ein Kontainer wo Informationen drinne stehen. Der Stein symbolisiert diese Kontainer
        ///  Alles was in die Methoden passiert, passiert in diese Kontainer drin, bzw auf den StackFrame drauf.
        ///  das heisst in Methode Main werden speicherplaetze für Variablen gespeichert (im Beispiel schauen wir die Zahlen und resultat).
        ///  da werden die werte zuweisugen auch erfolgen, z.B. die Werte eingabe 2 und 5 fuer die Benutzer Eingaben:
        ///  ---
        ///  [leer Resultat]
        ///  [5]
        ///  [2]
        ///  [StackFrame]
        ///  [HauptStein]
        ///  
        ///  Dann kommt die addiere Methode: 
        ///  [AddiereMethode]
        ///  [leer Resultat]
        ///  [5]
        ///  [2]
        ///  [StackFrame]
        ///  [HauptStein]
        ///  
        ///  Dann merkt es sich wo wir waren als wir die MEthode aufgerufen haben(Linie 26 in Beispiel) 
        ///  [Merken, wenn Addieren Methode fertig ist, weiter ab Linie 26 weitermachen]
        ///  [AddiereMethode]
        ///  [leer Resultat]
        ///  [5]
        ///  [2]
        ///  [StackFrame]
        ///  [HauptStein]
        ///  
        ///  Dann die Methode nimmt die Parameter auf den Stack drauf, erstmal leer und reserviert Speicherplatz für die beide
        ///  // und scheinbar auch fuer Ihre return wert.
        ///  [leer Resultat]
        ///  [leer Parameter ersterSummand]
        ///  [leer Parameter zweiterSummand]
        ///  [Merken, wenn Addieren Methode fertig ist, weiter ab Linie 26 weitermachen]
        ///  [AddiereMethode]
        ///  [leer Resultat]
        ///  [5]
        ///  [2]
        ///  [StackFrame]
        ///  [HauptStein]
        ///  
        ///  Dann die Methode kopiert die werte fuer die Parameter auf den neuen Speicherbereich(Stack-Steine)
        ///  Die aendern nichts von der originale 5 und 2,seine Werte werden nur einfach drueberkopiert aus Main Methode
        ///  [leer Resultat]
        ///  [5]
        ///  [2]
        ///  [Merken, wenn Addieren Methode fertig ist, weiter ab Linie 26 weitermachen]
        ///  [AddiereMethode]
        ///  [leer Resultat]
        ///  [5]
        ///  [2]
        ///  [StackFrame]
        ///  [HauptStein]
        ///  
        ///  Dann geht es richtig in die Methode rein. Da ist die summe deklariert, so es bekommt ein euen Speicherbereich(Stack-Steine)
        ///  [leer - summe]
        ///  [5]
        ///  [2]
        ///  [Merken, wenn Addieren Methode fertig ist, weiter ab Linie 26 weitermachen]
        ///  [AddiereMethode]
        ///  [leer Resultat]
        ///  [5]
        ///  [2]
        ///  [StackFrame]
        ///  [HauptStein]
        ///  
        ///  Die Summe wird berechnet und auf summe gespeichert: 2+5 = 7
        ///  [7]
        ///  [5]
        ///  [2]
        ///  [Merken, wenn Addieren Methode fertig ist, weiter ab Linie 26 weitermachen]
        ///  [AddiereMethode]
        ///  [leer Resultat]
        ///  [5]
        ///  [2]
        ///  [StackFrame]
        ///  [HauptStein]
        ///  
        ///  Die Summe wird berechnet und auf summe gespeichert: 2+5 = 7
        ///  eigentlich nur mit den Daten auf den letzten StackFrame(so zu sagen von addiereMethode Stein,nach oben.
        ///  Nicht mit den daten aus Main die da drunter stehen, sie sind hierher ganz unabhaengig 
        ///  Die Summe ist fertig so diese StackFrame muss abgebaut werden.
        ///  Sie weisst zwei sachen:
        ///  1- sie muss zurueck in Linie 26 weitermachen
        ///  2- return, bzw den summe Wert zurueckgeben 
        ///  mit diese Info wird diese StackFrame komplett abgebaut
        ///  
        ///  [leer Resultat]
        ///  [5]
        ///  [2]
        ///  [StackFrame]
        ///  [HauptStein]
        ///  
        ///  Dann sehen wir wieder in die Linie 26 dass die lokale Variable resultat bekommt der Wert aus der return von unsere methode,
        ///  so wird es da zugewiesen.
        ///  
        ///  [7]
        ///  [5]
        ///  [2]
        ///  [StackFrame]
        ///  [HauptStein]
        ///  So haben wir schon den Resultat Wert in unsere Stack, aber das ganze StackFrame von Addiere Methode ist abgebaut.  
        ///  Wenn im Beispiel nochmal addieren aufgerufen würde, wurde es einfach nochmal genauso draufgesteckt (
        ///  [leer - summe]
        ///  [leer Parameter ersterSummand]
        ///  [leer Parameter zweiterSummand]
        ///  [Merken, wenn Addieren Methode fertig ist, weiter ab Linie 26 weitermachen]
        ///  [AddiereMethode]   //NOCHMAL
        ///  [7]
        ///  [5]
        ///  [2]
        ///  [StackFrame]
        ///  [HauptStein]
        ///  Das ist in unser Beispiel aber nicht, so...
        ///  [7]
        ///  [5]
        ///  [2]
        ///  [StackFrame]
        ///  [HauptStein]
        ///  Damit wurde dan den resultat in Main einfach ausgegeben.
        ///  Am Ende von Main wurde einfach alles abgebaut und Anwendung verschlossen.


    }
}