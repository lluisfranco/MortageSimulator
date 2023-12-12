using System.Diagnostics;

namespace MortageSimulator
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MortageOptions MortageOptions { get; set; }
        const string ORIGINAL_FILE = "HipotecaBM2023.txt";
        public MainForm()
        {
            InitializeComponent();
            Shown += (s, e) =>
            {
                MortageOptions = new MortageOptions
                {
                    FirstPeriodDate = new DateTime(2024, 1, 5),
                    InitialCapital = 246574.64,
                    NumberOfPeriods = 147,
                    Euribor12MRate = 4.21,
                    DifferentialRate = 1,
                    CalculationType = CalculationTypeEnum.UseFixedInterestRate,
                };
                MortageOptions.CustomRanges.Add(new MortageCustomRange() { NumberOfPeriods = 12, TypeOfInterest = 5.21 });
                MortageOptions.CustomRanges.Add(new MortageCustomRange() { NumberOfPeriods = 135, TypeOfInterest = 2 });
                mortageOptionsUserControl.MortageOptions = MortageOptions;
            };
            barButtonItemOpen.ItemClick += (s, e) =>
            {
                mortageOptionsUserControl.MortageOptions = FileHelper.OpenFromFile();
                CalculateMortage();
            };
            barButtonItemSave.ItemClick += (s, e) =>
            {
                FileHelper.SaveToFile(mortageOptionsUserControl.MortageOptions);
            };
            barButtonItemCalculate.ItemClick += (s, e) =>
            {
                try
                {
                    if (!mortageOptionsUserControl.ValidateData()) return;
                    CalculateMortage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            barButtonItemExportToExcel.ItemClick += (s, e) =>
            {
                var file = Path.GetTempFileName().Replace("tmp", "xlsx");
                if (gridView.RowCount == 0) return;
                gridView.ExportToXlsx(file);
                var p = new Process
                {
                    StartInfo = new ProcessStartInfo(file)
                    {
                        UseShellExecute = true
                    }
                }.Start();
            };
            barButtonItemParseDefaultFile.ItemClick += (s, e) =>
            {
                var file = Path.Combine("Files", ORIGINAL_FILE);
                CalculatePeriodsFromFile(file);
            };
            barButtonItemParseFile.ItemClick += (s, e) =>
            {
                using var fd = new OpenFileDialog()
                {
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
                };
                if (fd.ShowDialog() == DialogResult.OK)
                    CalculatePeriodsFromFile(fd.FileName);
            };
        }

        private void CalculateMortage()
        {
            var mortageService = new MortageService(mortageOptionsUserControl.MortageOptions);
            var periods = mortageService.Calculate();
            bindingSource.DataSource = periods;
            gridView.RefreshData();
        }

        private void CalculatePeriodsFromFile(string file) =>
            bindingSource.DataSource = FileHelper.CalculatePeriodsFromFile(file);
    }
}