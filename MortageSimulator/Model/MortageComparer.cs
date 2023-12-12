using DevExpress.PivotGrid.Printing;

namespace MortageSimulator
{
    public class MortageComparerResult
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public int NumberOfPeriods { get; set; }
        public double AverageTypeOfInterest { get; set; }
        public double TotalInterests { get; set; }
        public double TotalFeeToPay { get; set; }
        public double TotalAmortizedCapital { get; set; }
    }

    public class MortageComparer
    {
        public IList<MortageOptions> Simulations { get; set; } = new List<MortageOptions>();

        public IList<MortageComparerResult> Compare()
        {
            int id = 0;
            var results = new List<MortageComparerResult>();
            foreach (var simulation in Simulations)
            {
                var service = new MortageService(simulation);
                var periods = service.Calculate();
                var result = periods.GroupBy(p => p.Date.Year).Select(g => new MortageComparerResult()
                {
                    Id = ++id,
                    Name = simulation.Name ?? simulation.ToString(),
                    Year = g.Key,
                    NumberOfPeriods = g.Count(),
                    AverageTypeOfInterest = g.Average(p => p.TypeOfInterest),
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