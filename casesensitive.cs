using System;

namespace EasyWord
{
    public class TranslationChecker
    {
        /// <summary>
        /// Vergleicht die Benutzereingabe mit der korrekten Übersetzung.
        /// </summary>
        /// <param name="userInput">Eingabe des Benutzers</param>
        /// <param name="correctTranslation">Richtige Übersetzung</param>
        /// <param name="caseSensitive">True = beachtet Groß-/Kleinschreibung, False = ignoriert sie</param>
        /// <returns>True, wenn die Eingabe korrekt ist, sonst False</returns>
        public static bool CheckTranslation(string userInput, string correctTranslation, bool caseSensitive = true)
        {
            if (!caseSensitive)
            {
                userInput = userInput.ToLower();
                correctTranslation = correctTranslation.ToLower();
            }

            return userInput == correctTranslation;
        }

        // Beispiel
        public static void Main(string[] args)
        {
            string correctTranslation = "Apple";

            // Fall 1: Groß-/Kleinschreibung beachten
            Console.WriteLine(CheckTranslation("apple", correctTranslation, caseSensitive: true));  // False

            // Fall 2: Groß-/Kleinschreibung ignorieren
            Console.WriteLine(CheckTranslation("apple", correctTranslation, caseSensitive: false)); // True
        }
    }
}
