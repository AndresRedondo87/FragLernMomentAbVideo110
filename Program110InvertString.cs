using System;

namespace FragLernMoment_1_InvertString
{
    // Frage von Zaidi: Bitte erkläre mir die Logik der Methode!
    // Selber angepasst - Bedienung, Logik bleibt genau gleich
    class Program
    {

        static void Main(string[] args)     // angepasste Bedienung
        {
            string text;
            do
            {

                Console.WriteLine("Schreiben Sie einen Text um es zu invertieren[ENTER zu beenden]: ");
                text = Console.ReadLine();
                string invertText = Invert(text);
                Console.WriteLine($"Der eingegebener Text:\n" + text + " \n-Invertiert sieht so aus: \n" + invertText + Environment.NewLine + Environment.NewLine);
            } while (!String.IsNullOrEmpty(text));
        }


        //Methode to invert text
        static string Invert(string text)
        {
            /// Zaidi´s Loesung
            // erzeugt temporäres Feld von chars - wahrscheinlich um das resultat zu speichern
            //char[] myChar = new char[text.Length];

            //for (int i = 1; i <= text.Length; i++)
            //{
            //    myChar[text.Length - i] = text[i - 1];
            //}

            //return new string(myChar);

            // Lehrer´s Loesung - er kennt Viele Klassen und Methoden, das macht alles einfacher.
            char[] myChar = text.ToCharArray();
            Array.Reverse(myChar);

            return new string(myChar);
        }
    }
}