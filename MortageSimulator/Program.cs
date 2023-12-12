namespace MortageSimulator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.XtraEditors.WindowsFormsSettings.ForceDirectXPaint();
            Application.Run(new MainForm());
        }
    }
}