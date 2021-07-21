using System.Windows.Forms;

namespace Geometry.PresentationLayer.Interfaces
{
    /// <summary>
    /// Main interface of winforms view
    /// </summary>
    public interface IEditorView: IEditorModesView, IInputView, IMessenger
    {
        event PaintEventHandler Paint;
        void Invalidate();
    }
}
