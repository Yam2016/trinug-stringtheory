using System;

namespace StringTheory
{
    internal class User
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal DateTime StartDate { get; set; }

        internal string GenerateFullName() => $"{FirstName} {LastName}";

        public override string ToString() => GenerateFullName();
    }
}
