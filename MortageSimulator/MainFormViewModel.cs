using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPivotGrid;
using System.Diagnostics;

namespace MortageSimulator
{
    public class MainFormViewModel
    {
        public MainForm Owner { get; set; }
        public MainFormViewModel(MainForm owner)
        {
            Owner = owner;             
        }

        public void ExportToExcel(GridView view)
        {
            var file = Path.GetTempFileName().Replace("tmp", "xlsx");
            if (view.RowCount == 0) return;
            view.ExportToXlsx(file);
            OpenFile(file);
        }

        public void ExportToExcel(PivotGridControl view)
        {
            var file = Path.GetTempFileName().Replace("tmp", "xlsx");
            view.ExportToXlsx(file);
            OpenFile(file);
        }

        private static void OpenFile(string file)
        {
            var p = new Process
            {
                StartInfo = new ProcessStartInfo(file)
                {
                    UseShellExecute = true
                }
            }.Start();
        }
    }
}
