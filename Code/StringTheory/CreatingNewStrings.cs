using System;

namespace StringTheory
{
    internal class CreatingNewStrings
    {
        internal void Backslashing()
        {
            var tabbing = "Oranges:\t7";
            Console.WriteLine(tabbing);
            var speech = "Quote: \"Never was so much owed by so many to so few\" - Winston Churchill";
            Console.WriteLine(speech);
            var path = "C:\\Users\\wchurchill\\Documents\\Speech.txt";
            Console.WriteLine(path);
            var price = "Price: \u00A34.57";
            Console.WriteLine(price);
            var twolines = "Line1\r\nLine2";
            Console.WriteLine(twolines);
        }

        internal void NewLines()
        {
            var twolines = "Line1\r\nLine2";
            Console.WriteLine(twolines);
            var verbatim = @"Line1
Line2";
            Console.WriteLine(verbatim);
            var twoLinesConcatenated = "Line1" + Environment.NewLine + "Line2";
            Console.WriteLine(twoLinesConcatenated);
        }

        internal void VerbatimQuote()
        {
            var speech = @"Quote:
""Never was so much owed by so many to so few""
                        - Winston Churchill";
            Console.WriteLine(speech);
        }

        internal void OpenToInterpolation()
        {
            PriceBefore("apples", 3, 3.49m);
            PriceAfter("apples", 3, 3.49m);
        }

        private void PriceBefore(string product, int quantity, decimal price)
        {
            Console.WriteLine("The price for " + quantity + " " + product + " is \u00A3" + price + ".");
        }

        private void PriceAfter(string product, int quantity, decimal price)
        {
            Console.WriteLine($"The price for {quantity} {product} is \u00A3{price}.");
        }

        internal void PrintItemList(string[] items)
        {
            for (var i = 0; i < items.Length; i++)
                Console.WriteLine($"Item {i + 1}: {items[i]}");
        }

        internal void PrintUserInfo(User user)
        {
            Console.WriteLine($"User Info: {user.GenerateFullName()} started on {user.StartDate}");
        }

        internal void AnOldFormat()
        {
            PriceWithFormat("apples", 3, 3.49m);
        }

        private void PriceWithFormat(string product, int quantity, decimal price)
        {
            Console.WriteLine(string.Format("The price for {0} {1} is \u00A3{2}.", quantity, product, price));
        }
    }
}
