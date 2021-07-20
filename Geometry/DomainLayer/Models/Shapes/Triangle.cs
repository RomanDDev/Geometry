using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Geometry.DomainLayer.Models.BaseShapes;

namespace Geometry.DomainLayer.Models.Shapes
{
    public class Triangle: InteractiveShape
    {
        private readonly List<Point> _points;

        public Triangle(int zIndex, Color backColor, Color borderColor, Rectangle rectangle) : base(zIndex, backColor, borderColor, rectangle)
        {
            _points = new Point[3]
            {
                new Point(ContainerRectangle.Left, ContainerRectangle.Bottom),
                new Point(ContainerRectangle.Right, ContainerRectangle.Bottom),
                new Point(ContainerRectangle.Left + ContainerRectangle.Width / 2, ContainerRectangle.Top)
            }.ToList();
        }

        protected override void DrawBorder(Graphics graphics)
        {
            using var pen = new Pen(BorderColor);
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
