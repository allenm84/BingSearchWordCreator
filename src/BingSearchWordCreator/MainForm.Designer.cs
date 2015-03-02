namespace BingSearchWordCreator
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.lstStatus = new DevExpress.XtraEditors.ListBoxControl();
      this.lblCount = new DevExpress.XtraEditors.LabelControl();
      this.btnNext = new DevExpress.XtraEditors.SimpleButton();
      this.txtWord = new DevExpress.XtraEditors.TextEdit();
      this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
      this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
      this.numWordCount = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      this.progStatus = new DevExpress.XtraEditors.MarqueeProgressBarControl();
      this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lstStatus)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtWord.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numWordCount.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.progStatus.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.progStatus);
      this.layoutControl1.Controls.Add(this.lstStatus);
      this.layoutControl1.Controls.Add(this.lblCount);
      this.layoutControl1.Controls.Add(this.btnNext);
      this.layoutControl1.Controls.Add(this.txtWord);
      this.layoutControl1.Controls.Add(this.btnPrev);
      this.layoutControl1.Controls.Add(this.btnGenerate);
      this.layoutControl1.Controls.Add(this.numWordCount);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(608, 109, 549, 552);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(276, 319);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // lstStatus
      // 
      this.lstStatus.Location = new System.Drawing.Point(12, 167);
      this.lstStatus.Name = "lstStatus";
      this.lstStatus.Size = new System.Drawing.Size(252, 114);
      this.lstStatus.StyleController = this.layoutControl1;
      this.lstStatus.TabIndex = 10;
      // 
      // lblCount
      // 
      this.lblCount.Location = new System.Drawing.Point(114, 150);
      this.lblCount.Name = "lblCount";
      this.lblCount.Size = new System.Drawing.Size(47, 13);
      this.lblCount.StyleController = this.layoutControl1;
      this.lblCount.TabIndex = 9;
      this.lblCount.Text = "0 out of 0";
      // 
      // btnNext
      // 
      this.btnNext.AutoWidthInLayoutControl = true;
      this.btnNext.Location = new System.Drawing.Point(232, 112);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(20, 22);
      this.btnNext.StyleController = this.layoutControl1;
      this.btnNext.TabIndex = 8;
      this.btnNext.Text = ">";
      // 
      // txtWord
      // 
      this.txtWord.Location = new System.Drawing.Point(48, 113);
      this.txtWord.Name = "txtWord";
      this.txtWord.Properties.ReadOnly = true;
      this.txtWord.Properties.UseReadOnlyAppearance = false;
      this.txtWord.Size = new System.Drawing.Size(180, 20);
      this.txtWord.StyleController = this.layoutControl1;
      this.txtWord.TabIndex = 7;
      // 
      // btnPrev
      // 
      this.btnPrev.AutoWidthInLayoutControl = true;
      this.btnPrev.Location = new System.Drawing.Point(24, 112);
      this.btnPrev.Name = "btnPrev";
      this.btnPrev.Size = new System.Drawing.Size(20, 22);
      this.btnPrev.StyleController = this.layoutControl1;
      this.btnPrev.TabIndex = 6;
      this.btnPrev.Text = "<";
      // 
      // btnGenerate
      // 
      this.btnGenerate.Location = new System.Drawing.Point(178, 43);
      this.btnGenerate.Name = "btnGenerate";
      this.btnGenerate.Size = new System.Drawing.Size(74, 22);
      this.btnGenerate.StyleController = this.layoutControl1;
      this.btnGenerate.TabIndex = 5;
      this.btnGenerate.Text = "Generate";
      // 
      // numWordCount
      // 
      this.numWordCount.EditValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.numWordCount.Location = new System.Drawing.Point(24, 44);
      this.numWordCount.Name = "numWordCount";
      this.numWordCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numWordCount.Properties.IsFloatValue = false;
      this.numWordCount.Properties.Mask.EditMask = "N00";
      this.numWordCount.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numWordCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numWordCount.Size = new System.Drawing.Size(150, 20);
      this.numWordCount.StyleController = this.layoutControl1;
      this.numWordCount.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(276, 319);
      this.layoutControlGroup1.Text = "layoutControlGroup1";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.CustomizationFormText = "Number of words to generate:";
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(256, 69);
      this.layoutControlGroup2.Text = "Number of words to generate:";
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.btnGenerate;
      this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
      this.layoutControlItem2.Location = new System.Drawing.Point(154, 0);
      this.layoutControlItem2.MaxSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem2.MinSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(78, 26);
      this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem2.Text = "layoutControlItem2";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextToControlDistance = 0;
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.numWordCount;
      this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
      this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(154, 26);
      this.layoutControlItem1.Text = "layoutControlItem1";
      this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextToControlDistance = 0;
      this.layoutControlItem1.TextVisible = false;
      this.layoutControlItem1.TrimClientAreaToControl = false;
      // 
      // layoutControlGroup3
      // 
      this.layoutControlGroup3.CustomizationFormText = "Words:";
      this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
      this.layoutControlGroup3.Location = new System.Drawing.Point(0, 69);
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new System.Drawing.Size(256, 69);
      this.layoutControlGroup3.Text = "Words:";
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.btnPrev;
      this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(24, 26);
      this.layoutControlItem3.Text = "layoutControlItem3";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextToControlDistance = 0;
      this.layoutControlItem3.TextVisible = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.txtWord;
      this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
      this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
      this.layoutControlItem4.Location = new System.Drawing.Point(24, 0);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(184, 26);
      this.layoutControlItem4.Text = "layoutControlItem4";
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextToControlDistance = 0;
      this.layoutControlItem4.TextVisible = false;
      this.layoutControlItem4.TrimClientAreaToControl = false;
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.btnNext;
      this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
      this.layoutControlItem5.Location = new System.Drawing.Point(208, 0);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(24, 26);
      this.layoutControlItem5.Text = "layoutControlItem5";
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextToControlDistance = 0;
      this.layoutControlItem5.TextVisible = false;
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.lblCount;
      this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
      this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
      this.layoutControlItem6.Location = new System.Drawing.Point(0, 138);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(256, 17);
      this.layoutControlItem6.Text = "layoutControlItem6";
      this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem6.TextToControlDistance = 0;
      this.layoutControlItem6.TextVisible = false;
      this.layoutControlItem6.TrimClientAreaToControl = false;
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.Control = this.lstStatus;
      this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
      this.layoutControlItem7.Location = new System.Drawing.Point(0, 155);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new System.Drawing.Size(256, 118);
      this.layoutControlItem7.Text = "layoutControlItem7";
      this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem7.TextToControlDistance = 0;
      this.layoutControlItem7.TextVisible = false;
      // 
      // progStatus
      // 
      this.progStatus.Location = new System.Drawing.Point(12, 285);
      this.progStatus.Name = "progStatus";
      this.progStatus.Size = new System.Drawing.Size(252, 22);
      this.progStatus.StyleController = this.layoutControl1;
      this.progStatus.TabIndex = 11;
      // 
      // layoutControlItem8
      // 
      this.layoutControlItem8.Control = this.progStatus;
      this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
      this.layoutControlItem8.Location = new System.Drawing.Point(0, 273);
      this.layoutControlItem8.MaxSize = new System.Drawing.Size(256, 26);
      this.layoutControlItem8.MinSize = new System.Drawing.Size(256, 26);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new System.Drawing.Size(256, 26);
      this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem8.Text = "layoutControlItem8";
      this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem8.TextToControlDistance = 0;
      this.layoutControlItem8.TextVisible = false;
      // 
      // MainForm
      // 
      this.Appearance.Options.UseFont = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(276, 319);
      this.Controls.Add(this.layoutControl1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Bing Search Word Creator";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.lstStatus)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtWord.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numWordCount.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.progStatus.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.SpinEdit numWordCount;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.SimpleButton btnGenerate;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.SimpleButton btnNext;
    private DevExpress.XtraEditors.TextEdit txtWord;
    private DevExpress.XtraEditors.SimpleButton btnPrev;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraEditors.LabelControl lblCount;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private DevExpress.XtraEditors.ListBoxControl lstStatus;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private DevExpress.XtraEditors.MarqueeProgressBarControl progStatus;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;

  }
}