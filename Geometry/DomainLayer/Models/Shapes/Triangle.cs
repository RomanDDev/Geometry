using System;
using System.Drawing;
using Geometry.DomainLayer.Models.BaseShapes;

namespace Geometry.DomainLayer.Models.Shapes
{
    public class Triangle: InteractiveShape
    {
        public Triangle(int zIndex, Color backColor, Color borderColor, Rectangle rectangle) : base(zIndex, backColor, borderColor, rectangle)
        {
        }

        public override void DrawBorder(Graphics graphics)
        {
            throw new NotImplementedException();
        }

        public override void FillShape(Graphics graphics)
        {
            throw new NotImplementedException();
        }

        protected override void UpdateInteractivePoints()
        {
            var points = new Point[3]
            {
                new Point(ContainerRectangle.Left, ContainerRectangle.Bottom),
                new Point(ContainerRectangle.Right, ContainerRectangle.Bottom),
                new Point(ContainerRectangle.Left + ContainerRectangle.Width / 2, ContainerRectangle.Top)
            };
            InteractivePoints = points;
        }
    }
}
