using System;
using System.IO;
using System.Net;
using System.Text;

namespace StringTheory
{
    internal class BuiltInHelpers
    {
        internal void Pathing()
        {
            const string path = @"C:\Users\Jen\Documents\Cats\Meowington.png";
            const string root = @"C:\Users\Jen\Documents\Cats";
            const string relative = @"..\Dogs\BilboWaggins.png";
            const string folder = "Cats";
            const string file = "Boots.png";
            Console.WriteLine(path);
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetPathRoot(path));
            Console.WriteLine(Path.Combine(root, relative));
            Console.WriteLine(Path.GetFullPath(Path.Combine(root, relative)));
            Console.WriteLine(Path.Join(folder, file));
            var manyFolders = new string[]
            {
                "Users",
                "Jen",
                "Documents",
                "Cats"
            };
            var manyFoldersPath = Path.Join(manyFolders);
            Console.WriteLine(manyFoldersPath);
            var manualPath = $"Documents{Path.DirectorySeparatorChar}Cats";
            Console.WriteLine(manualPath);
        }

        internal void Html()
        {
            Console.WriteLine(WebUtility.HtmlEncode("if (x < 1)"));
            Console.WriteLine(WebUtility.HtmlDecode("if (x &lt; 1)"));
            Console.WriteLine(WebUtility.UrlEncode("That's a good test"));
            Console.WriteLine(WebUtility.UrlDecode("That%27s+a+good+test"));
        }

        internal void Base64()
        {
            const string original = @"
My friend, the things that do attain
The happy life be these, I find:
The riches left, not got with pain;
The fruitful ground; the quiet mind;
";
            var encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(original));
            Console.WriteLine(encoded);
            var decoded = Encoding.UTF8.GetString(Convert.FromBase64String(encoded));
            Console.WriteLine(decoded);
        }
    }
}
