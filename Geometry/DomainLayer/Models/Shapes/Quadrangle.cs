using System.Drawing;
using Geometry.DomainLayer.Models.BaseShapes;

namespace Geometry.DomainLayer.Models.Shapes
{
    /// <summary>
    /// Represents the rectangle shape
    /// </summary>
    public class Quadrangle : InteractiveShape
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="zIndex">Z coordinate of the shape</param>
        /// <param name="backColor"></param>
        /// <param name="borderColor"></param>
        /// <param name="containerRectangle">Actual quadrangle borders</param>
        public Quadrangle(int zIndex, Color backColor, Color borderColor, Rectangle containerRectangle) : base(zIndex, backColor, borderColor, containerRectangle)
        {
        }

        /// <inheritdoc/>
        protected override void DrawBorder(Graphics graphics)
        {
            using var pen = new Pen(BorderColor,3);
            graphics.DrawRectangle(pen, ContainerRectangle);
        }

        /// <inheritdoc/>
        protected override void FillShape(Graphics graphics)
        {
            using var brush = new SolidBrush(Selected ? SelectedColor : BackColor);
            graphics.FillRectangle(brush, ContainerRectangle);
        }

        /// <inheritdoc/>
        protected override void UpdateInteractivePoints()
        {
            InteractivePoints = new Point[4]
            {
                new Point(ContainerRectangle.Left, ContainerRectangle.Bottom),
                new Point(ContainerRectangle.Right, ContainerRectangle.Bottom),
                new Point(ContainerRectangle.Left, ContainerRectangle.Top),
                new Point(ContainerRectangle.Right, ContainerRectangle.Top)
            };
        }
    }
}
