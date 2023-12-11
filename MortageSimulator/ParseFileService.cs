using System.IO;

namespace MortageSimulator
{
    public class ParseFileService
    {
        public static IList<MortagePeriodOriginal> ParseFile(string file)
        {
            var periods = new List<MortagePeriodOriginal>();
            if (!File.Exists(file)) return periods;
            var content = File.ReadAllText(file);
            var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            int i = 1;
            int numLines = 6;
            int periodid = 1;
            bool skipFirstLine = true;
            var period = new MortagePeriodOriginal();
            foreach (var line in lines)
            {
                if (i == 1) period.Date = line;
                if (i == 2) period.TypeOfInterest = line;
                if (i == 3) period.AmortizedCapital = line;
                if (i == 4) period.Interests = line;
                if (i == 5) period.FeeToPay = line;
                if (i == 6) period.PendingCapital = line;
                if (i == numLines)
                {
                    period.Id = periodid;
                    periodid++;
                    periods.Add(period);
                    period = new MortagePeriodOriginal();
                    i = 0;
                }
                i++;
            }
            if (skipFirstLine) periods.RemoveAt(0);
            return periods;
        }

        public static IList<MortagePeriod> ToMortagePeriodList(IList<MortagePeriodOriginal> originalperiods)
        {
            var periods = new List<MortagePeriod>();
            foreach (var item in originalperiods)
            {
                var period = new MortagePeriod
                {
                    Id = item.Id - 1,
                    Date = Convert.ToDateTime(item.Date),
                    InitialCapital = RemoveSymbol(item.PendingCapital, "EUR") + RemoveSymbol(item.AmortizedCapital, "EUR"),
                    TypeOfInterest = RemoveSymbol(item.TypeOfInterest, "%") / 100,
                    AmortizedCapital = RemoveSymbol(item.AmortizedCapital, "EUR"),
                    Interests = RemoveSymbol(item.Interests, "EUR"),
                    FeeToPay = RemoveSymbol(item.FeeToPay, "EUR"),
                    PendingCapital = RemoveSymbol(item.PendingCapital, "EUR")
                };
                periods.Add(period);
            }
            return periods;
        }

        private static double RemoveSymbol(string? value, string symbol) =>
            Convert.ToDouble(value?.Replace(symbol, string.Empty).Trim());
        
    }
}