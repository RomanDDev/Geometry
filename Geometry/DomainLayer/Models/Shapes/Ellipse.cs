using System.Drawing;
using Geometry.DomainLayer.Models.BaseShapes;

namespace Geometry.DomainLayer.Models.Shapes
{
    /// <summary>
    /// The ellipse shape class
    /// </summary>
    public class Ellipse : PassiveShape
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="zIndex">Z coordinate of the shape</param>
        /// <param name="backColor"></param>
        /// <param name="borderColor"></param>
        /// <param name="containerRectangle">The rectangle in which the ellipse is inscribed</param>
        public Ellipse(int zIndex, Color backColor, Color borderColor, Rectangle containerRectangle) : base(zIndex,
            backColor, borderColor, containerRectangle)
        { }

        /// <inheritdoc/>
        protected override void DrawBorder(Graphics graphics)
        {
            using var pen = new Pen(BorderColor, 3);
            graphics.DrawEllipse(pen, ContainerRectangle);
        }

        /// <inheritdoc/>
        protected override void FillShape(Graphics graphics)
        {
            using var brush = new SolidBrush(Selected ? SelectedColor : BackColor);
            graphics.FillEllipse(brush, ContainerRectangle);
        }
    }
}
