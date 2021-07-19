using System.Windows.Forms;

namespace Geometry.PresentationLayer.Interfaces
{
    /// <summary>
    /// Interface of view, that can handle some mouse and keyboard events
    /// </summary>
    public interface IInputView
    {
        event MouseEventHandler MouseDown;
        event MouseEventHandler MouseUp;
        event MouseEventHandler MouseMove;
        event KeyPressEventHandler KeyPress;
    }
}
