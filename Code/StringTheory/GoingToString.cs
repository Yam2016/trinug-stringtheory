using System;

namespace StringTheory
{
    internal class GoingToString
    {
        internal void User()
        {
            var user = new User()
            {
                FirstName = "John",
                LastName = "Smith",
                StartDate = DateTime.UtcNow
            };
            var line = string.Concat("User: ", user);
            Console.WriteLine(line);
        }

        internal void Numbers()
        {
            const decimal price = 1346.79m;
            const int color = 16_000_000;
            const decimal lowPrice = 0.25m;
            Console.WriteLine(price);
            Console.WriteLine(price.ToString());
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("E"));
            Console.WriteLine(price.ToString("N"));
            Console.WriteLine(price.ToString("P"));
            Console.WriteLine(color.ToString("X"));
            Console.WriteLine(lowPrice.ToString());
            Console.WriteLine(lowPrice.ToString("####00.00"));
        }

        internal void Dates()
        {
            var now = DateTime.UtcNow;
            Console.WriteLine(now);
            Console.WriteLine(now.ToString("d"));
            Console.WriteLine(now.ToString("D"));
            Console.WriteLine(now.ToString("f"));
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine(now.ToString("t"));
            Console.WriteLine(now.ToString("T"));
            Console.WriteLine(now.ToString("Y"));
            Console.WriteLine(now.ToString("o"));
            Console.WriteLine(now.ToString("yyyy|MM|dd=HH:mm:ss"));
        }

        internal void Guids()
        {
            var guid = Guid.NewGuid();
            Console.WriteLine(guid);
            Console.WriteLine(guid.ToString("N"));
            Console.WriteLine(guid.ToString("D"));
            Console.WriteLine(guid.ToString("B"));
            Console.WriteLine(guid.ToString("P"));
            Console.WriteLine(guid.ToString("X"));
        }
    }
}
