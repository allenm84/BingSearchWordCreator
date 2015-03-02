using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BingSearchWordCreator
{
  public interface INumericEntryWidget : IWidget
  {
    decimal Value { get; set; }
  }
}
