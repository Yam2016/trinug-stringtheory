using System;
using System.Collections.Generic;

namespace StringTheory
{
    internal class StringDot
    {
        internal void Concat()
        {
            var user = new User()
            {
                FirstName = "John",
                LastName = "Smith",
                StartDate = DateTime.UtcNow
            };
            var numbers = new int[] { 1, 2, 3, 5, 7, 11, 13, 17 };
            var line1 = string.Concat("Romeo", "&", "Juliet");
            var line2 = string.Concat(new string[] { "Romeo", "&", "Juliet" });
            var line3 = string.Concat(new string[] { "A", "rose", "by", "any", "other", "name" });
            var line4 = string.Concat("User: ", user);
            var line5 = string.Concat(numbers);
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);
            Console.WriteLine(line4);
            Console.WriteLine(line5);
        }

        internal void Join1()
        {
            var line1 = "Romeo & Juliet";
            var line2 = string.Join(" ", new string[] { "Romeo", "&", "Juliet" });
            var line3 = string.Join(" ", new string[] { "A", "rose", "by", "any", "other", "name" });
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);
            var numbers = new int[] { 1, 2, 3, 5, 7, 11, 13, 17 };
            Console.WriteLine(string.Join(",", numbers));
        }

        internal void Join2(IEnumerable<string> names)
        {
            Console.WriteLine(string.Join(", ", names));
        }

        internal void AnArrayOfCharacters()
        {
            const string john = "John Smith";
            foreach (var character in john)
                Console.WriteLine(character);
            Console.WriteLine("--------");
            var characters = john.ToCharArray();
            foreach (var character in characters)
                Console.WriteLine(character);
            var letters = new char[] { 'A', 'l', 'i', 'c', 'e' };
            var alice = new string(letters);
            Console.WriteLine("--------");
            Console.WriteLine(alice);
            Console.WriteLine(sizeof(char));
        }

        internal void CharacterAssessment()
        {
            const string line = "Item 1: Apple!";
            var characters = line.ToCharArray();
            foreach (var c in characters)
            {
                Console.Write($"Character {c} is:");
                if (char.IsControl(c)) Console.Write(" Control");
                if (char.IsDigit(c)) Console.Write(" Digit"); // Subset of Number
                if (char.IsLetter(c)) Console.Write(" Letter");
                if (char.IsNumber(c)) Console.Write(" Number"); // Lots of Numbers
                if (char.IsPunctuation(c)) Console.Write(" Punctuation");
                if (char.IsSeparator(c)) Console.Write(" Separator");
                if (char.IsWhiteSpace(c)) Console.Write(" Whitespace");
                Console.WriteLine();
            }
        }

        internal void AskingQuestions()
        {
            const string snippet = @"Do not go gentle into that good night.  Rage, rage against the dying of the light.";
            if (string.IsNullOrEmpty(snippet)) Console.WriteLine("IsNullOrEmpty");
            if (string.IsNullOrWhiteSpace(snippet)) Console.WriteLine("IsNullOrWhiteSpace");
            if (snippet.Contains("rage")) Console.WriteLine("Contains rage");
            if (snippet.Contains("do")) Console.WriteLine("Contains do");
            if (snippet.Contains("do", StringComparison.OrdinalIgnoreCase)) Console.WriteLine("Contains do (case ignored)");
            Console.WriteLine(snippet.IndexOf("a"));
            Console.WriteLine(snippet.IndexOf("b"));
            Console.WriteLine(snippet.IndexOf("O"));
            Console.WriteLine(snippet.LastIndexOf("a"));
            Console.WriteLine($"Length: {snippet.Length} characters");
            if (snippet.StartsWith("Do")) Console.WriteLine("Starts with Do");
            if (snippet.EndsWith(".")) Console.WriteLine("Ends with .");
        }

        internal void Trimming()
        {
            const string john = " John Smith ";
            Console.WriteLine($"|{john.Trim()}|");
            Console.WriteLine($"|{john.TrimStart()}|");
            Console.WriteLine($"|{john.TrimEnd()}|");
            Console.WriteLine($"|{john.Trim(' ')}|");
            Console.WriteLine($"|{john.TrimStart('J')}|");
            Console.WriteLine($"|{john.TrimEnd('h')}|");
            Console.WriteLine($"|{john.Trim(' ')}|");
            Console.WriteLine($"|{john.TrimStart(new char[] { 'J', ' ', 'o' })}|");
            Console.WriteLine($"|{john.TrimEnd(new char[] { 't', 'h', ' ' })}|");
        }

        internal void Padding()
        {
            const int quantity = 29;
            var quantityStringWithSpaces = quantity.ToString().PadLeft(4);
            Console.WriteLine($"Quantity:{quantityStringWithSpaces}");
            var quantityStringWithExclamations = quantity.ToString().PadLeft(4, '!');
            Console.WriteLine($"Quantity:{quantityStringWithExclamations}");
        }

        internal void Casing()
        {
            const string alice = "Alice";
            Console.WriteLine(alice.ToUpper());
            Console.WriteLine(alice.ToLower());
        }

        internal void Replacement()
        {
            const string phone = "1-800-123-4567";
            Console.WriteLine(phone.Replace('-', ' '));
            Console.WriteLine(phone.Replace("-", string.Empty));
        }

        internal void Removal()
        {
            const string sentence = "This is important.  But none of this is important.";
            var important = sentence.Remove(sentence.IndexOf('.') + 1);
            Console.WriteLine(important);
            const string mostlyGoodData = "Good-Data-Here|Tons of bad data that could be any length|More-Good-Data";
            var firstGoodPipe = mostlyGoodData.IndexOf('|');
            var lastGoodPipe = mostlyGoodData.LastIndexOf('|');
            var goodDataOnly = mostlyGoodData.Remove(firstGoodPipe, lastGoodPipe - firstGoodPipe);
            Console.WriteLine(goodDataOnly);
            const string mostlyBadData = "Bad-Data-Here|Tons of good data that could be any length|More-Bad-Data";
            var firstBadPipe = mostlyBadData.IndexOf('|');
            var lastBadPipe = mostlyBadData.LastIndexOf('|');
            var onlyGoodDataAgain = mostlyBadData.Substring(firstBadPipe + 1, lastBadPipe - firstBadPipe - 1);
            Console.WriteLine(onlyGoodDataAgain);
        }

        internal void LetsSplit()
        {
            const string numbers = "1,2,3,5,7,11,13,17";
            var numbersSplit = numbers.Split(',');
            foreach (var n in numbersSplit)
                Console.WriteLine(n);
            Console.WriteLine("--------");
            const string partialData = "1,2,3,,7,11,,17";
            var partialDataSplit = partialData.Split(',');
            foreach (var n in partialDataSplit)
                Console.WriteLine(n);
            Console.WriteLine("--------");
            var partialDataSplitWithoutBlanks = partialData.Split(',', StringSplitOptions.RemoveEmptyEntries);
            foreach (var n in partialDataSplitWithoutBlanks)
                Console.WriteLine(n);
        }
    }
}
