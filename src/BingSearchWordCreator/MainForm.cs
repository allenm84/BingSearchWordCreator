using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;

namespace BingSearchWordCreator
{
  public partial class MainForm : XtraForm, IWordCreatorView
  {
    private WordCreatorController controller;

    public MainForm()
    {
      InitializeComponent();
      MinimumSize = Size;
      controller = new WordCreatorController(this);
    }

    private void AddStatusItem(string text)
    {
      if (lstStatus.InvokeRequired)
      {
        lstStatus.BeginInvoke(new Action<string>(AddStatusItem), text);
      }
      else
      {
        var index = lstStatus.Items.Add(text);
        lstStatus.SelectedIndex = index;
      }
    }

    #region IWordCreatorView Members

    void IWordCreatorView.AddStatus(string text)
    {
      AddStatusItem(text);
    }

    IButtonWidget IWordCreatorView.Generate
    {
      get { return ButtonWidget.Create(btnGenerate); }
    }

    IButtonWidget IWordCreatorView.Next
    {
      get { return ButtonWidget.Create(btnNext); }
    }

    IButtonWidget IWordCreatorView.Previous
    {
      get { return ButtonWidget.Create(btnPrev); }
    }

    INumericEntryWidget IWordCreatorView.Words
    {
      get { return NumericEntryWidget.Create(numWordCount); }
    }

    IWidget IWordCreatorView.Count
    {
      get { return ControlWidget.Create(lblCount); }
    }

    IWidget IWordCreatorView.Result
    {
      get { return ControlWidget.Create(txtWord); }
    }

    event EventHandler IWordCreatorView.Load
    {
      add { base.Load += value; }
      remove { base.Load -= value; }
    }

    void IWordCreatorView.ShowError(string error)
    {
      XtraMessageBox.Show(this, error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    void IWordCreatorView.Close()
    {
      base.Close();
    }

    void IWordCreatorView.IndicateWaiting(bool working)
    {
      Cursor = working ? Cursors.WaitCursor : Cursors.Default;
      layoutControlItem8.Visibility = working
        ? LayoutVisibility.Always
        : LayoutVisibility.Never;
    }

    bool IWordCreatorView.AllowUserInput
    {
      get { return layoutControlGroup2.Enabled; }
      set 
      { 
        layoutControlGroup2.Enabled = value;
        layoutControlGroup3.Enabled = value;
      }
    }

    #endregion
  }
}
