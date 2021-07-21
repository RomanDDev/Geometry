using System;
using System.Windows.Forms;
using Geometry.ApplicationLayer.Interfaces;
using Geometry.DomainLayer.Interfaces;

namespace Geometry.ApplicationLayer.Tools
{
    /// <summary>
    /// Tool for moving selected shapes
    /// </summary>
    public class MoveTool: IEditorTool
    {
        private readonly IShapeRepository _shapeRepository;

        public MoveTool(IShapeRepository repository)
        {
            _shapeRepository = repository;
        }

        public void HandleMouseUp(MouseEventArgs args)
        {
            throw new NotImplementedException();
        }

        public void HandleMouseDown(MouseEventArgs args)
        {
            throw new NotImplementedException();
        }

        public void HandleMouseMove(MouseEventArgs args)
        {
            //do nothing yet
        }

        public void HandleKeyPress(KeyPressEventArgs args)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
