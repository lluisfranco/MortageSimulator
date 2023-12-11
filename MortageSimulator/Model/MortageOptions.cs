using System.ComponentModel;
using static System.Windows.Forms.Design.AxImporter;

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

        [Description("Euribor 12M Rate")]
        public double Euribor12MRate { get; set; }

        [Description("Differential Rate")]
        public double DifferentialRate { get; set; }

        [Description("Type Of Interest")]
        public double TypeOfInterest => Euribor12MRate + DifferentialRate;

        [Description("Super Hipoteca Mixta 1st Year Type Of Interest")]
        public double SuperHipotecaMixta1YearTypeOfInterest { get; set; } = 1.75;

        [Description("Super Hipoteca Mixta 2nd To 5th Year Type Of Interest")]
        public double SuperHipotecaMixta2To5YearTypeOfInterest { get; set; } = 2.75;

        [Description("Super Hipoteca Mixta After 5th Year Type Of Interest")]
        public double SuperHipotecaMixtaAfter5YearTypeOfInterest => Euribor12MRate + 0.5;

        public IList<MortageCustomPeriod> CustomPeriods { get; set; } = new List<MortageCustomPeriod>();

        public IList<MortageCustomPeriod> GetPeriods()
        {
            var customperiods = new List<MortageCustomPeriod>();
            if (CalculationType == CalculationTypeEnum.UseFixedInterestRate)
            {
                customperiods.Add(new MortageCustomPeriod() { NumberOfPeriods = NumberOfPeriods, TypeOfInterest = TypeOfInterest });
            }
            if (CalculationType == CalculationTypeEnum.UseSuperHipotecaMixta)
            {
                customperiods.Add(new MortageCustomPeriod() { NumberOfPeriods = 12, TypeOfInterest = SuperHipotecaMixta1YearTypeOfInterest });
                customperiods.Add(new MortageCustomPeriod() { NumberOfPeriods = 48, TypeOfInterest = SuperHipotecaMixta2To5YearTypeOfInterest });
                customperiods.Add(new MortageCustomPeriod() { NumberOfPeriods = NumberOfPeriods - 60, TypeOfInterest = SuperHipotecaMixtaAfter5YearTypeOfInterest });
            }
            customperiods.AddRange(CustomPeriods);
            return customperiods;
        }

    }

    public class MortageCustomPeriod
    {
        public int NumberOfPeriods { get; set; }
        public double TypeOfInterest { get; set; }
    }

    public enum CalculationTypeEnum
    {
        [Description("Use Interest Rate")]
        UseFixedInterestRate,

        [Description("Use Super Hipoteca Mixta")]
        UseSuperHipotecaMixta,

        [Description("Use Custom Periods")]
        UseCustomPeriods
    }
}