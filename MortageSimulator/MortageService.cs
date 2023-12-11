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
            var periodId = 1;
            var currentPeriodDate = Options.FirstPeriodDate;
            var periods = new List<MortagePeriod>();
            for (int i = 0; i < Options.NumberOfPeriods; i++)
            {
                var period = new MortagePeriod();
                period.Id = periodId;
                period.Date = currentPeriodDate;
                period.TypeOfInterest = Options.TypeOfInterest / 100;
                if (periodId == 1) 
                    period.InitialCapital = Options.InitialCapital;
                else 
                    period.InitialCapital = periods[i - 1].PendingCapital;
                period.FeeToPay = PMT((double)Options.TypeOfInterest, Options.NumberOfPeriods, Options.InitialCapital);
                period.Interests = period.InitialCapital * ((double)Options.TypeOfInterest / 100 / 12);
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