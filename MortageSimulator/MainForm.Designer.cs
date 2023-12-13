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
            MortageOptions mortageOptions1 = new MortageOptions();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar2 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar3 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding7 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding8 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            colPendingCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            colInterests = new DevExpress.XtraGrid.Columns.GridColumn();
            colAmortizedCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItemParseDefaultFile = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemCalculate = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemParseFile = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemOpen = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            skinPaletteRibbonGalleryBarItem = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            barCheckItemCompactUI = new DevExpress.XtraBars.BarCheckItem();
            barButtonItemAddToComparer = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemCompare = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroupTheme = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            simulationBindingSource = new BindingSource(components);
            dockManager = new DevExpress.XtraBars.Docking.DockManager(components);
            dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            mortageOptionsUserControl = new MortageOptionsUserControl();
            tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            tabNavigationPageSimulation = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colTypeOfInterest = new DevExpress.XtraGrid.Columns.GridColumn();
            colFeeToPay = new DevExpress.XtraGrid.Columns.GridColumn();
            colInitialCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            colRangeId = new DevExpress.XtraGrid.Columns.GridColumn();
            tabNavigationPageComparer = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            pivotGridControlComparer = new DevExpress.XtraPivotGrid.PivotGridControl();
            comparerBindingSource = new BindingSource(components);
            pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            pivotGridField8 = new DevExpress.XtraPivotGrid.PivotGridField();
            barButtonItemComparerManager = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemClearSimulations = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)simulationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dockManager).BeginInit();
            dockPanel1.SuspendLayout();
            dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabPane1).BeginInit();
            tabPane1.SuspendLayout();
            tabNavigationPageSimulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            tabNavigationPageComparer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pivotGridControlComparer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comparerBindingSource).BeginInit();
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
            colPendingCapital.VisibleIndex = 8;
            // 
            // colInterests
            // 
            colInterests.DisplayFormat.FormatString = "n2";
            colInterests.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colInterests.FieldName = "Interests";
            colInterests.Name = "colInterests";
            colInterests.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Interests", "{0:n2}") });
            colInterests.Visible = true;
            colInterests.VisibleIndex = 7;
            // 
            // colAmortizedCapital
            // 
            colAmortizedCapital.DisplayFormat.FormatString = "n2";
            colAmortizedCapital.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colAmortizedCapital.FieldName = "AmortizedCapital";
            colAmortizedCapital.Name = "colAmortizedCapital";
            colAmortizedCapital.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmortizedCapital", "{0:n2}") });
            colAmortizedCapital.Visible = true;
            colAmortizedCapital.VisibleIndex = 6;
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barButtonItemParseDefaultFile, barButtonItemCalculate, barButtonItemParseFile, barButtonItemExportToExcel, barButtonItemOpen, barButtonItemSave, skinRibbonGalleryBarItem, skinPaletteRibbonGalleryBarItem, barCheckItemCompactUI, barButtonItemAddToComparer, barButtonItemCompare, barButtonItemComparerManager, barButtonItemClearSimulations });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 15;
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
            barButtonItemExportToExcel.Caption = "Export To Excel";
            barButtonItemExportToExcel.Id = 4;
            barButtonItemExportToExcel.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemExportToExcel.ImageOptions.SvgImage");
            barButtonItemExportToExcel.Name = "barButtonItemExportToExcel";
            // 
            // barButtonItemOpen
            // 
            barButtonItemOpen.Caption = "Open...";
            barButtonItemOpen.Id = 5;
            barButtonItemOpen.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemOpen.ImageOptions.SvgImage");
            barButtonItemOpen.Name = "barButtonItemOpen";
            // 
            // barButtonItemSave
            // 
            barButtonItemSave.Caption = "Save...";
            barButtonItemSave.Id = 6;
            barButtonItemSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemSave.ImageOptions.SvgImage");
            barButtonItemSave.Name = "barButtonItemSave";
            // 
            // skinRibbonGalleryBarItem
            // 
            skinRibbonGalleryBarItem.Caption = "skinRibbonGalleryBarItem1";
            skinRibbonGalleryBarItem.Id = 8;
            skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // skinPaletteRibbonGalleryBarItem
            // 
            skinPaletteRibbonGalleryBarItem.Caption = "skinPaletteRibbonGalleryBarItem1";
            skinPaletteRibbonGalleryBarItem.Id = 9;
            skinPaletteRibbonGalleryBarItem.Name = "skinPaletteRibbonGalleryBarItem";
            // 
            // barCheckItemCompactUI
            // 
            barCheckItemCompactUI.BindableChecked = true;
            barCheckItemCompactUI.Caption = "Compact UI";
            barCheckItemCompactUI.Checked = true;
            barCheckItemCompactUI.Id = 10;
            barCheckItemCompactUI.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barCheckItemCompactUI.ImageOptions.SvgImage");
            barCheckItemCompactUI.Name = "barCheckItemCompactUI";
            // 
            // barButtonItemAddToComparer
            // 
            barButtonItemAddToComparer.Caption = "Add Simulation To Comparer";
            barButtonItemAddToComparer.Id = 11;
            barButtonItemAddToComparer.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemAddToComparer.ImageOptions.SvgImage");
            barButtonItemAddToComparer.Name = "barButtonItemAddToComparer";
            // 
            // barButtonItemCompare
            // 
            barButtonItemCompare.Caption = "Compare";
            barButtonItemCompare.Id = 12;
            barButtonItemCompare.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemCompare.ImageOptions.SvgImage");
            barButtonItemCompare.Name = "barButtonItemCompare";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup3, ribbonPageGroup2, ribbonPageGroupTheme });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "GENERAL";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItemOpen);
            ribbonPageGroup1.ItemLinks.Add(barButtonItemSave);
            ribbonPageGroup1.ItemLinks.Add(barButtonItemCalculate, true);
            ribbonPageGroup1.ItemLinks.Add(barButtonItemExportToExcel, true);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Options";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(barButtonItemAddToComparer);
            ribbonPageGroup3.ItemLinks.Add(barButtonItemCompare);
            ribbonPageGroup3.ItemLinks.Add(barButtonItemComparerManager);
            ribbonPageGroup3.ItemLinks.Add(barButtonItemClearSimulations);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "Comparer";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItemParseFile);
            ribbonPageGroup2.ItemLinks.Add(barButtonItemParseDefaultFile);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Extensions";
            // 
            // ribbonPageGroupTheme
            // 
            ribbonPageGroupTheme.ItemLinks.Add(skinRibbonGalleryBarItem);
            ribbonPageGroupTheme.ItemLinks.Add(skinPaletteRibbonGalleryBarItem);
            ribbonPageGroupTheme.ItemLinks.Add(barCheckItemCompactUI);
            ribbonPageGroupTheme.Name = "ribbonPageGroupTheme";
            ribbonPageGroupTheme.Text = "Theme";
            // 
            // simulationBindingSource
            // 
            simulationBindingSource.DataSource = typeof(MortagePeriod);
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
            mortageOptions1.Name = null;
            mortageOptions1.NumberOfPeriods = 0;
            mortageOptions1.SuperHipotecaMixta1YearTypeOfInterest = 0D;
            mortageOptions1.SuperHipotecaMixta2To5YearTypeOfInterest = 0D;
            mortageOptionsUserControl.MortageOptions = mortageOptions1;
            mortageOptionsUserControl.Name = "mortageOptionsUserControl";
            mortageOptionsUserControl.Size = new Size(318, 653);
            mortageOptionsUserControl.TabIndex = 0;
            // 
            // tabPane1
            // 
            tabPane1.Controls.Add(tabNavigationPageSimulation);
            tabPane1.Controls.Add(tabNavigationPageComparer);
            tabPane1.Dock = DockStyle.Fill;
            tabPane1.Location = new Point(325, 158);
            tabPane1.Name = "tabPane1";
            tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { tabNavigationPageSimulation, tabNavigationPageComparer });
            tabPane1.RegularSize = new Size(787, 682);
            tabPane1.SelectedPage = tabNavigationPageSimulation;
            tabPane1.Size = new Size(787, 682);
            tabPane1.TabIndex = 6;
            tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPageSimulation
            // 
            tabNavigationPageSimulation.Caption = "SIMULATION";
            tabNavigationPageSimulation.Controls.Add(gridControl);
            tabNavigationPageSimulation.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("tabNavigationPageSimulation.ImageOptions.SvgImage");
            tabNavigationPageSimulation.ImageOptions.SvgImageSize = new Size(16, 16);
            tabNavigationPageSimulation.Name = "tabNavigationPageSimulation";
            tabNavigationPageSimulation.Size = new Size(787, 649);
            // 
            // gridControl
            // 
            gridControl.DataSource = simulationBindingSource;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(0, 0);
            gridControl.MainView = gridView;
            gridControl.MenuManager = ribbon;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(787, 649);
            gridControl.TabIndex = 4;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colDate, colTypeOfInterest, colAmortizedCapital, colInterests, colFeeToPay, colPendingCapital, colInitialCapital, colRangeId });
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
            gridView.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            colId.FieldName = "PeriodId";
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 1;
            // 
            // colDate
            // 
            colDate.FieldName = "Date";
            colDate.Name = "colDate";
            colDate.Visible = true;
            colDate.VisibleIndex = 2;
            // 
            // colTypeOfInterest
            // 
            colTypeOfInterest.Caption = "Type Of Interest (%)";
            colTypeOfInterest.DisplayFormat.FormatString = "n2";
            colTypeOfInterest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTypeOfInterest.FieldName = "TypeOfInterest";
            colTypeOfInterest.Name = "colTypeOfInterest";
            colTypeOfInterest.Visible = true;
            colTypeOfInterest.VisibleIndex = 4;
            // 
            // colFeeToPay
            // 
            colFeeToPay.DisplayFormat.FormatString = "n2";
            colFeeToPay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colFeeToPay.FieldName = "FeeToPay";
            colFeeToPay.Name = "colFeeToPay";
            colFeeToPay.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FeeToPay", "{0:n2}") });
            colFeeToPay.Visible = true;
            colFeeToPay.VisibleIndex = 5;
            // 
            // colInitialCapital
            // 
            colInitialCapital.DisplayFormat.FormatString = "n2";
            colInitialCapital.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colInitialCapital.FieldName = "InitialCapital";
            colInitialCapital.Name = "colInitialCapital";
            colInitialCapital.Visible = true;
            colInitialCapital.VisibleIndex = 3;
            // 
            // colRangeId
            // 
            colRangeId.FieldName = "RangeId";
            colRangeId.Name = "colRangeId";
            colRangeId.Visible = true;
            colRangeId.VisibleIndex = 0;
            // 
            // tabNavigationPageComparer
            // 
            tabNavigationPageComparer.Caption = "COMPARER";
            tabNavigationPageComparer.Controls.Add(pivotGridControlComparer);
            tabNavigationPageComparer.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("tabNavigationPageComparer.ImageOptions.SvgImage");
            tabNavigationPageComparer.ImageOptions.SvgImageSize = new Size(16, 16);
            tabNavigationPageComparer.Name = "tabNavigationPageComparer";
            tabNavigationPageComparer.Size = new Size(787, 649);
            // 
            // pivotGridControlComparer
            // 
            pivotGridControlComparer.DataSource = comparerBindingSource;
            pivotGridControlComparer.Dock = DockStyle.Fill;
            pivotGridControlComparer.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] { pivotGridField1, pivotGridField2, pivotGridField3, pivotGridField4, pivotGridField5, pivotGridField6, pivotGridField7, pivotGridField8 });
            pivotGridControlComparer.Location = new Point(0, 0);
            pivotGridControlComparer.MenuManager = ribbon;
            pivotGridControlComparer.Name = "pivotGridControlComparer";
            pivotGridControlComparer.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            pivotGridControlComparer.OptionsView.ShowColumnGrandTotals = false;
            pivotGridControlComparer.OptionsView.ShowColumnTotals = false;
            pivotGridControlComparer.Size = new Size(787, 649);
            pivotGridControlComparer.TabIndex = 0;
            // 
            // comparerBindingSource
            // 
            comparerBindingSource.DataSource = typeof(MortageComparerResult);
            // 
            // pivotGridField1
            // 
            pivotGridField1.AreaIndex = 0;
            pivotGridField1.Caption = "Id";
            dataSourceColumnBinding1.ColumnName = "Id";
            pivotGridField1.DataBinding = dataSourceColumnBinding1;
            pivotGridField1.Name = "pivotGridField1";
            pivotGridField1.Visible = false;
            // 
            // pivotGridField2
            // 
            pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            pivotGridField2.AreaIndex = 0;
            pivotGridField2.Caption = "Name";
            dataSourceColumnBinding2.ColumnName = "Name";
            pivotGridField2.DataBinding = dataSourceColumnBinding2;
            pivotGridField2.Name = "pivotGridField2";
            // 
            // pivotGridField3
            // 
            pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            pivotGridField3.AreaIndex = 0;
            pivotGridField3.Caption = "Year";
            dataSourceColumnBinding3.ColumnName = "Year";
            pivotGridField3.DataBinding = dataSourceColumnBinding3;
            pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridField4
            // 
            pivotGridField4.AreaIndex = 0;
            pivotGridField4.Caption = "Number Of Periods";
            dataSourceColumnBinding4.ColumnName = "NumberOfPeriods";
            pivotGridField4.DataBinding = dataSourceColumnBinding4;
            pivotGridField4.Name = "pivotGridField4";
            pivotGridField4.Visible = false;
            // 
            // pivotGridField5
            // 
            pivotGridField5.AreaIndex = 0;
            pivotGridField5.Caption = "Average Type Of Interest";
            pivotGridField5.CellFormat.FormatString = "n2";
            pivotGridField5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            dataSourceColumnBinding5.ColumnName = "AverageTypeOfInterest";
            pivotGridField5.DataBinding = dataSourceColumnBinding5;
            pivotGridField5.Name = "pivotGridField5";
            // 
            // pivotGridField6
            // 
            pivotGridField6.Appearance.Cell.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            pivotGridField6.Appearance.Cell.Options.UseFont = true;
            pivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            pivotGridField6.AreaIndex = 2;
            pivotGridField6.Caption = "Total Interests";
            pivotGridField6.CellFormat.FormatString = "n0";
            pivotGridField6.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            dataSourceColumnBinding6.ColumnName = "TotalInterests";
            pivotGridField6.DataBinding = dataSourceColumnBinding6;
            pivotGridField6.Name = "pivotGridField6";
            // 
            // pivotGridField7
            // 
            pivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            pivotGridField7.AreaIndex = 0;
            pivotGridField7.Caption = "Total Fee To Pay";
            pivotGridField7.CellFormat.FormatString = "n0";
            pivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            dataSourceColumnBinding7.ColumnName = "TotalFeeToPay";
            pivotGridField7.DataBinding = dataSourceColumnBinding7;
            pivotGridField7.Name = "pivotGridField7";
            // 
            // pivotGridField8
            // 
            pivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            pivotGridField8.AreaIndex = 1;
            pivotGridField8.Caption = "Total Amortized Capital";
            pivotGridField8.CellFormat.FormatString = "n0";
            pivotGridField8.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            dataSourceColumnBinding8.ColumnName = "TotalAmortizedCapital";
            pivotGridField8.DataBinding = dataSourceColumnBinding8;
            pivotGridField8.Name = "pivotGridField8";
            // 
            // barButtonItemComparerManager
            // 
            barButtonItemComparerManager.Caption = "Simulations List...";
            barButtonItemComparerManager.Id = 13;
            barButtonItemComparerManager.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemComparerManager.ImageOptions.SvgImage");
            barButtonItemComparerManager.Name = "barButtonItemComparerManager";
            // 
            // barButtonItemClearSimulations
            // 
            barButtonItemClearSimulations.Caption = "Clear Simulations";
            barButtonItemClearSimulations.Id = 14;
            barButtonItemClearSimulations.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            barButtonItemClearSimulations.Name = "barButtonItemClearSimulations";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 840);
            Controls.Add(tabPane1);
            Controls.Add(dockPanel1);
            Controls.Add(ribbon);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("MainForm.IconOptions.SvgImage");
            Name = "MainForm";
            Ribbon = ribbon;
            Text = "Mortage Simulator";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)simulationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dockManager).EndInit();
            dockPanel1.ResumeLayout(false);
            dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabPane1).EndInit();
            tabPane1.ResumeLayout(false);
            tabNavigationPageSimulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            tabNavigationPageComparer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pivotGridControlComparer).EndInit();
            ((System.ComponentModel.ISupportInitialize)comparerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemParseDefaultFile;
        private BindingSource simulationBindingSource;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCalculate;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarButtonItem barButtonItemParseFile;
        private MortageOptionsUserControl mortageOptionsUserControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExportToExcel;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpen;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupTheme;
        private DevExpress.XtraBars.BarCheckItem barCheckItemCompactUI;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddToComparer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCompare;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageSimulation;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeOfInterest;
        private DevExpress.XtraGrid.Columns.GridColumn colAmortizedCapital;
        private DevExpress.XtraGrid.Columns.GridColumn colInterests;
        private DevExpress.XtraGrid.Columns.GridColumn colFeeToPay;
        private DevExpress.XtraGrid.Columns.GridColumn colPendingCapital;
        private DevExpress.XtraGrid.Columns.GridColumn colInitialCapital;
        private DevExpress.XtraGrid.Columns.GridColumn colRangeId;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageComparer;
        private BindingSource comparerBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlComparer;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField8;
        private DevExpress.XtraBars.BarButtonItem barButtonItemComparerManager;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClearSimulations;
    }
}