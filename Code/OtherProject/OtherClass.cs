using System;

namespace OtherProject
{
    public class OtherClass
    {
        public const string TheConstant = "ConstantString";

        public void DoStuff(string value = "DefaultString")
        {
            Console.WriteLine(value);
        }
    }
}
