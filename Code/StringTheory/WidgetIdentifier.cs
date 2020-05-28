using System;
using System.Linq;

namespace StringTheory
{
    internal class WidgetIdentifier
    {
        internal int LotNumber { get; private set; }
        internal DateTime Approved { get; private set; }
        internal string Approver { get; private set; }
        internal int SequenceNumber { get; private set; }

        private const char separator = '-';

        internal WidgetIdentifier(int lotNumber, DateTime approved, string approver, int sequenceNumber)
        {
            if (lotNumber < 1000 || lotNumber > 9999) throw new ArgumentOutOfRangeException(nameof(lotNumber));
            if (approved == DateTime.MinValue) throw new ArgumentOutOfRangeException(nameof(approved));
            var approverUppercase = approver.Trim().ToUpper();
            if (approverUppercase.Length != 4) throw new ArgumentException(nameof(approver));
            if (approverUppercase.Any(c => !char.IsLetterOrDigit(c))) throw new ArgumentException(nameof(approver));
            if (sequenceNumber < 1) throw new ArgumentOutOfRangeException(nameof(sequenceNumber));
            LotNumber = lotNumber;
            Approved = approved;
            Approver = approverUppercase;
            SequenceNumber = sequenceNumber;
        }

        internal static WidgetIdentifier Parse(string value)
        {
            var parts = value.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 4)
                throw new ArgumentException($"There must be four parts in '{value}'.");
            var stringLotNumber = parts[0];
            var stringApproved = parts[1];
            var stringApprover = parts[2];
            var stringSequenceNumber = parts[3];
            if (!int.TryParse(stringLotNumber, out int lotNumber))
                throw new ArgumentException($"Unable to parse lot number '{stringLotNumber}'.");
            if (stringApproved.Length != 8)
                throw new ArgumentException($"Invalid approve date length '{stringApproved}'.");
            var stringApprovedExpanded = $"{stringApproved.Substring(0, 4)}/{stringApproved.Substring(4, 2)}/{stringApproved.Substring(6, 2)}";
            if (!DateTime.TryParse(stringApprovedExpanded, out DateTime approved))
                throw new ArgumentException($"Unable to parse approve date '{stringApprovedExpanded}'.");
            if (!int.TryParse(stringSequenceNumber, out int sequenceNumber))
                throw new ArgumentException($"Unable to parse sequence number '{stringSequenceNumber}'.");
            return new WidgetIdentifier(lotNumber, approved, stringApprover, sequenceNumber);
        }

        internal void IncrementSequenceNumber() => SequenceNumber++;

        internal string GenerateLabel() =>
            $"{LotNumber:0000}{separator}{Approved:yyyyMMdd}{separator}{Approver}{separator}{SequenceNumber}";
    }
}
