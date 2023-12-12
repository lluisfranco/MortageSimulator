namespace MortageSimulator
{
    public partial class MortageOptionsUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public bool ValidateData()
        {
            var validate = dxValidationProvider.Validate();
            if (!validate) return false;
            if (MortageOptions.CalculationType == CalculationTypeEnum.UseCustomRanges &&
                MortageOptions.CustomRanges.Sum(p => p.NumberOfPeriods) != MortageOptions.NumberOfPeriods)
                throw new Exception("The sum of the number of periods in custom ranges must be equal to the total number of periods");
            return true;
        }

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
                    RefreshRangesList();
                }
            }
        }

        private void RefreshRangesList() =>
            mortageOptionsCustomRangesListUserControl.SetData(MortageOptions?.GetDefaultRanges());

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
                RefreshRangesList();
            };
            NumberOfPeriodsTextEdit.EditValueChanged += (s, e) =>
            {
                RefreshRangesList();
            };
            textEditEuribor12M.EditValueChanged += (s, e) =>
            {
                RefreshRangesList();
            };
            textEditDifferentialRate.EditValueChanged += (s, e) =>
            {
                RefreshRangesList();
            };
        }
    }
}
