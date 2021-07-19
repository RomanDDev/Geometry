using Geometry.PresentationLayer.Interfaces;

namespace Geometry.ApplicationLayer
{
    public class DrawingPresenter
    {
        private readonly IEditorView _view;

        public DrawingPresenter(IEditorView view)
        {
            _view = view;
        }
    }
}
