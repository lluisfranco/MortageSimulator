namespace MortageSimulator
{
    public partial class MortageOptionsUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public MortageOptions MortageOptions
        {
            get
            {
                mortageOptionsBindingSource.EndEdit();
                return mortageOptionsBindingSource.DataSource as MortageOptions ?? new();
            }
            set
            {
                if (value != null)
                {
                    mortageOptionsBindingSource.DataSource = value;
                    mortageCustomPeriodBindingSource.DataSource = MortageOptions?.GetPeriods();
                }
            }
        }

        public MortageOptionsUserControl()
        {
            InitializeComponent();
            CalculationTypeImageComboBoxEdit.Properties.AddEnum(typeof(CalculationTypeEnum));
            CalculationTypeImageComboBoxEdit.EditValueChanged += (s, e) =>
            {
                SuperHipotecaMixta1YearTypeOfInterestTextEdit.ReadOnly = CalculationTypeImageComboBoxEdit.SelectedIndex == 0;
                SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.ReadOnly = CalculationTypeImageComboBoxEdit.SelectedIndex == 0;
                gridViewPeriods.OptionsBehavior.ReadOnly = CalculationTypeImageComboBoxEdit.SelectedIndex != 2;
                MortageOptions.CalculationType = (CalculationTypeEnum)CalculationTypeImageComboBoxEdit.SelectedIndex;
                mortageCustomPeriodBindingSource.DataSource = MortageOptions?.GetPeriods();
            };
            NumberOfPeriodsTextEdit.EditValueChanged += (s, e) =>
            {
                mortageCustomPeriodBindingSource.DataSource = MortageOptions?.GetPeriods();
            };
            textEditEuribor12M.EditValueChanged += (s, e) =>
            {
                mortageCustomPeriodBindingSource.DataSource = MortageOptions?.GetPeriods();
            };
            textEditDifferentialRate.EditValueChanged += (s, e) =>
            {
                mortageCustomPeriodBindingSource.DataSource = MortageOptions?.GetPeriods();
            };
        }
    }
}
