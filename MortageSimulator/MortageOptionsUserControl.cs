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
                    mortageCustomRangeBindingSource.DataSource = MortageOptions?.GetDefaultRanges();
                }
            }
        }

        public MortageOptionsUserControl()
        {
            InitializeComponent();
            CalculationTypeImageComboBoxEdit.Properties.AddEnum(typeof(CalculationTypeEnum));
            CalculationTypeImageComboBoxEdit.EditValueChanged += (s, e) =>
            {
                SuperHipotecaMixta1YearTypeOfInterestTextEdit.ReadOnly = CalculationTypeImageComboBoxEdit.SelectedIndex != 1;
                SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.ReadOnly = CalculationTypeImageComboBoxEdit.SelectedIndex != 1;
                layoutControlGroupCustomRanges.CustomHeaderButtons[0].Properties.Enabled = CalculationTypeImageComboBoxEdit.SelectedIndex == 2;
                MortageOptions.CalculationType = (CalculationTypeEnum)CalculationTypeImageComboBoxEdit.SelectedIndex;
                mortageCustomRangeBindingSource.DataSource = MortageOptions?.GetDefaultRanges();
            };
            NumberOfPeriodsTextEdit.EditValueChanged += (s, e) =>
            {
                mortageCustomRangeBindingSource.DataSource = MortageOptions?.GetDefaultRanges();
            };
            textEditEuribor12M.EditValueChanged += (s, e) =>
            {
                mortageCustomRangeBindingSource.DataSource = MortageOptions?.GetDefaultRanges();
            };
            textEditDifferentialRate.EditValueChanged += (s, e) =>
            {
                mortageCustomRangeBindingSource.DataSource = MortageOptions?.GetDefaultRanges();
            };
        }
    }
}
