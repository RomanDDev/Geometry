using System;
using System.Drawing;
using System.Windows.Forms;
using Geometry.ApplicationLayer.Interfaces;
using Geometry.DomainLayer.Interfaces;

namespace Geometry.ApplicationLayer.Tools
{
    public abstract class BaseTool : IEditorTool
    {
        private Point? _startMousePoint;
        protected readonly IShapeRepository ShapeRepository;

        protected BaseTool(IShapeRepository repository)
        {
            ShapeRepository = repository;
        }

        public void HandleMouseUp(MouseEventArgs args)
        {
            if (_startMousePoint is null)
                throw new InvalidOperationException();
            var startX = _startMousePoint.Value.X;
            var startY = _startMousePoint.Value.Y;
            var endX = args.X;
            var endY = args.Y;
            var width = Math.Abs(startX - endX);
            var height = Math.Abs(startY - endY);
            _startMousePoint = null;
            var selectionRectangle = new Rectangle((startX < endX) ? startX : endX, (startY < endY) ? startY : endY,
                width, height);
            HandleMouseUp(selectionRectangle);
        }

        protected abstract void HandleMouseUp(Rectangle selectionRectangle);

        public void HandleMouseDown(MouseEventArgs args)
        {
            _startMousePoint = args.Location;
            HandleMouseDown(_startMousePoint);
        }

        protected abstract void HandleMouseDown(Point? startMousePoint);

        public void HandleMouseMove(MouseEventArgs args)
        {
            //draw borders of selection
        }

        public void HandleKeyPress(KeyPressEventArgs args)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            _startMousePoint = null;
        }
    }
}
