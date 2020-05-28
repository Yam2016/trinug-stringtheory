using System;

namespace StringTheory
{
    internal class DefiningFeature
    {
        internal void Go1()
        {

            var quantityOfApples = 100;
            var quantityOfBananas = 1_000_000_000;
            var stringQuantityOfApples = "100";
            var stringQuantityOfBananas = "1_000_000_000";





            Process(quantityOfApples);
            Process(quantityOfBananas);
            Process(stringQuantityOfApples);
            Process(stringQuantityOfBananas);
        }

        internal void Go2()
        {

            var quantityOfApples = 100;
            var quantity = quantityOfApples;
            var stringQuantityOfApples = "100";
            var stringQuantity = stringQuantityOfApples;





            Process(quantityOfApples);
            Process(quantity);
            Process(stringQuantityOfApples);
            Process(stringQuantity);
        }

        internal void Go3()
        {
            var quantityOfApples = 100;
            quantityOfApples += 7;
            var stringQuantityOfApples = "100";
            stringQuantityOfApples += "7";





            Process(quantityOfApples);
            Process(stringQuantityOfApples);
        }

        internal void Go4()
        {
            const int quantityOfApples = 100;
            const string stringQuantityOfApples = "100";





            Process(quantityOfApples);
            Process(stringQuantityOfApples);
        }

        internal void Go9()
        {

            var quantityOfApples = 100;
            var quantityOfBananas = 1_000_000_000;

            var quantity = quantityOfApples;

            var stringQuantityOfApples = "100";
            var stringQuantityOfBananas = "1_000_000_000";

            var stringQuantity = stringQuantityOfApples;

            Process(quantityOfApples);
            Console.WriteLine(quantityOfApples);
            Process(quantityOfBananas);
            Console.WriteLine(quantityOfBananas);
            Process(quantity);
            Console.WriteLine(quantity);
            Process(stringQuantityOfApples);
            Console.WriteLine(stringQuantityOfApples);
            Process(stringQuantityOfBananas);
            Console.WriteLine(stringQuantityOfBananas);
            Process(stringQuantity);
            Console.WriteLine(stringQuantity);
        }

        private void Process(int quantity)
        {
            Console.WriteLine(quantity);
            quantity += 7;
            Console.WriteLine(quantity);
        }

        private void Process(string quantity)
        {
            Console.WriteLine(quantity);
            quantity += "7";
            Console.WriteLine(quantity);
        }
    }
}
