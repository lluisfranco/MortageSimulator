namespace MortageSimulator
{
    partial class MortageOptionsCustomRangeslListEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MortageOptionsCustomRangeslListEditorForm));
            mortageOptionsCustomRangesListUserControl = new MortageOptionsCustomRangesListUserControl();
            simpleButtonOk = new DevExpress.XtraEditors.SimpleButton();
            simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // mortageOptionsCustomRangesListUserControl
            // 
            mortageOptionsCustomRangesListUserControl.Location = new Point(3, 3);
            mortageOptionsCustomRangesListUserControl.Name = "mortageOptionsCustomRangesListUserControl";
            mortageOptionsCustomRangesListUserControl.ReadOnly = false;
            mortageOptionsCustomRangesListUserControl.Size = new Size(525, 395);
            mortageOptionsCustomRangesListUserControl.TabIndex = 13;
            // 
            // simpleButtonOk
            // 
            simpleButtonOk.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            simpleButtonOk.Appearance.Options.UseBackColor = true;
            simpleButtonOk.Location = new Point(322, 407);
            simpleButtonOk.Name = "simpleButtonOk";
            simpleButtonOk.Size = new Size(95, 26);
            simpleButtonOk.TabIndex = 14;
            simpleButtonOk.Text = "Ok";
            // 
            // simpleButtonCancel
            // 
            simpleButtonCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            simpleButtonCancel.Appearance.Options.UseBackColor = true;
            simpleButtonCancel.DialogResult = DialogResult.Cancel;
            simpleButtonCancel.Location = new Point(423, 407);
            simpleButtonCancel.Name = "simpleButtonCancel";
            simpleButtonCancel.Size = new Size(95, 26);
            simpleButtonCancel.TabIndex = 15;
            simpleButtonCancel.Text = "Cancel";
            // 
            // MortageOptionsCustomRangeslListEditorForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 442);
            Controls.Add(simpleButtonCancel);
            Controls.Add(simpleButtonOk);
            Controls.Add(mortageOptionsCustomRangesListUserControl);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("MortageOptionsCustomRangeslListEditorForm.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MortageOptionsCustomRangeslListEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Custom Ranges";
            ResumeLayout(false);
        }

        #endregion

        private MortageOptionsCustomRangesListUserControl mortageOptionsCustomRangesListUserControl;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOk;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
    }
}