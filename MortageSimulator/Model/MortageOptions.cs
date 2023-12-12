using System.ComponentModel;

namespace MortageSimulator
{
    public class MortageOptions
    {
        public string? Name { get; set; }
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

        public IList<MortageCustomRange> CustomRanges { get; set; } = new List<MortageCustomRange>();

        public IList<MortageCustomRange> GetDefaultRanges()
        {
            var customranges = new List<MortageCustomRange>();
            if (CalculationType == CalculationTypeEnum.UseFixedInterestRate)
            {
                customranges.Add(new MortageCustomRange() { NumberOfPeriods = NumberOfPeriods, TypeOfInterest = TypeOfInterest });
            }
            if (CalculationType == CalculationTypeEnum.UseSuperHipotecaMixta)
            {
                customranges.Add(new MortageCustomRange() { NumberOfPeriods = 12, TypeOfInterest = SuperHipotecaMixta1YearTypeOfInterest });
                customranges.Add(new MortageCustomRange() { NumberOfPeriods = 48, TypeOfInterest = SuperHipotecaMixta2To5YearTypeOfInterest });
                customranges.Add(new MortageCustomRange() { NumberOfPeriods = NumberOfPeriods - 60, TypeOfInterest = SuperHipotecaMixtaAfter5YearTypeOfInterest });
            }
            if (CalculationType == CalculationTypeEnum.UseCustomRanges)
                customranges.AddRange(CustomRanges);
            return customranges;
        }

        public override string ToString()
        {
            var ranges = GetDefaultRanges();
            var rangesstr = string.Join(Environment.NewLine,
                ranges.Select(p => $"Periods: {p.NumberOfPeriods} Interest: {p.TypeOfInterest}%").ToList());
            return 
                $"{CalculationType}: Capital: {InitialCapital:n0} " +
                $"Interest: {TypeOfInterest:n2}% Ranges: ({ranges.Count}){Environment.NewLine}{rangesstr}";
        }

        public MortageOptions? Clone() 
        { 
            var newoptions = MemberwiseClone() as MortageOptions;
            foreach (var customrange in CustomRanges)
                newoptions?.CustomRanges.Add(customrange.Clone()!);
            return newoptions;
        }
    }

    public class MortageCustomRange
    {
        public int NumberOfPeriods { get; set; }
        public double TypeOfInterest { get; set; }
        public MortageCustomRange? Clone() => MemberwiseClone() as MortageCustomRange;
    }

    public enum CalculationTypeEnum
    {
        [Description("Use Interest Rate")]
        UseFixedInterestRate,

        [Description("Use Super Hipoteca Mixta")]
        UseSuperHipotecaMixta,

        [Description("Use Custom Ranges")]
        UseCustomRanges
    }
}