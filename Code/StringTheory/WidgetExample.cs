using System;

namespace StringTheory
{
    internal class WidgetExample
    {
        internal void Go()
        {
            var alpha = new WidgetIdentifier(7392, DateTime.Parse("03/15/2020"), "DH7B", 1);
            var alphaLabel = alpha.GenerateLabel();
            Console.WriteLine(alphaLabel);
            var bravo = WidgetIdentifier.Parse(alphaLabel);
            var bravoLabel = bravo.GenerateLabel();
            Console.WriteLine(bravoLabel);
            if (bravoLabel != alphaLabel) throw new InvalidOperationException();
            Console.WriteLine();
            var charlie = new WidgetIdentifier(4018, DateTime.Parse("11/25/2020"), "D98K", 1);
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine(charlie.GenerateLabel());
                charlie.IncrementSequenceNumber();
            }
        }
    }
}
