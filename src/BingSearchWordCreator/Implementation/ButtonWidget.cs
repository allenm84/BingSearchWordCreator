using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BingSearchWordCreator
{
  public class ButtonWidget : IButtonWidget
  {
    static Dictionary<SimpleButton, ButtonWidget> widgets = new Dictionary<SimpleButton, ButtonWidget>();
    private SimpleButton button;

    public ButtonWidget(SimpleButton button)
    {
      this.button = button;
    }

    #region IButtonWidget Members

    event EventHandler IButtonWidget.Click
    {
      add { button.Click += value; }
      remove { button.Click -= value; }
    }

    #endregion

    #region IWidget Members

    bool IWidget.Enabled
    {
      get { return button.Enabled; }
      set { button.Enabled = value; }
    }

    string IWidget.Text
    {
      get { return button.Text; }
      set { button.Text = value; }
    }

    #endregion

    public static IButtonWidget Create(SimpleButton button)
    {
      ButtonWidget widget;
      if (!widgets.TryGetValue(button, out widget))
      {
        widget = new ButtonWidget(button);
        widgets[button] = widget;
      }
      return widget;
    }
  }
}
