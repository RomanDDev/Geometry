using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Geometry.DomainLayer.Models.Shapes
{
    /// <summary>
    /// Represents the rhombus shape
    /// </summary>
    public class Rhombus : Quadrangle
    {
        /// <summary>
        /// The collection of points, defining the rhombus shape
        /// </summary>
        private readonly List<Point> _points;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="zIndex">Z coordinate of the shape</param>
        /// <param name="backColor"></param>
        /// <param name="borderColor"></param>
        /// <param name="containerRectangle">The rectangle in which the rhombus is inscribed</param>
        public Rhombus(int zIndex, Color backColor, Color borderColor, Rectangle containerRectangle) : base(zIndex, backColor,
            borderColor, containerRectangle)
        {
            _points = new Point[4]
            {
                new Point(containerRectangle.Left, containerRectangle.Top + containerRectangle.Height / 2),
                new Point(containerRectangle.Left + containerRectangle.Width / 2, containerRectangle.Top),
                new Point(containerRectangle.Right, containerRectangle.Top + containerRectangle.Height / 2),
                new Point(containerRectangle.Left + containerRectangle.Width / 2, containerRectangle.Bottom)
            }.ToList();
        }

        protected override void DrawBorder(Graphics graphics)
        {
            using var pen = new Pen(BorderColor,3);
            graphics.DrawPolygon(pen, _points.ToArray());
        }

        protected override void FillShape(Graphics graphics)
        {
            using var brush = new SolidBrush(Selected ? SelectedColor : BackColor);
            graphics.FillPolygon(brush, _points.ToArray());
        }

        protected override void UpdateInteractivePoints()
        {
            InteractivePoints = _points;
        }
    }
}
