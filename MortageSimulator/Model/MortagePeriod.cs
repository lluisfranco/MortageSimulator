using System.ComponentModel;

namespace MortageSimulator
{
    public class MortagePeriod
    {
        public int Id { get; set; }

        [Description("Date")]
        public DateTime Date { get; set; }

        [Description("Initial Capital")]
        public double InitialCapital { get; set; }

        [Description("Type Of Interest")]
        public double TypeOfInterest { get; set; }

        [Description("Amortized Capital")]
        public double AmortizedCapital { get; set; }

        [Description("Interests")]
        public double Interests { get; set; }

        [Description("Fee To Pay")]
        public double FeeToPay { get; set; }

        [Description("Pending Capital")]
        public double PendingCapital { get; set; }
    }
}