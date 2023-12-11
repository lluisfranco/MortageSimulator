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
                if (value != null) mortageOptionsBindingSource.DataSource = value;
            }
        }

        public MortageOptionsUserControl()
        {
            InitializeComponent();
            CalculationTypeImageComboBoxEdit.EditValueChanged += (s, e) =>
            {
                SuperHipotecaMixta1YearTypeOfInterestTextEdit.ReadOnly = CalculationTypeImageComboBoxEdit.SelectedIndex == 0;
                SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.ReadOnly = CalculationTypeImageComboBoxEdit.SelectedIndex == 0;
                //SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.ReadOnly = CalculationTypeImageComboBoxEdit.SelectedIndex == 0;
            };
        }
    }
}
