using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Geometry.DomainLayer.Models.BaseShapes;

namespace Geometry.DomainLayer.Models.Shapes
{
    /// <summary>
    /// Represents the triangle shape
    /// </summary>
    public class Triangle: InteractiveShape
    {

        /// <summary>
        /// The collection of points, defining the triangle shape
        /// </summary>
        private readonly List<Point> _points;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="zIndex">Z coordinate of the shape</param>
        /// <param name="backColor"></param>
        /// <param name="borderColor"></param>
        /// <param name="containerRectangle">The rectangle in which the triangle is inscribed</param>
        public Triangle(int zIndex, Color backColor, Color borderColor, Rectangle containerRectangle) : base(zIndex, backColor, borderColor, containerRectangle)
        {
            _points = new Point[3]
            {
                new Point(containerRectangle.Left, containerRectangle.Bottom),
                new Point(containerRectangle.Right, containerRectangle.Bottom),
                new Point(containerRectangle.Left + containerRectangle.Width / 2, containerRectangle.Top)
            }.ToList();
        }

        protected override void DrawBorder(Graphics graphics)
        {
            using var pen = new Pen(BorderColor, 3);
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
