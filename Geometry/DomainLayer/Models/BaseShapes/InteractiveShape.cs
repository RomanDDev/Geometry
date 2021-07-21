using System.Collections.Generic;
using System.Drawing;

namespace Geometry.DomainLayer.Models.BaseShapes
{
    /// <summary>
    /// Base abstract class of shape with interactive points
    /// </summary>
    public abstract class InteractiveShape : GeometryShape
    {
        private const int InteractivePointWightAndHeight = 5;
        private static readonly Color PointFillColor = Color.Red;

        /// <summary>
        /// Point that user can interact with
        /// </summary>
        protected IEnumerable<Point> InteractivePoints { get; set; }

        protected InteractiveShape(int zIndex, Color backColor, Color borderColor, Rectangle containerRectangle) : base(
            zIndex, backColor, borderColor, containerRectangle)
        {
        }

        public sealed override void Move(int dx, int dy)
        {
            base.Move(dx, dy);
        }

        /// <inheritdoc/>
        protected sealed override void DrawInteractivePoints(Graphics graphics)
        {
            UpdateInteractivePoints();
            var brush = new SolidBrush(PointFillColor);
            var size = InteractivePointWightAndHeight;
            foreach (var interactivePoint in InteractivePoints)
            {
                graphics.FillRectangle(brush, interactivePoint.X - size / 2, interactivePoint.Y - size / 2, size, size);
            }
        }

        /// <summary>
        /// Update the interactive points
        /// </summary>
        //TODO: Pass the points collection as the method parameter in order not to be confused which collection must be updated
        protected abstract void UpdateInteractivePoints();

    }
}
