using System.Windows.Forms;

namespace Geometry.ApplicationLayer.Interfaces
{
    /// <summary>
    /// Interface for an editor tool
    /// </summary>
    public interface IEditorTool
    {
        void HandleMouseUp(MouseEventArgs args);
        void HandleMouseDown(MouseEventArgs args);
        void HandleMouseMove(MouseEventArgs args);
        void HandleKeyPress(KeyPressEventArgs args);
        void Reset();
    }
}
