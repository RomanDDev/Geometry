using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Geometry.ApplicationLayer;
using Geometry.ApplicationLayer.Enums;
using Geometry.ApplicationLayer.Interfaces;
using Geometry.ApplicationLayer.Presenters;
using Geometry.ApplicationLayer.Tools;
using Geometry.DomainLayer.Interfaces;
using Geometry.DomainLayer.Repositories;

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
            var shapeRepository = new ShapesRepository();
            var form = new DrawingForm();
            var drawingPresenter = new DrawingPresenter(form, shapeRepository, CreateToolDictionary(shapeRepository));
            Application.Run(form);
        }

        private static Dictionary<EditorModes, IEditorTool> CreateToolDictionary(IShapeRepository repository)
        {
            return new Dictionary<EditorModes, IEditorTool>
            {
                {EditorModes.Drawing, new DrawTool(repository)},
                {EditorModes.Movement, new MoveTool(repository)},
                {EditorModes.Selection, new SelectTool(repository)}
            };
        }
    }
}
