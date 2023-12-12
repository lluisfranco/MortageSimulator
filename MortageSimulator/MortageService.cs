namespace MortageSimulator
{
    public class MortageService
    {
        public const string ERROR_MESSAGE_DIFF_NUMPERIODS = 
            "The sum of the number of periods in custom ranges must be equal to the total number of periods";
        public MortageOptions Options { get; private set; }

        public MortageService(MortageOptions options)
        {
            Options = options;
        }

        public IList<MortagePeriod> Calculate()
        {
            IList<MortagePeriod> periods = new List<MortagePeriod>(); 
            if (Options.CalculationType == CalculationTypeEnum.UseFixedInterestRate) 
                periods = CalculateFromPeriods(Options.GetDefaultRanges());
            if (Options.CalculationType == CalculationTypeEnum.UseSuperHipotecaMixta)
                periods = CalculateFromPeriods(Options.GetDefaultRanges());
            if (Options.CalculationType == CalculationTypeEnum.UseCustomRanges)
                periods = CalculateFromPeriods(Options.CustomRanges);
            return periods;
        }

        public IList<MortagePeriod> CalculateFromPeriods(IList<MortageCustomRange> customPeriods)
        {
            var currentPeriodDate = Options.FirstPeriodDate;
            int index = 0;
            int totalNumberOfPeriods = 0;
            double periodInitialCapital = Options.InitialCapital;
            var periodId = 1;
            var periods = new List<MortagePeriod>();
            foreach (var customPeriod in customPeriods)
            {
                bool isFirstPeriod = index == 0;
                for (int i = 0; i < customPeriod.NumberOfPeriods; i++)
                {
                    bool isFirstDateInPeriod = i == 0;
                    if (isFirstDateInPeriod && !isFirstPeriod)
                        periodInitialCapital = periods[totalNumberOfPeriods - 1].PendingCapital;
                    var period = new MortagePeriod
                    {
                        RangeId = index + 1,
                        PeriodId = periodId,
                        Date = currentPeriodDate,
                        TypeOfInterest = customPeriod.TypeOfInterest
                    };
                    if (!isFirstDateInPeriod)
                        period.InitialCapital = periods[periodId - 2].PendingCapital;
                    else
                        period.InitialCapital = periodInitialCapital;
                    period.FeeToPay = PMT(
                        (double)period.TypeOfInterest, 
                        Options.NumberOfPeriods - totalNumberOfPeriods,
                        periodInitialCapital);
                    period.Interests = period.InitialCapital * ((double)period.TypeOfInterest / 100 / 12);
                    period.AmortizedCapital = period.FeeToPay - period.Interests;
                    period.PendingCapital = period.InitialCapital - period.AmortizedCapital;
                    periods.Add(period);
                    periodId++;
                    currentPeriodDate = currentPeriodDate.AddMonths(1);
                }
                totalNumberOfPeriods += customPeriod.NumberOfPeriods; 
                index++;
            }
            return periods;
        }

        public static double PMT(double yearlyInterestRate, int totalNumberOfMonths, double loanAmount)
        {
            var rate = (double)yearlyInterestRate / 100 / 12;
            var denominator = Math.Pow((1 + rate), totalNumberOfMonths) - 1;
            return (rate + (rate / denominator)) * loanAmount;
        }
    }
}