namespace MortageSimulator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar2 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar3 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            MortageOptions mortageOptions1 = new MortageOptions();
            colPendingCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            colInterests = new DevExpress.XtraGrid.Columns.GridColumn();
            colAmortizedCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItemParseDefaultFile = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemCalculate = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemParseFile = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            gridControl = new DevExpress.XtraGrid.GridControl();
            bindingSource = new BindingSource(components);
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colTypeOfInterest = new DevExpress.XtraGrid.Columns.GridColumn();
            colFeeToPay = new DevExpress.XtraGrid.Columns.GridColumn();
            colInitialCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            dockManager = new DevExpress.XtraBars.Docking.DockManager(components);
            dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            mortageOptionsUserControl = new MortageOptionsUserControl();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dockManager).BeginInit();
            dockPanel1.SuspendLayout();
            dockPanel1_Container.SuspendLayout();
            SuspendLayout();
            // 
            // colPendingCapital
            // 
            colPendingCapital.DisplayFormat.FormatString = "n2";
            colPendingCapital.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colPendingCapital.FieldName = "PendingCapital";
            colPendingCapital.Name = "colPendingCapital";
            colPendingCapital.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PendingCapital", "{0}") });
            colPendingCapital.Visible = true;
            colPendingCapital.VisibleIndex = 7;
            // 
            // colInterests
            // 
            colInterests.DisplayFormat.FormatString = "n2";
            colInterests.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colInterests.FieldName = "Interests";
            colInterests.Name = "colInterests";
            colInterests.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Interests", "{0:n2}") });
            colInterests.Visible = true;
            colInterests.VisibleIndex = 5;
            // 
            // colAmortizedCapital
            // 
            colAmortizedCapital.DisplayFormat.FormatString = "n2";
            colAmortizedCapital.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colAmortizedCapital.FieldName = "AmortizedCapital";
            colAmortizedCapital.Name = "colAmortizedCapital";
            colAmortizedCapital.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmortizedCapital", "{0:n2}") });
            colAmortizedCapital.Visible = true;
            colAmortizedCapital.VisibleIndex = 4;
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barButtonItemParseDefaultFile, barButtonItemCalculate, barButtonItemParseFile, barButtonItemExportToExcel });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 5;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(1112, 158);
            // 
            // barButtonItemParseDefaultFile
            // 
            barButtonItemParseDefaultFile.Caption = "Parse Default File";
            barButtonItemParseDefaultFile.Id = 1;
            barButtonItemParseDefaultFile.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemParseDefaultFile.ImageOptions.SvgImage");
            barButtonItemParseDefaultFile.Name = "barButtonItemParseDefaultFile";
            // 
            // barButtonItemCalculate
            // 
            barButtonItemCalculate.Caption = "Calculate";
            barButtonItemCalculate.Id = 2;
            barButtonItemCalculate.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemCalculate.ImageOptions.SvgImage");
            barButtonItemCalculate.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F5);
            barButtonItemCalculate.Name = "barButtonItemCalculate";
            // 
            // barButtonItemParseFile
            // 
            barButtonItemParseFile.Caption = "Parse File...";
            barButtonItemParseFile.Id = 3;
            barButtonItemParseFile.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemParseFile.ImageOptions.SvgImage");
            barButtonItemParseFile.Name = "barButtonItemParseFile";
            // 
            // barButtonItemExportToExcel
            // 
            barButtonItemExportToExcel.Caption = "ExportToExcel";
            barButtonItemExportToExcel.Id = 4;
            barButtonItemExportToExcel.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemExportToExcel.ImageOptions.SvgImage");
            barButtonItemExportToExcel.Name = "barButtonItemExportToExcel";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "GENERAL";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItemParseDefaultFile);
            ribbonPageGroup1.ItemLinks.Add(barButtonItemParseFile);
            ribbonPageGroup1.ItemLinks.Add(barButtonItemCalculate);
            ribbonPageGroup1.ItemLinks.Add(barButtonItemExportToExcel, true);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Options";
            // 
            // gridControl
            // 
            gridControl.DataSource = bindingSource;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(325, 158);
            gridControl.MainView = gridView;
            gridControl.MenuManager = ribbon;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(787, 682);
            gridControl.TabIndex = 3;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // bindingSource
            // 
            bindingSource.DataSource = typeof(MortagePeriod);
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colDate, colTypeOfInterest, colAmortizedCapital, colInterests, colFeeToPay, colPendingCapital, colInitialCapital });
            gridFormatRule1.Column = colPendingCapital;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleDataBar1.PredefinedName = "Mint";
            gridFormatRule1.Rule = formatConditionRuleDataBar1;
            gridFormatRule2.Column = colInterests;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleDataBar2.PredefinedName = "Raspberry";
            gridFormatRule2.Rule = formatConditionRuleDataBar2;
            gridFormatRule3.Column = colAmortizedCapital;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleDataBar3.PredefinedName = "Blue";
            gridFormatRule3.Rule = formatConditionRuleDataBar3;
            gridView.FormatRules.Add(gridFormatRule1);
            gridView.FormatRules.Add(gridFormatRule2);
            gridView.FormatRules.Add(gridFormatRule3);
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsMenu.ShowConditionalFormattingItem = true;
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // colDate
            // 
            colDate.FieldName = "Date";
            colDate.Name = "colDate";
            colDate.Visible = true;
            colDate.VisibleIndex = 1;
            // 
            // colTypeOfInterest
            // 
            colTypeOfInterest.Caption = "Type Of Interest (%)";
            colTypeOfInterest.DisplayFormat.FormatString = "n2";
            colTypeOfInterest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTypeOfInterest.FieldName = "TypeOfInterest";
            colTypeOfInterest.Name = "colTypeOfInterest";
            colTypeOfInterest.Visible = true;
            colTypeOfInterest.VisibleIndex = 3;
            // 
            // colFeeToPay
            // 
            colFeeToPay.DisplayFormat.FormatString = "n2";
            colFeeToPay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colFeeToPay.FieldName = "FeeToPay";
            colFeeToPay.Name = "colFeeToPay";
            colFeeToPay.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FeeToPay", "{0:n2}") });
            colFeeToPay.Visible = true;
            colFeeToPay.VisibleIndex = 6;
            // 
            // colInitialCapital
            // 
            colInitialCapital.DisplayFormat.FormatString = "n2";
            colInitialCapital.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colInitialCapital.FieldName = "InitialCapital";
            colInitialCapital.Name = "colInitialCapital";
            colInitialCapital.Visible = true;
            colInitialCapital.VisibleIndex = 2;
            // 
            // dockManager
            // 
            dockManager.Form = this;
            dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] { dockPanel1 });
            dockManager.TopZIndexControls.AddRange(new string[] { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl" });
            // 
            // dockPanel1
            // 
            dockPanel1.Controls.Add(dockPanel1_Container);
            dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            dockPanel1.ID = new Guid("567f80b2-92d7-467a-8caf-207bde63914e");
            dockPanel1.Location = new Point(0, 158);
            dockPanel1.Name = "dockPanel1";
            dockPanel1.OriginalSize = new Size(325, 200);
            dockPanel1.Size = new Size(325, 682);
            dockPanel1.Text = "Mortage Options";
            // 
            // dockPanel1_Container
            // 
            dockPanel1_Container.Controls.Add(mortageOptionsUserControl);
            dockPanel1_Container.Location = new Point(3, 26);
            dockPanel1_Container.Name = "dockPanel1_Container";
            dockPanel1_Container.Size = new Size(318, 653);
            dockPanel1_Container.TabIndex = 0;
            // 
            // mortageOptionsUserControl
            // 
            mortageOptionsUserControl.Dock = DockStyle.Fill;
            mortageOptionsUserControl.Location = new Point(0, 0);
            mortageOptions1.CalculationType = CalculationTypeEnum.UseFixedInterestRate;
            mortageOptions1.DifferentialRate = 0D;
            mortageOptions1.Euribor12MRate = 0D;
            mortageOptions1.FirstPeriodDate = new DateTime(0L);
            mortageOptions1.InitialCapital = 0D;
            mortageOptions1.NumberOfPeriods = 0;
            mortageOptions1.SuperHipotecaMixta1YearTypeOfInterest = 0D;
            mortageOptions1.SuperHipotecaMixta2To5YearTypeOfInterest = 0D;
            mortageOptionsUserControl.MortageOptions = mortageOptions1;
            mortageOptionsUserControl.Name = "mortageOptionsUserControl";
            mortageOptionsUserControl.Size = new Size(318, 653);
            mortageOptionsUserControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 840);
            Controls.Add(gridControl);
            Controls.Add(dockPanel1);
            Controls.Add(ribbon);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("MainForm.IconOptions.SvgImage");
            Name = "MainForm";
            Ribbon = ribbon;
            Text = "Mortage Simulator";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dockManager).EndInit();
            dockPanel1.ResumeLayout(false);
            dockPanel1_Container.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemParseDefaultFile;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private BindingSource bindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeOfInterest;
        private DevExpress.XtraGrid.Columns.GridColumn colAmortizedCapital;
        private DevExpress.XtraGrid.Columns.GridColumn colInterests;
        private DevExpress.XtraGrid.Columns.GridColumn colFeeToPay;
        private DevExpress.XtraGrid.Columns.GridColumn colPendingCapital;
        private DevExpress.XtraGrid.Columns.GridColumn colInitialCapital;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCalculate;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarButtonItem barButtonItemParseFile;
        private MortageOptionsUserControl mortageOptionsUserControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExportToExcel;
    }
}