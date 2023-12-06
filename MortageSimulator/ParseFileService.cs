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
                var period = new MortagePeriod();
                period.Id = item.Id;
                period.Date = Convert.ToDateTime(item.Date);
                period.TypeOfInterest = RemoveSymbol(item.TypeOfInterest, "%") / 100;
                period.AmortizedCapital = RemoveSymbol(item.AmortizedCapital, "EUR");
                period.Interests = RemoveSymbol(item.Interests, "EUR");
                period.FeeToPay = RemoveSymbol(item.FeeToPay, "EUR");
                period.PendingCapital = RemoveSymbol(item.PendingCapital, "EUR");
                periods.Add(period);
            }
            return periods;
        }

        private static decimal RemoveSymbol(string? value, string symbol) =>
            Convert.ToDecimal(value?.Replace(symbol, string.Empty).Trim());
        
    }
}