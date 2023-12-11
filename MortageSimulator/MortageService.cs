namespace MortageSimulator
{
    public class MortageService
    {
        public MortageOptions Options { get; private set; }

        public MortageService(MortageOptions options)
        {
            Options = options;
        }

        public IList<MortagePeriod> Calculate()
        {
            IList<MortagePeriod> periods = new List<MortagePeriod>(); 
            if (Options.CalculationType == CalculationTypeEnum.UseFixedInterestRate) 
                periods = CalculateUsingFixedInterestRate();
            if (Options.CalculationType == CalculationTypeEnum.UseSuperHipotecaMixta)
                periods = CalculateUsingSuperHipotecaMitxa();
            return periods;
        }

        private IList<MortagePeriod> CalculateUsingFixedInterestRate()
        {
            var periodId = 1;
            var currentPeriodDate = Options.FirstPeriodDate;
            var periods = new List<MortagePeriod>();
            for (int i = 0; i < Options.NumberOfPeriods; i++)
            {
                var period = new MortagePeriod();
                period.Id = periodId;
                period.Date = currentPeriodDate;
                if (periodId == 1)
                    period.InitialCapital = Options.InitialCapital;
                else
                    period.InitialCapital = periods[i - 1].PendingCapital;
                period.TypeOfInterest = Options.TypeOfInterest;
                period.FeeToPay = PMT((double)period.TypeOfInterest, Options.NumberOfPeriods, Options.InitialCapital);
                period.Interests = period.InitialCapital * ((double)period.TypeOfInterest / 100 / 12);
                period.AmortizedCapital = period.FeeToPay - period.Interests;
                period.PendingCapital = period.InitialCapital - period.AmortizedCapital;

                periods.Add(period);
                periodId++;
                currentPeriodDate = currentPeriodDate.AddMonths(1);
            }
            return periods;
        }

        bool IsPeriodInFirstYear(int periodId) => periodId <= 12;
        bool IsPeriodBetween2And5Years(int periodId) => periodId > 12 && periodId <= 60;
        bool IsPeriodAfter5Year(int periodId) => periodId > 60;
        bool IsFirstPeriodOfFirstYear(int periodId) => periodId == 1;
        bool IsFirstPeriodOfSecondToFiftyhYear(int periodId) => periodId == 13;
        bool IsFirstPeriodOfAfterFiftyhYear(int periodId) => periodId == 61;
        private IList<MortagePeriod> CalculateUsingSuperHipotecaMitxa()
        {
            var periodId = 1;
            var currentPeriodDate = Options.FirstPeriodDate;
            var periods = new List<MortagePeriod>();
            for (int i = 0; i < Options.NumberOfPeriods; i++)
            {
                var period = new MortagePeriod();
                period.Id = periodId;
                period.Date = currentPeriodDate;
                if (IsPeriodInFirstYear(periodId))
                {
                    if (IsFirstPeriodOfFirstYear(periodId))
                        period.InitialCapital = Options.InitialCapital;
                    else
                        period.InitialCapital = periods[i - 1].PendingCapital;
                    period.TypeOfInterest = Options.SuperHipotecaMixta1YearTypeOfInterest;
                    period.FeeToPay = PMT((double)period.TypeOfInterest, Options.NumberOfPeriods, Options.InitialCapital);
                    period.Interests = period.InitialCapital * ((double)period.TypeOfInterest / 100 / 12);
                }
                if (IsPeriodBetween2And5Years(periodId))
                {
                    period.InitialCapital = periods[i - 1].PendingCapital;
                    period.TypeOfInterest = Options.SuperHipotecaMixta2To5YearTypeOfInterest;
                    period.FeeToPay = PMT((double)period.TypeOfInterest, Options.NumberOfPeriods - 12, periods[11].PendingCapital);
                    period.Interests = period.InitialCapital * ((double)period.TypeOfInterest / 100 / 12);
                }
                if (IsPeriodAfter5Year(periodId))
                {
                    period.InitialCapital = periods[i - 1].PendingCapital;
                    period.TypeOfInterest = Options.SuperHipotecaMixtaAfter5YearTypeOfInterest;
                    period.FeeToPay = PMT((double)period.TypeOfInterest, Options.NumberOfPeriods - 60, periods[59].PendingCapital);
                    period.Interests = period.InitialCapital * ((double)period.TypeOfInterest / 100 / 12);
                }
                period.AmortizedCapital = period.FeeToPay - period.Interests;
                period.PendingCapital = period.InitialCapital - period.AmortizedCapital;

                periods.Add(period);
                periodId++;
                currentPeriodDate = currentPeriodDate.AddMonths(1);
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