namespace MortageSimulator
{
    public partial class MortageOptionsCustomRangeslListEditorForm : DevExpress.XtraEditors.XtraForm
    {
        int NumberOfPeriods = 0;
        public MortageOptionsCustomRangeslListEditorForm()
        {
            InitializeComponent();
            simpleButtonOk.Click += (s, e) =>
            {
                var ranges = GetData() ?? new List<MortageCustomRange>();
                if (NumberOfPeriods != ranges.Sum(p => p.NumberOfPeriods))
                {
                    MessageBox.Show(MortageService.ERROR_MESSAGE_DIFF_NUMPERIODS, 
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult = DialogResult.OK;
                Close();
            };  
        }

        public void SetData(IList<MortageCustomRange> data, int numberOfPeriods = 0)
        {
            NumberOfPeriods = numberOfPeriods;
            var list = new List<MortageCustomRange>();
            foreach (var item in data)
            {
                var newitem = item.Clone();
                if (newitem != null) list.Add(newitem);
            }
            mortageOptionsCustomRangesListUserControl.SetData(list);
        }

        public IList<MortageCustomRange>? GetData()
        {
            return mortageOptionsCustomRangesListUserControl.GetData();
        }
    }
}