namespace Geometry.PresentationLayer.Interfaces
{
    /// <summary>
    /// Main interface of winforms view
    /// </summary>
    public interface IEditorView: IEditorModesView, IInputView
    {
        void Show();
        void Close();
    }
}
