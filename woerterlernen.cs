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

        /// <summary>
        /// Startet den Lernmodus in beide Richtungen (Deutsch -> Englisch oder Englisch -> Deutsch).
        /// Zeigt bei falscher Eingabe die korrekte Übersetzung an.
        /// </summary>
        public static void StartLearning(string germanWord, string englishWord, bool isGermanToEnglish, bool caseSensitive = true)
        {
            Console.WriteLine(isGermanToEnglish ? $"Übersetze ins Englische: {germanWord}" : $"Übersetze ins Deutsche: {englishWord}");
            string userInput = Console.ReadLine();

            bool isCorrect = CheckTranslation(userInput, isGermanToEnglish ? englishWord : germanWord, caseSensitive);

            if (isCorrect)
            {
                Console.WriteLine("Richtig!");
            }
            else
            {
                Console.WriteLine($"Falsch. Die korrekte Übersetzung ist: {(isGermanToEnglish ? englishWord : germanWord)}");
                Console.WriteLine("Versuche es erneut:");
                userInput = Console.ReadLine();

                if (CheckTranslation(userInput, isGermanToEnglish ? englishWord : germanWord, caseSensitive))
                {
                    Console.WriteLine("Jetzt richtig!");
                }
                else
                {
                    Console.WriteLine($"Erneut falsch. Die korrekte Übersetzung bleibt: {(isGermanToEnglish ? englishWord : germanWord)}");
                }
            }
        }

        // Beispiel
        public static void Main(string[] args)
        {
            string germanWord = "Apfel";
            string englishWord = "Apple";

            Console.WriteLine("Wähle den Modus: 1 = Deutsch -> Englisch, 2 = Englisch -> Deutsch");
            int mode = int.Parse(Console.ReadLine());

            bool isGermanToEnglish = mode == 1;

            StartLearning(germanWord, englishWord, isGermanToEnglish, caseSensitive: false);
        }
    }
}