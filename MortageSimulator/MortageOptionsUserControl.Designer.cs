namespace MortageSimulator
{
    partial class MortageOptionsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit = new DevExpress.XtraEditors.TextEdit();
            mortageOptionsBindingSource = new BindingSource(components);
            textEditTypeOfInterest = new DevExpress.XtraEditors.TextEdit();
            InitialCapitalTextEdit = new DevExpress.XtraEditors.TextEdit();
            FirstPeriodDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            NumberOfPeriodsTextEdit = new DevExpress.XtraEditors.TextEdit();
            CalculationTypeImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            SuperHipotecaMixta1YearTypeOfInterestTextEdit = new DevExpress.XtraEditors.TextEdit();
            SuperHipotecaMixta2To5YearTypeOfInterestTextEdit = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ItemForInitialCapital = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForFirstPeriodDate = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForNumberOfPeriods = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForCalculationType = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForSuperHipotecaMixta1YearTypeOfInterest = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForSuperHipotecaMixta2To5YearTypeOfInterest = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl).BeginInit();
            dataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mortageOptionsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditTypeOfInterest.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InitialCapitalTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FirstPeriodDateDateEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FirstPeriodDateDateEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfPeriodsTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CalculationTypeImageComboBoxEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SuperHipotecaMixta1YearTypeOfInterestTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForInitialCapital).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForFirstPeriodDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForNumberOfPeriods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForCalculationType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForSuperHipotecaMixta1YearTypeOfInterest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForSuperHipotecaMixta2To5YearTypeOfInterest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            SuspendLayout();
            // 
            // dataLayoutControl
            // 
            dataLayoutControl.Controls.Add(SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit);
            dataLayoutControl.Controls.Add(textEditTypeOfInterest);
            dataLayoutControl.Controls.Add(InitialCapitalTextEdit);
            dataLayoutControl.Controls.Add(FirstPeriodDateDateEdit);
            dataLayoutControl.Controls.Add(NumberOfPeriodsTextEdit);
            dataLayoutControl.Controls.Add(CalculationTypeImageComboBoxEdit);
            dataLayoutControl.Controls.Add(SuperHipotecaMixta1YearTypeOfInterestTextEdit);
            dataLayoutControl.Controls.Add(SuperHipotecaMixta2To5YearTypeOfInterestTextEdit);
            dataLayoutControl.DataSource = mortageOptionsBindingSource;
            dataLayoutControl.Dock = DockStyle.Fill;
            dataLayoutControl.Location = new Point(0, 0);
            dataLayoutControl.Name = "dataLayoutControl";
            dataLayoutControl.Root = Root;
            dataLayoutControl.Size = new Size(434, 432);
            dataLayoutControl.TabIndex = 0;
            dataLayoutControl.Text = "dataLayoutControl1";
            // 
            // SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit
            // 
            SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.DataBindings.Add(new Binding("EditValue", mortageOptionsBindingSource, "SuperHipotecaMixtaAfter5YearTypeOfInterest", true));
            SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.Location = new Point(24, 311);
            SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.Name = "SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit";
            SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.Properties.AdvancedModeOptions.Label = "Type Of Interest (Euribor + Diff -0.5%)";
            SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.Properties.MaskSettings.Set("mask", "n2");
            SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.Properties.ReadOnly = true;
            SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.Size = new Size(386, 34);
            SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.StyleController = dataLayoutControl;
            SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.TabIndex = 8;
            // 
            // mortageOptionsBindingSource
            // 
            mortageOptionsBindingSource.DataSource = typeof(MortageOptions);
            // 
            // textEditTypeOfInterest
            // 
            textEditTypeOfInterest.DataBindings.Add(new Binding("EditValue", mortageOptionsBindingSource, "TypeOfInterest", true));
            textEditTypeOfInterest.Location = new Point(24, 197);
            textEditTypeOfInterest.Name = "textEditTypeOfInterest";
            textEditTypeOfInterest.Properties.AdvancedModeOptions.Label = "Type Of Interest (Euribor + Diff)";
            textEditTypeOfInterest.Properties.Mask.UseMaskAsDisplayFormat = true;
            textEditTypeOfInterest.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            textEditTypeOfInterest.Properties.MaskSettings.Set("mask", "n2");
            textEditTypeOfInterest.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            textEditTypeOfInterest.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            textEditTypeOfInterest.Size = new Size(386, 34);
            textEditTypeOfInterest.StyleController = dataLayoutControl;
            textEditTypeOfInterest.TabIndex = 7;
            // 
            // InitialCapitalTextEdit
            // 
            InitialCapitalTextEdit.DataBindings.Add(new Binding("EditValue", mortageOptionsBindingSource, "InitialCapital", true));
            InitialCapitalTextEdit.Location = new Point(24, 45);
            InitialCapitalTextEdit.Name = "InitialCapitalTextEdit";
            InitialCapitalTextEdit.Properties.AdvancedModeOptions.Label = "Initial Capital";
            InitialCapitalTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            InitialCapitalTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            InitialCapitalTextEdit.Properties.MaskSettings.Set("mask", "n2");
            InitialCapitalTextEdit.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            InitialCapitalTextEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            InitialCapitalTextEdit.Size = new Size(386, 34);
            InitialCapitalTextEdit.StyleController = dataLayoutControl;
            InitialCapitalTextEdit.TabIndex = 0;
            // 
            // FirstPeriodDateDateEdit
            // 
            FirstPeriodDateDateEdit.DataBindings.Add(new Binding("EditValue", mortageOptionsBindingSource, "FirstPeriodDate", true));
            FirstPeriodDateDateEdit.EditValue = null;
            FirstPeriodDateDateEdit.Location = new Point(24, 83);
            FirstPeriodDateDateEdit.Name = "FirstPeriodDateDateEdit";
            FirstPeriodDateDateEdit.Properties.AdvancedModeOptions.Label = "First Payment Date";
            FirstPeriodDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            FirstPeriodDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            FirstPeriodDateDateEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            FirstPeriodDateDateEdit.Size = new Size(386, 34);
            FirstPeriodDateDateEdit.StyleController = dataLayoutControl;
            FirstPeriodDateDateEdit.TabIndex = 2;
            // 
            // NumberOfPeriodsTextEdit
            // 
            NumberOfPeriodsTextEdit.DataBindings.Add(new Binding("EditValue", mortageOptionsBindingSource, "NumberOfPeriods", true));
            NumberOfPeriodsTextEdit.Location = new Point(24, 121);
            NumberOfPeriodsTextEdit.Name = "NumberOfPeriodsTextEdit";
            NumberOfPeriodsTextEdit.Properties.AdvancedModeOptions.Label = "Number Of Periods";
            NumberOfPeriodsTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            NumberOfPeriodsTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            NumberOfPeriodsTextEdit.Properties.MaskSettings.Set("mask", "N0");
            NumberOfPeriodsTextEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            NumberOfPeriodsTextEdit.Size = new Size(386, 34);
            NumberOfPeriodsTextEdit.StyleController = dataLayoutControl;
            NumberOfPeriodsTextEdit.TabIndex = 3;
            // 
            // CalculationTypeImageComboBoxEdit
            // 
            CalculationTypeImageComboBoxEdit.DataBindings.Add(new Binding("EditValue", mortageOptionsBindingSource, "CalculationType", true));
            CalculationTypeImageComboBoxEdit.Location = new Point(24, 159);
            CalculationTypeImageComboBoxEdit.Name = "CalculationTypeImageComboBoxEdit";
            CalculationTypeImageComboBoxEdit.Properties.AdvancedModeOptions.Label = "Calculation Type";
            CalculationTypeImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CalculationTypeImageComboBoxEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] { new DevExpress.XtraEditors.Controls.ImageComboBoxItem("UseFixedInterestRate", CalculationTypeEnum.UseFixedInterestRate, 0), new DevExpress.XtraEditors.Controls.ImageComboBoxItem("UseSuperHipotecaMixta", CalculationTypeEnum.UseSuperHipotecaMixta, 1) });
            CalculationTypeImageComboBoxEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            CalculationTypeImageComboBoxEdit.Properties.UseCtrlScroll = true;
            CalculationTypeImageComboBoxEdit.Size = new Size(386, 34);
            CalculationTypeImageComboBoxEdit.StyleController = dataLayoutControl;
            CalculationTypeImageComboBoxEdit.TabIndex = 4;
            // 
            // SuperHipotecaMixta1YearTypeOfInterestTextEdit
            // 
            SuperHipotecaMixta1YearTypeOfInterestTextEdit.DataBindings.Add(new Binding("EditValue", mortageOptionsBindingSource, "SuperHipotecaMixta1YearTypeOfInterest", true));
            SuperHipotecaMixta1YearTypeOfInterestTextEdit.Location = new Point(24, 235);
            SuperHipotecaMixta1YearTypeOfInterestTextEdit.Name = "SuperHipotecaMixta1YearTypeOfInterestTextEdit";
            SuperHipotecaMixta1YearTypeOfInterestTextEdit.Properties.AdvancedModeOptions.Label = "Super Hipoteca Mixta 1st Year Type Of Interest";
            SuperHipotecaMixta1YearTypeOfInterestTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            SuperHipotecaMixta1YearTypeOfInterestTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            SuperHipotecaMixta1YearTypeOfInterestTextEdit.Properties.MaskSettings.Set("mask", "F");
            SuperHipotecaMixta1YearTypeOfInterestTextEdit.Properties.ReadOnly = true;
            SuperHipotecaMixta1YearTypeOfInterestTextEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            SuperHipotecaMixta1YearTypeOfInterestTextEdit.Size = new Size(386, 34);
            SuperHipotecaMixta1YearTypeOfInterestTextEdit.StyleController = dataLayoutControl;
            SuperHipotecaMixta1YearTypeOfInterestTextEdit.TabIndex = 5;
            // 
            // SuperHipotecaMixta2To5YearTypeOfInterestTextEdit
            // 
            SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.DataBindings.Add(new Binding("EditValue", mortageOptionsBindingSource, "SuperHipotecaMixta2To5YearTypeOfInterest", true));
            SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.Location = new Point(24, 273);
            SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.Name = "SuperHipotecaMixta2To5YearTypeOfInterestTextEdit";
            SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.Properties.AdvancedModeOptions.Label = "Super Hipoteca Mixta 2nd to 5th Year Type Of Interest";
            SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.Properties.MaskSettings.Set("mask", "F");
            SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.Properties.ReadOnly = true;
            SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.Size = new Size(386, 34);
            SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.StyleController = dataLayoutControl;
            SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.TabIndex = 6;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup2 });
            Root.Name = "Root";
            Root.Size = new Size(434, 432);
            Root.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem1, ItemForInitialCapital, ItemForFirstPeriodDate, ItemForNumberOfPeriods, ItemForCalculationType, ItemForSuperHipotecaMixta1YearTypeOfInterest, ItemForSuperHipotecaMixta2To5YearTypeOfInterest, layoutControlItem1, layoutControlItem3 });
            layoutControlGroup2.Location = new Point(0, 0);
            layoutControlGroup2.Name = "layoutControlGroup2";
            layoutControlGroup2.Size = new Size(414, 412);
            layoutControlGroup2.Text = "MORTAGE OPTIONS";
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 304);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(390, 63);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // ItemForInitialCapital
            // 
            ItemForInitialCapital.Control = InitialCapitalTextEdit;
            ItemForInitialCapital.Location = new Point(0, 0);
            ItemForInitialCapital.Name = "ItemForInitialCapital";
            ItemForInitialCapital.Size = new Size(390, 38);
            ItemForInitialCapital.Text = "Initial Capital";
            ItemForInitialCapital.TextSize = new Size(0, 0);
            ItemForInitialCapital.TextVisible = false;
            // 
            // ItemForFirstPeriodDate
            // 
            ItemForFirstPeriodDate.Control = FirstPeriodDateDateEdit;
            ItemForFirstPeriodDate.Location = new Point(0, 38);
            ItemForFirstPeriodDate.Name = "ItemForFirstPeriodDate";
            ItemForFirstPeriodDate.Size = new Size(390, 38);
            ItemForFirstPeriodDate.Text = "First Period Date";
            ItemForFirstPeriodDate.TextSize = new Size(0, 0);
            ItemForFirstPeriodDate.TextVisible = false;
            // 
            // ItemForNumberOfPeriods
            // 
            ItemForNumberOfPeriods.Control = NumberOfPeriodsTextEdit;
            ItemForNumberOfPeriods.Location = new Point(0, 76);
            ItemForNumberOfPeriods.Name = "ItemForNumberOfPeriods";
            ItemForNumberOfPeriods.Size = new Size(390, 38);
            ItemForNumberOfPeriods.Text = "Number Of Periods";
            ItemForNumberOfPeriods.TextSize = new Size(0, 0);
            ItemForNumberOfPeriods.TextVisible = false;
            // 
            // ItemForCalculationType
            // 
            ItemForCalculationType.Control = CalculationTypeImageComboBoxEdit;
            ItemForCalculationType.Location = new Point(0, 114);
            ItemForCalculationType.Name = "ItemForCalculationType";
            ItemForCalculationType.Size = new Size(390, 38);
            ItemForCalculationType.Text = "Calculation Type";
            ItemForCalculationType.TextSize = new Size(0, 0);
            ItemForCalculationType.TextVisible = false;
            // 
            // ItemForSuperHipotecaMixta1YearTypeOfInterest
            // 
            ItemForSuperHipotecaMixta1YearTypeOfInterest.Control = SuperHipotecaMixta1YearTypeOfInterestTextEdit;
            ItemForSuperHipotecaMixta1YearTypeOfInterest.Location = new Point(0, 190);
            ItemForSuperHipotecaMixta1YearTypeOfInterest.Name = "ItemForSuperHipotecaMixta1YearTypeOfInterest";
            ItemForSuperHipotecaMixta1YearTypeOfInterest.Size = new Size(390, 38);
            ItemForSuperHipotecaMixta1YearTypeOfInterest.Text = "Super Hipoteca Mixta1Year Type Of Interest";
            ItemForSuperHipotecaMixta1YearTypeOfInterest.TextSize = new Size(0, 0);
            ItemForSuperHipotecaMixta1YearTypeOfInterest.TextVisible = false;
            // 
            // ItemForSuperHipotecaMixta2To5YearTypeOfInterest
            // 
            ItemForSuperHipotecaMixta2To5YearTypeOfInterest.Control = SuperHipotecaMixta2To5YearTypeOfInterestTextEdit;
            ItemForSuperHipotecaMixta2To5YearTypeOfInterest.Location = new Point(0, 228);
            ItemForSuperHipotecaMixta2To5YearTypeOfInterest.Name = "ItemForSuperHipotecaMixta2To5YearTypeOfInterest";
            ItemForSuperHipotecaMixta2To5YearTypeOfInterest.Size = new Size(390, 38);
            ItemForSuperHipotecaMixta2To5YearTypeOfInterest.Text = "Super Hipoteca Mixta2To5Year Type Of Interest";
            ItemForSuperHipotecaMixta2To5YearTypeOfInterest.TextSize = new Size(0, 0);
            ItemForSuperHipotecaMixta2To5YearTypeOfInterest.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textEditTypeOfInterest;
            layoutControlItem1.Location = new Point(0, 152);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(390, 38);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit;
            layoutControlItem3.Location = new Point(0, 266);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(390, 38);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = textEditTypeOfInterest;
            layoutControlItem2.Location = new Point(0, 152);
            layoutControlItem2.Name = "layoutControlItem1";
            layoutControlItem2.Size = new Size(390, 38);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // MortageOptionsUserControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataLayoutControl);
            Name = "MortageOptionsUserControl";
            Size = new Size(434, 432);
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl).EndInit();
            dataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)mortageOptionsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditTypeOfInterest.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)InitialCapitalTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)FirstPeriodDateDateEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)FirstPeriodDateDateEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfPeriodsTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CalculationTypeImageComboBoxEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)SuperHipotecaMixta1YearTypeOfInterestTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)SuperHipotecaMixta2To5YearTypeOfInterestTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForInitialCapital).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForFirstPeriodDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForNumberOfPeriods).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForCalculationType).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForSuperHipotecaMixta1YearTypeOfInterest).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForSuperHipotecaMixta2To5YearTypeOfInterest).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl;
        private DevExpress.XtraEditors.TextEdit InitialCapitalTextEdit;
        private BindingSource mortageOptionsBindingSource;
        private DevExpress.XtraEditors.DateEdit FirstPeriodDateDateEdit;
        private DevExpress.XtraEditors.TextEdit NumberOfPeriodsTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem ItemForInitialCapital;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFirstPeriodDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNumberOfPeriods;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.ImageComboBoxEdit CalculationTypeImageComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCalculationType;
        private DevExpress.XtraEditors.TextEdit textEditTypeOfInterest;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit SuperHipotecaMixta1YearTypeOfInterestTextEdit;
        private DevExpress.XtraEditors.TextEdit SuperHipotecaMixta2To5YearTypeOfInterestTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSuperHipotecaMixta1YearTypeOfInterest;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSuperHipotecaMixta2To5YearTypeOfInterest;
        private DevExpress.XtraEditors.TextEdit SuperHipotecaMixtaAfter5YearTypeOfInterestTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
