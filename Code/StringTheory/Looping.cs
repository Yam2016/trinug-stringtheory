using System;
using System.Diagnostics;
using System.Text;

namespace StringTheory
{
    internal class Looping
    {
        private const int iterations = 10_000;

        internal void StartLooping()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            LoopSlowly();
            stopwatch.Stop();
            Console.WriteLine($"Slow: {stopwatch.ElapsedMilliseconds} milliseconds");
            stopwatch.Reset();
            stopwatch.Start();
            LoopQuickly();
            stopwatch.Stop();
            Console.WriteLine($"Fast: {stopwatch.ElapsedMilliseconds} milliseconds");
        }

        private void LoopSlowly()
        {
            var output = string.Empty;
            for (var i = 0; i < iterations; i++)
                output += i;
            Console.WriteLine(output.Length);
        }

        private void LoopQuickly()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < iterations; i++)
                sb.Append(i);
            Console.WriteLine(sb.ToString().Length);
        }
    }
}
