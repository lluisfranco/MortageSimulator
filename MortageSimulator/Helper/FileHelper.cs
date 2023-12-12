using System.Text.Json;

namespace MortageSimulator
{
    public class FileHelper
    {
        public static void SaveToFile(MortageOptions options, string extension = "msf")
        {
            using var fd = new SaveFileDialog()
            {
                Filter = $"*.{extension}|*.{extension}|All Files (*.*)|*.*",
            };
            if (fd.ShowDialog() == DialogResult.OK)
            {
                var content = JsonSerializer.Serialize(options,
                    new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(fd.FileName, content);
            }
        }

        public static MortageOptions OpenFromFile(string extension = "msf")
        {
            using var fd = new OpenFileDialog()
            {
                Filter = $"*.{extension}|*.{extension}|All Files (*.*)|*.*",
            };
            if (fd.ShowDialog() == DialogResult.OK)
            {
                var content = File.ReadAllText(fd.FileName);
                return JsonSerializer.Deserialize<MortageOptions>(content) ?? new();
            }
            else
                return new();
        }

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
