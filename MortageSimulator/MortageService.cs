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
                periods = CalculateFromPeriods(Options.GetDefaultRanges()); //CalculateUsingFixedInterestRate();
            if (Options.CalculationType == CalculationTypeEnum.UseSuperHipotecaMixta)
                periods = CalculateFromPeriods(Options.GetDefaultRanges());// CalculateUsingSuperHipotecaMitxa();
            if (Options.CalculationType == CalculationTypeEnum.UseCustomRanges)
                periods = CalculateFromPeriods(Options.CustomRanges);
            return periods;
        }

        //private IList<MortagePeriod> CalculateUsingFixedInterestRate()
        //{
        //    var periodId = 1;
        //    var currentPeriodDate = Options.FirstPeriodDate;
        //    var periods = new List<MortagePeriod>();
        //    for (int i = 0; i < Options.NumberOfPeriods; i++)
        //    {
        //        var period = new MortagePeriod();
        //        period.Id = periodId;
        //        period.Date = currentPeriodDate;
        //        if (periodId == 1)
        //            period.InitialCapital = Options.InitialCapital;
        //        else
        //            period.InitialCapital = periods[i - 1].PendingCapital;
        //        period.TypeOfInterest = Options.TypeOfInterest;
        //        period.FeeToPay = PMT((double)period.TypeOfInterest, Options.NumberOfPeriods, Options.InitialCapital);
        //        period.Interests = period.InitialCapital * ((double)period.TypeOfInterest / 100 / 12);
        //        period.AmortizedCapital = period.FeeToPay - period.Interests;
        //        period.PendingCapital = period.InitialCapital - period.AmortizedCapital;

        //        periods.Add(period);
        //        periodId++;
        //        currentPeriodDate = currentPeriodDate.AddMonths(1);
        //    }
        //    return periods;
        //}

        //bool IsPeriodInFirstYear(int periodId) => periodId <= 12;
        //bool IsPeriodBetween2And5Years(int periodId) => periodId > 12 && periodId <= 60;
        //bool IsPeriodAfter5Year(int periodId) => periodId > 60;
        //bool IsFirstPeriodOfFirstYear(int periodId) => periodId == 1;
        //bool IsFirstPeriodOfSecondToFiftyhYear(int periodId) => periodId == 13;
        //bool IsFirstPeriodOfAfterFiftyhYear(int periodId) => periodId == 61;
        //private IList<MortagePeriod> CalculateUsingSuperHipotecaMitxa()
        //{
        //    var periodId = 1;
        //    var currentPeriodDate = Options.FirstPeriodDate;
        //    var periods = new List<MortagePeriod>();
        //    for (int i = 0; i < Options.NumberOfPeriods; i++)
        //    {
        //        var period = new MortagePeriod();
        //        period.Id = periodId;
        //        period.Date = currentPeriodDate;
        //        if (IsPeriodInFirstYear(periodId))
        //        {
        //            if (IsFirstPeriodOfFirstYear(periodId))
        //                period.InitialCapital = Options.InitialCapital;
        //            else
        //                period.InitialCapital = periods[i - 1].PendingCapital;
        //            period.TypeOfInterest = Options.SuperHipotecaMixta1YearTypeOfInterest;
        //            period.FeeToPay = PMT((double)period.TypeOfInterest, Options.NumberOfPeriods, Options.InitialCapital);
        //            period.Interests = period.InitialCapital * ((double)period.TypeOfInterest / 100 / 12);
        //        }
        //        if (IsPeriodBetween2And5Years(periodId))
        //        {
        //            period.InitialCapital = periods[i - 1].PendingCapital;
        //            period.TypeOfInterest = Options.SuperHipotecaMixta2To5YearTypeOfInterest;
        //            period.FeeToPay = PMT((double)period.TypeOfInterest, Options.NumberOfPeriods - 12, periods[11].PendingCapital);
        //            period.Interests = period.InitialCapital * ((double)period.TypeOfInterest / 100 / 12);
        //        }
        //        if (IsPeriodAfter5Year(periodId))
        //        {
        //            period.InitialCapital = periods[i - 1].PendingCapital;
        //            period.TypeOfInterest = Options.SuperHipotecaMixtaAfter5YearTypeOfInterest;
        //            period.FeeToPay = PMT((double)period.TypeOfInterest, Options.NumberOfPeriods - 60, periods[59].PendingCapital);
        //            period.Interests = period.InitialCapital * ((double)period.TypeOfInterest / 100 / 12);
        //        }
        //        period.AmortizedCapital = period.FeeToPay - period.Interests;
        //        period.PendingCapital = period.InitialCapital - period.AmortizedCapital;

        //        periods.Add(period);
        //        periodId++;
        //        currentPeriodDate = currentPeriodDate.AddMonths(1);
        //    }
        //    return periods;
        //}

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
                        Id = periodId,
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

        //public IList<MortageCustomPeriod> GetPeriods()
        //{
        //    var customperiods = new List<MortageCustomPeriod>();
        //    if (Options.CalculationType == CalculationTypeEnum.UseFixedInterestRate)
        //    {
        //        customperiods.Add(new MortageCustomPeriod() { NumberOfPeriods = Options.NumberOfPeriods, TypeOfInterest = Options.TypeOfInterest });
        //    }
        //    if (Options.CalculationType == CalculationTypeEnum.UseSuperHipotecaMixta)
        //    {
        //        customperiods.Add(new MortageCustomPeriod() { NumberOfPeriods = 12, TypeOfInterest = Options.SuperHipotecaMixta1YearTypeOfInterest });
        //        customperiods.Add(new MortageCustomPeriod() { NumberOfPeriods = 48, TypeOfInterest = Options.SuperHipotecaMixta2To5YearTypeOfInterest });
        //        customperiods.Add(new MortageCustomPeriod() { NumberOfPeriods = Options.NumberOfPeriods - 60, TypeOfInterest = Options.SuperHipotecaMixtaAfter5YearTypeOfInterest });
        //    }
        //    customperiods.AddRange(Options.CustomPeriods);
        //    return customperiods;
        //}

        public static double PMT(double yearlyInterestRate, int totalNumberOfMonths, double loanAmount)
        {
            var rate = (double)yearlyInterestRate / 100 / 12;
            var denominator = Math.Pow((1 + rate), totalNumberOfMonths) - 1;
            return (rate + (rate / denominator)) * loanAmount;
        }
    }
}