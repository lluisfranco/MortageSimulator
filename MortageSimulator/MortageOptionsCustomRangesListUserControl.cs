namespace MortageSimulator
{
    public partial class MortageOptionsCustomRangesListUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public bool ReadOnly
        {
            get => !gridView.OptionsBehavior.Editable;
            set => gridView.OptionsBehavior.Editable = value;
        }

        public MortageOptionsCustomRangesListUserControl()
        {
            InitializeComponent();
        }

        public void SetData(IList<MortageCustomRange>? data)
        {
            mortageCustomRangeBindingSource.DataSource = data;
        }
    }
}
