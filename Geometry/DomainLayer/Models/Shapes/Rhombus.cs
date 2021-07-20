using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Geometry.DomainLayer.Models.Shapes
{
    public class Rhombus : Quadrangle
    {
        private readonly List<Point> _points;

        public Rhombus(int zIndex, Color backColor, Color borderColor, Rectangle rectangle) : base(zIndex, backColor,
            borderColor, rectangle)
        {
            _points = new Point[4]
            {
                new Point(ContainerRectangle.Left, ContainerRectangle.Top + ContainerRectangle.Height / 2),
                new Point(ContainerRectangle.Left + ContainerRectangle.Width / 2, ContainerRectangle.Top),
                new Point(ContainerRectangle.Right, ContainerRectangle.Top + ContainerRectangle.Height / 2),
                new Point(ContainerRectangle.Left + ContainerRectangle.Width / 2, ContainerRectangle.Bottom)
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
