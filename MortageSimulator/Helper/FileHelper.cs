namespace MortageSimulator
{
    public class FileHelper
    {
        public static IList<MortagePeriod> CalculatePeriodsFromFile(string file)
        {
            try
            {
                var originalperiods = ParseFileService.ParseFile(file);
                var periods = ParseFileService.ToMortagePeriodList(originalperiods);
                var totalAmortizedCapital = periods.Sum(x => x.AmortizedCapital);
                var totalInterests = periods.Sum(x => x.Interests);
                return periods;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }
    }
}
