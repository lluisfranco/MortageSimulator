namespace MortageSimulator
{
    partial class MortageOptionsCustomRangesListUserControl
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
            gridControl = new DevExpress.XtraGrid.GridControl();
            mortageCustomRangeBindingSource = new BindingSource(components);
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colNumberOfPeriods = new DevExpress.XtraGrid.Columns.GridColumn();
            colTypeOfInterest = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mortageCustomRangeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // gridControl
            // 
            gridControl.DataSource = mortageCustomRangeBindingSource;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(0, 0);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(489, 339);
            gridControl.TabIndex = 12;
            gridControl.UseEmbeddedNavigator = true;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // mortageCustomRangeBindingSource
            // 
            mortageCustomRangeBindingSource.DataSource = typeof(MortageCustomRange);
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colNumberOfPeriods, colTypeOfInterest });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowFooter = true;
            gridView.OptionsView.ShowGroupPanel = false;
            // 
            // colNumberOfPeriods
            // 
            colNumberOfPeriods.FieldName = "NumberOfPeriods";
            colNumberOfPeriods.Name = "colNumberOfPeriods";
            colNumberOfPeriods.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NumberOfPeriods", "{0}") });
            colNumberOfPeriods.Visible = true;
            colNumberOfPeriods.VisibleIndex = 0;
            // 
            // colTypeOfInterest
            // 
            colTypeOfInterest.FieldName = "TypeOfInterest";
            colTypeOfInterest.Name = "colTypeOfInterest";
            colTypeOfInterest.Visible = true;
            colTypeOfInterest.VisibleIndex = 1;
            // 
            // MortageOptionsCustomRangesListUserControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridControl);
            Name = "MortageOptionsCustomRangesListUserControl";
            Size = new Size(489, 339);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)mortageCustomRangeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private BindingSource mortageCustomRangeBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberOfPeriods;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeOfInterest;
    }
}
