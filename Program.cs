using System;

namespace FragLernMoment_1_InvertString
{
    // Frage von Zaidi: Bitte erkläre mir die Logik der Methode!
    // Selber angepasst - Bedienung, Logik bleibt genau gleich
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            do
            {

                Console.WriteLine("Schreiben Sie einen Text um es zu invertieren[ENTER zu beenden]: ");
                text = Console.ReadLine();
                string invertText = Invert(text);
                Console.WriteLine($"Der eingegebener Text:\n" + text + " \n-Invertiert sieht so aus: \n" + invertText);
            } while (!String.IsNullOrEmpty(text));
        }

        static void InvertThisText(string TextToInvert)     //in Methode geschoben angepasst
        {
            string name = TextToInvert;
            string invertName = Invert(name);
            Console.WriteLine(name + " - " + invertName);

            Console.ReadLine();

        }



        //Methode to invert text
        static string Invert(string text)
        {
            // erzeugt temporäres Feld von chars - wahrscheinlich um das resultat zu speichern
            char[] myChar = new char[text.Length];

            for (int i = 1; i <= text.Length; i++)
            {
                myChar[text.Length - i] = text[i - 1];
            }

            return new string(myChar);
        }
    }
}