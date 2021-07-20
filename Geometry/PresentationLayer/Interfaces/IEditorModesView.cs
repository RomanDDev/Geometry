using System;
using Geometry.ApplicationLayer.Enums;
using Geometry.ApplicationLayer.EventArgs;

namespace Geometry.PresentationLayer.Interfaces
{
    public interface IEditorModesView
    {
        /// <summary>
        /// Fires on switching editor tool
        /// </summary>
        event EventHandler<EditorModeChangedEventArgs> OnEditorModeChanged;

        /// <summary>
        /// Fires on switching brush shape
        /// </summary>
        event EventHandler<BrushShapeChangedEventArgs> OnEditorBrushShapeChanged;

        /// <summary>
        /// Sets the editor mode of view
        /// </summary>
        /// <param name="mode"></param>
        void SetMode(EditorModes mode);
    }
}
