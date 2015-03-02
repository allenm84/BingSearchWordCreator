using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BingSearchWordCreator
{
  public interface IWidget
  {
    bool Enabled { get; set; }
    string Text { get; set; }
  }
}
