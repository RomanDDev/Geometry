using System;
using System.Drawing;
using Geometry.DomainLayer.Models.BaseShapes;

namespace Geometry.DomainLayer.Models.Shapes
{
    public class Circle : PassiveShape
    {
        private Point _center;
        private readonly int _radius;

        public Circle(int zIndex, Color backColor, Color borderColor, Rectangle containerRectangle) : base(zIndex,
            backColor, borderColor, containerRectangle)
        {
            _radius = Math.Min(containerRectangle.Width, containerRectangle.Height)/2;
            _center = new Point(containerRectangle.X + _radius, containerRectangle.Y + _radius);
        }

        public override void DrawBorder(Graphics graphics)
        {
            throw new NotImplementedException();
        }

        public override void FillShape(Graphics graphics)
        {
            throw new NotImplementedException();
        }
    }
}
