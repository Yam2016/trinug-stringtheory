using System;

namespace StringTheory
{
    internal class FromString
    {
        internal void Numbers()
        {
            var quantity = int.Parse("97");
            Console.WriteLine(quantity + 3);
            if (int.TryParse("giraffe", out int value))
                Console.WriteLine($"Value: {value}");
            else
                Console.WriteLine("Unable to parse");
        }

        internal void Dates()
        {
            var stamp = DateTime.Parse("01/01/2020");
            Console.WriteLine(stamp.AddDays(2));
            if (DateTime.TryParse("02/02/2020", out DateTime feb))
                Console.WriteLine(feb.AddDays(3));
            else
                Console.WriteLine("Unable to parse");
        }
    }
}
