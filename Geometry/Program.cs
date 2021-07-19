using System;
using System.Windows.Forms;
using Geometry.ApplicationLayer;

namespace Geometry
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new DrawingForm();
            var drawingPresenter = new DrawingPresenter(form);
            Application.Run(form);
        }
    }
}
