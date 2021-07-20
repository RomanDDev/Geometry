using System.Drawing;
using System.Linq;
using Geometry.DomainLayer.Models.BaseShapes;

namespace Geometry.DomainLayer.Models.Shapes
{
    public class Quadrangle : InteractiveShape
    {
        public Quadrangle(int zIndex, Color backColor, Color borderColor, Rectangle rectangle) : base(zIndex, backColor, borderColor, rectangle)
        {
        }

        protected override void DrawBorder(Graphics graphics)
        {
            using var pen = new Pen(BorderColor,3);
            graphics.DrawRectangle(pen, ContainerRectangle);
        }

        protected override void FillShape(Graphics graphics)
        {
            using var brush = new SolidBrush(Selected ? SelectedColor : BackColor);
            graphics.FillRectangle(brush, ContainerRectangle);
        }

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
