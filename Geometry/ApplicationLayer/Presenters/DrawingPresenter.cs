using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Geometry.ApplicationLayer.Enums;
using Geometry.ApplicationLayer.EventArgs;
using Geometry.ApplicationLayer.Interfaces;
using Geometry.ApplicationLayer.Tools;
using Geometry.DomainLayer.Interfaces;
using Geometry.PresentationLayer.Interfaces;

namespace Geometry.ApplicationLayer.Presenters
{
    public class DrawingPresenter: IDisposable
    {
        private IEditorTool _currentTool;
        private readonly IEditorView _view;
        private readonly IShapeRepository _shapesRepository;
        private readonly Dictionary<EditorModes, IEditorTool> _toolDictionary;

        public DrawingPresenter(IEditorView view, IShapeRepository shapesRepository, Dictionary<EditorModes, IEditorTool> toolDictionary)
        {
            _view = view;
            _shapesRepository = shapesRepository;
            _toolDictionary = toolDictionary;
            SubscribeToInputEvents();
            _view.SetMode(EditorModes.Drawing);
        }

        /// <summary>
        /// Changing current editor tool to another one
        /// </summary>
        /// <param name="editorTool"></param>
        private void UpdateCurrentTool(IEditorTool editorTool)
        {
            if (ReferenceEquals(_currentTool, editorTool))
                throw new InvalidOperationException();
            _currentTool?.Reset();
            _currentTool = editorTool;
        }

        #region View events subscribtion

        private void SubscribeToInputEvents()
        {
            _view.MouseDown += ViewOnMouseDown;
            _view.MouseMove += ViewOnMouseMove;
            _view.MouseUp += ViewOnMouseUp;
            _view.KeyPress += ViewOnKeyPress;
            _view.OnEditorModeChanged += View_OnEditorModeChanged;
            _view.OnEditorBrushShapeChanged += ViewOnOnEditorBrushShapeChanged;
            _view.Paint += View_Paint;
        }

        private void UnsubscribeFromInputEvents()
        {
            _view.MouseDown += ViewOnMouseDown;
            _view.MouseMove += ViewOnMouseMove;
            _view.MouseUp += ViewOnMouseUp;
            _view.KeyPress += ViewOnKeyPress;
            _view.OnEditorModeChanged -= View_OnEditorModeChanged;
            _view.OnEditorBrushShapeChanged -= ViewOnOnEditorBrushShapeChanged;
            _view.Paint -= View_Paint;
        }

        //Passing view input events to current editor tool to handle
        private void ViewOnKeyPress(object sender, KeyPressEventArgs e)
        {
            _currentTool?.HandleKeyPress(e);
        }

        private void ViewOnMouseUp(object sender, MouseEventArgs e)
        {
            _currentTool?.HandleMouseUp(e);
            _view.Invalidate();
        }

        private void ViewOnMouseMove(object sender, MouseEventArgs e)
        {
            _currentTool?.HandleMouseMove(e);
        }

        private void ViewOnMouseDown(object sender, MouseEventArgs e)
        {
            _currentTool?.HandleMouseDown(e);
        }

        /// <summary>
        /// View paint event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Paint event args</param>
        private void View_Paint(object sender, PaintEventArgs e)
        {
            foreach (var geometryShape in _shapesRepository.GetAllShapes().OrderBy(item => item.ZIndex))
                geometryShape.Draw(e.Graphics);
        }

        /// <summary>
        /// Current editor tool depends on selected view mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void View_OnEditorModeChanged(object sender, EditorModeChangedEventArgs e)
        {
            UpdateCurrentTool(_toolDictionary[e.Mode]);
        }

        private void ViewOnOnEditorBrushShapeChanged(object sender, BrushShapeChangedEventArgs e)
        {
            if (!(_currentTool is DrawTool tool))
                throw new InvalidOperationException();
            tool.BrushShape = e.Shape;
        }

        /// <summary>
        /// Unsubscribing from view events in the end
        /// </summary>
        public void Dispose()
        {
            UnsubscribeFromInputEvents();
        }

        #endregion
    }
}
