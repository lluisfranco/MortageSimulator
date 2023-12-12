﻿namespace MortageSimulator
{
    public class MortageComparerResult
    {
        public int Year { get; set; }
        public double TotalInterests { get; set; }
        public double TotalFeeToPay { get; set; }
        public double TotalAmortizedCapital { get; set; }
    }

    public class MortageComparer
    {
        public IList<MortageOptions> Simulations { get; set; } = new List<MortageOptions>();

        public IList<MortageComparerResult> Compare()
        {
            var results = new List<MortageComparerResult>();
            foreach (var simulation in Simulations)
            {
                var service = new MortageService(simulation);
                var periods = service.Calculate();
                var result = periods.GroupBy(p => p.Date.Year).Select(g => new MortageComparerResult()
                {
                    Year = g.Key,
                    TotalInterests = g.Sum(p => p.Interests),
                    TotalFeeToPay = g.Sum(p => p.FeeToPay),
                    TotalAmortizedCapital = g.Sum(p => p.AmortizedCapital)
                });
                results.AddRange(result);
            }
            return results;
        }
    }
}