using System.IO;

namespace MortageSimulator
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        const string ORIGINAL_FILE = "HipotecaBM2023.txt";
        public MainForm()
        {
            InitializeComponent();
            barButtonItemParseOriginal.ItemClick += (s, e) =>
            {
                var file = Path.Combine("Files", ORIGINAL_FILE);
                var originalperiods = ParseFileService.ParseFile(file);
                var periods = ParseFileService.ToMortagePeriodList(originalperiods);
                var totalAmortizedCapital = periods.Sum(x => x.AmortizedCapital);
                var totalInterests = periods.Sum(x => x.Interests);
                bindingSource.DataSource = periods;
            };
            barButtonItemCalculate.ItemClick += (s, e) =>
            {
                var mortageService = new MortageService(new MortageOptions
                {
                    FirstPeriodDate = new DateTime(2024, 1, 5),
                    InitialCapital = 246574.64,
                    NumberOfPeriods = 147,
                    TypeOfInterest = 5.21,
                });
                var periods = mortageService.Calculate();
                bindingSource.DataSource = periods;
            };
        }
    }
}