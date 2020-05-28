using System;
using System.Text;

namespace StringTheory
{
    internal class MultilineExample
    {
        internal void Go()
        {
            const string input = @"
dlkjflasdj
feburery 45th twnty sumthin
2013
1947/06/03 14:30:29
     ?
01/01/2001 01:01:01.0001
dolphin

apple 03/03/3002
     12/31/2020 23:59:59.9999     
sadlfjlasdkjf
";
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var builder = new StringBuilder(input.Length);
            foreach (var line in lines)
            {
                if (DateTime.TryParse(line, out DateTime date))
                    builder.AppendLine(date.ToString("o"));
                else
                    builder.AppendLine($"Invalid: {line}");
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
