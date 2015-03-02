using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace BingSearchWordCreator
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      try
      {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

        SkinManager.EnableFormSkins();
        SkinManager.Default.RegisterAssembly(typeof(Office2010BlackBlue).Assembly);
        UserLookAndFeel.Default.SetSkinStyle("Office2010BlackBlue");

        Application.Run(new MainForm());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
      MessageBox.Show(e.ExceptionObject.ToString());
    }
  }
}
