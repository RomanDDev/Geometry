using System;
using Geometry.ApplicationLayer.Enums;

namespace Geometry.PresentationLayer.Interfaces
{
    public interface IEditorModesView
    {
        /// <summary>
        /// Fires on switching mode to selection
        /// </summary>
        event EventHandler<System.EventArgs> OnSelectMode;

        /// <summary>
        /// Fires on switching mode to shape movement
        /// </summary>
        event EventHandler<System.EventArgs> OnMoveMode;

        /// <summary>
        /// Fires on switching mode to shape drawing
        /// </summary>
        event EventHandler<System.EventArgs> OnDrawMode;

        /// <summary>
        /// Sets the editor mode of view
        /// </summary>
        /// <param name="mode"></param>
        void SetMode(EditorModes mode);
    }
}
