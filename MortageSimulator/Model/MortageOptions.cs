using System.ComponentModel;

namespace MortageSimulator
{
    public class MortageOptions
    {
        [Description("Initial Capital")]
        public double InitialCapital { get; set; }

        [Description("First Period Date")]
        public DateTime FirstPeriodDate { get; set; }

        [Description("Number Of Periods")]
        public int NumberOfPeriods { get; set; }

        [Description("Calculation Type")]
        public CalculationTypeEnum CalculationType { get; set; }

        [Description("Type Of Interest")]
        public double TypeOfInterest { get; set; }

        [Description("Super Hipoteca Mixta 1st Year Type Of Interest")]
        public double SuperHipotecaMixta1YearTypeOfInterest { get; set; }

        [Description("Super Hipoteca Mixta 2nd To 5th Year Type Of Interest")]
        public double SuperHipotecaMixta2To5YearTypeOfInterest { get; set; }
    }

    public enum CalculationTypeEnum
    {
        [Description("Use Interest Rate")]
        UseFixedInterestRate,

        [Description("Use Super Hipoteca Mixta")]
        UseSuperHipotecaMixta
    }
}