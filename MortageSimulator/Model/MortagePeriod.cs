using System.ComponentModel;

namespace MortageSimulator
{
    public class MortagePeriod
    {
        public int Id { get; set; }

        [Description("Date")]
        public DateTime Date { get; set; }

        [Description("Type Of Interest")]
        public decimal TypeOfInterest { get; set; }

        [Description("Amortized Capital")]
        public decimal AmortizedCapital { get; set; }

        [Description("Interests")]
        public decimal Interests { get; set; }

        [Description("Fee To Pay")]
        public decimal FeeToPay { get; set; }

        [Description("Pending Capital")]
        public decimal PendingCapital { get; set; }
    }
}