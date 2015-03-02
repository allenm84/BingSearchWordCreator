using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BingSearchWordCreator
{
  public interface IWordCreatorView
  {
    void AddStatus(string text);
    IButtonWidget Generate { get; }
    IButtonWidget Next { get; }
    IButtonWidget Previous { get; }
    INumericEntryWidget Words { get; }
    IWidget Count { get; }
    IWidget Result { get; }
    event EventHandler Load;
    void ShowError(string error);
    void Close();
    void IndicateWaiting(bool working);
    bool AllowUserInput { get; set; }
  }
}
