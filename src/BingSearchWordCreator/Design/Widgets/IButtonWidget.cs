using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BingSearchWordCreator
{
  public interface IButtonWidget : IWidget
  {
    event EventHandler Click;
  }
}
