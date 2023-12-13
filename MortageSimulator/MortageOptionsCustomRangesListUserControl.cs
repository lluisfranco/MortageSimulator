namespace MortageSimulator
{
    public partial class MortageOptionsCustomRangesListUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public bool ReadOnly
        {
            get
            {
                return !gridView.OptionsBehavior.Editable;
            }
            set
            {
                gridView.OptionsBehavior.Editable = !value;
                gridControl.UseEmbeddedNavigator = !value;
            }
        }

        public MortageOptionsCustomRangesListUserControl()
        {
            InitializeComponent();
        }

        public void SetData(IList<MortageCustomRange>? data)
        {
            mortageCustomRangeBindingSource.DataSource = data;
        }

        public IList<MortageCustomRange>? GetData()
        {
            return mortageCustomRangeBindingSource.DataSource as IList<MortageCustomRange>;
        }
    }
}
