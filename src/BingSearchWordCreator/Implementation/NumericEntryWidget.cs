using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BingSearchWordCreator
{
  public class NumericEntryWidget : INumericEntryWidget
  {
    static Dictionary<SpinEdit, NumericEntryWidget> widgets = new Dictionary<SpinEdit, NumericEntryWidget>();
    private SpinEdit editor;

    public NumericEntryWidget(SpinEdit editor)
    {
      this.editor = editor;
    }

    #region INumericEntryWidget Members

    decimal INumericEntryWidget.Value
    {
      get { return editor.Value; }
      set { editor.Value = value; }
    }

    #endregion

    #region IWidget Members

    bool IWidget.Enabled
    {
      get { return editor.Enabled; }
      set { editor.Enabled = value; }
    }

    string IWidget.Text
    {
      get { return editor.Text; }
      set { editor.Text = value; }
    }

    #endregion

    public static INumericEntryWidget Create(SpinEdit editor)
    {
      NumericEntryWidget widget;
      if (!widgets.TryGetValue(editor, out widget))
      {
        widget = new NumericEntryWidget(editor);
        widgets[editor] = widget;
      }
      return widget;
    }
  }
}
