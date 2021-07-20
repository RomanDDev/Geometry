using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Geometry.ApplicationLayer.Enums;
using Geometry.ApplicationLayer.Interfaces;
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
            _view.OnSelectMode += View_OnSelectMode;
            _view.OnMoveMode += View_OnMoveMode;
            _view.OnDrawMode += View_OnDrawMode;
            _view.Paint += View_Paint;
        }

        private void UnsubscribeFromInputEvents()
        {
            _view.MouseDown += ViewOnMouseDown;
            _view.MouseMove += ViewOnMouseMove;
            _view.MouseUp += ViewOnMouseUp;
            _view.KeyPress += ViewOnKeyPress;
            _view.OnSelectMode -= View_OnSelectMode;
            _view.OnMoveMode -= View_OnMoveMode;
            _view.OnDrawMode -= View_OnDrawMode;
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
        }

        private void ViewOnMouseMove(object sender, MouseEventArgs e)
        {
            _currentTool?.HandleMouseMove(e);
        }

        private void ViewOnMouseDown(object sender, MouseEventArgs e)
        {
            _currentTool?.HandleMouseDown(e);
        }

        //Current editor tool depends on selected view mode
        private void View_OnDrawMode(object sender, EventArgs e)
        {
            UpdateCurrentTool(_toolDictionary[EditorModes.Drawing]);
        }

        private void View_OnMoveMode(object sender, EventArgs e)
        {
            UpdateCurrentTool(_toolDictionary[EditorModes.Movement]);
        }

        private void View_OnSelectMode(object sender, EventArgs e)
        {
            UpdateCurrentTool(_toolDictionary[EditorModes.Selection]);
        }

        #endregion

        /// <summary>
        /// View paint event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Paint event args</param>
        private void View_Paint(object sender, PaintEventArgs e)
        {
            foreach (var geometryShape in _shapesRepository.GetAllShapes())
                geometryShape.Draw(e.Graphics);
        }

        /// <summary>
        /// Unsubscribing from view events in the end
        /// </summary>
        public void Dispose()
        {
            UnsubscribeFromInputEvents();
        }
    }
}
