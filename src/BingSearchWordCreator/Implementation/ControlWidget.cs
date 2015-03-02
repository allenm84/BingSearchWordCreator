using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BingSearchWordCreator
{
  public class ControlWidget : IWidget
  {
    static Dictionary<Control, ControlWidget> widgets = new Dictionary<Control, ControlWidget>();
    private Control control;

    public ControlWidget(Control control)
    {
      this.control = control;
    }

    #region IWidget Members

    bool IWidget.Enabled
    {
      get { return control.Enabled; }
      set { control.Enabled = value; }
    }

    string IWidget.Text
    {
      get { return control.Text; }
      set { control.Text = value; }
    }

    #endregion

    public static IWidget Create(Control control)
    {
      ControlWidget widget;
      if (!widgets.TryGetValue(control, out widget))
      {
        widget = new ControlWidget(control);
        widgets[control] = widget;
      }
      return widget;
    }
  }
}
