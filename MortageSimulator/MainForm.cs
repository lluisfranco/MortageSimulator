using System.Reflection;

namespace MortageSimulator
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MortageOptions MortageOptions { get; private set; }
        public MortageComparer Comparer { get; private set; } = new();
        public MainFormViewModel ViewModel { get; private set; } 
        public bool IsSimulationTab => tabPane1.SelectedPage == tabNavigationPageSimulation;

        const string ORIGINAL_FILE = "HipotecaBM2023.txt";
        public MainForm()
        {
            InitializeComponent();
            DevExpressSkinHelper.SetTheme("WXI", "Default");
            DevExpressSkinHelper.SetCompactUI(true, barCheckItemCompactUI);
            ViewModel = new(this);
            Text = string.Format($"{Application.ProductName} - " +
                $"{Assembly.GetExecutingAssembly().GetName().Version}");
            Load += (s, e) =>
            {
                DevExpressSkinHelper.RemoveSkins(skinRibbonGalleryBarItem.Gallery);
                DevExpressSkinHelper.RemoveNoVectorSkins(skinRibbonGalleryBarItem.Gallery);
            };
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
            barButtonItemAddToComparer.ItemClick += (s, e) =>
            {
                var newoptions = MortageOptions?.Clone();
                if (newoptions != null)
                    Comparer.Simulations.Add(newoptions);
            };
            barButtonItemCompare.ItemClick += (s, e) =>
            {
                if (Comparer.Simulations.Count == 0) return;
                comparerBindingSource.DataSource = Comparer.Compare();
                tabPane1.SelectedPage = tabNavigationPageComparer;
            };
            barButtonItemClearSimulations.ItemClick += (s, e) =>
            {
                Comparer.Simulations.Clear();
                comparerBindingSource.DataSource = Comparer.Compare();
                tabPane1.SelectedPage = tabNavigationPageComparer;
            };
            barButtonItemExportToExcel.ItemClick += (s, e) =>
            {
                if (IsSimulationTab) 
                    ViewModel.ExportToExcel(gridView);
                else 
                    ViewModel.ExportToExcel(pivotGridControlComparer);
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
            barCheckItemCompactUI.ItemClick+= (s, e) =>
            {
                DevExpressSkinHelper.SetCompactUI(barCheckItemCompactUI.Checked, barCheckItemCompactUI);
            };
        }

        private void CalculateMortage()
        {
            var mortageService = new MortageService(mortageOptionsUserControl.MortageOptions);
            var periods = mortageService.Calculate();
            simulationBindingSource.DataSource = periods;
            gridView.RefreshData();
        }

        public void CalculatePeriodsFromFile(string file) =>
            simulationBindingSource.DataSource = FileHelper.CalculatePeriodsFromFile(file);
    }
}