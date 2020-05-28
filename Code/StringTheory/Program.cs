using System;
using OtherProject;

namespace StringTheory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var definingFeature = new DefiningFeature();
            definingFeature.Go9();
            var theConstant = OtherClass.TheConstant;
            var otherClass = new OtherProject.OtherClass();
            otherClass.DoStuff();
            otherClass.DoStuff(theConstant);
            var creatingNewStrings = new CreatingNewStrings();
            creatingNewStrings.Backslashing();
            Console.WriteLine();
            creatingNewStrings.NewLines();
            Console.WriteLine();
            creatingNewStrings.VerbatimQuote();
            Console.WriteLine();
            creatingNewStrings.OpenToInterpolation();
            Console.WriteLine();
            creatingNewStrings.PrintItemList(new string[] { "apple", "banana", "orange" });
            Console.WriteLine();
            creatingNewStrings.PrintUserInfo(new User()
            {
                FirstName = "John",
                LastName = "Smith",
                StartDate = DateTime.UtcNow
            });
            Console.WriteLine();
            creatingNewStrings.AnOldFormat();
            Console.WriteLine();
            var stringDot = new StringDot();
            stringDot.Concat();
            Console.WriteLine();
            stringDot.Join1();
            Console.WriteLine();
            stringDot.Join2(new string[] { "Romeo", "Juliet", "Mercutio", "Tybalt" });
            Console.WriteLine();
            stringDot.AnArrayOfCharacters();
            Console.WriteLine();
            stringDot.CharacterAssessment();
            Console.WriteLine();
            stringDot.AskingQuestions();
            Console.WriteLine();
            stringDot.Trimming();
            Console.WriteLine();
            stringDot.Padding();
            Console.WriteLine();
            stringDot.Casing();
            Console.WriteLine();
            stringDot.Replacement();
            Console.WriteLine();
            stringDot.Removal();
            Console.WriteLine();
            stringDot.LetsSplit();
            Console.WriteLine();
            var looping = new Looping();
            looping.StartLooping();
            Console.WriteLine();
            var goingToString = new GoingToString();
            goingToString.User();
            Console.WriteLine();
            goingToString.Numbers();
            Console.WriteLine();
            goingToString.Dates();
            Console.WriteLine();
            goingToString.Guids();
            var fromString = new FromString();
            Console.WriteLine();
            fromString.Numbers();
            Console.WriteLine();
            fromString.Dates();
            Console.WriteLine();
            var multilineExample = new MultilineExample();
            multilineExample.Go();
            Console.WriteLine();
            var builtInHelpers = new BuiltInHelpers();
            builtInHelpers.Pathing();
            Console.WriteLine();
            builtInHelpers.Html();
            Console.WriteLine();
            builtInHelpers.Base64();
            Console.WriteLine();
            var widgetExample = new WidgetExample();
            widgetExample.Go();
        }
    }
}
