using System.Drawing;
using Geometry.DomainLayer.Models.BaseShapes;

namespace Geometry.DomainLayer.Models.Shapes
{
    public class Circle : PassiveShape
    {
        public Circle(int zIndex, Color backColor, Color borderColor, Rectangle containerRectangle) : base(zIndex,
            backColor, borderColor, containerRectangle)
        { }

        protected override void DrawBorder(Graphics graphics)
        {
            using var pen = new Pen(BorderColor, 3);
            graphics.DrawEllipse(pen, ContainerRectangle);
        }

        protected override void FillShape(Graphics graphics)
        {
            using var brush = new SolidBrush(Selected ? SelectedColor : BackColor);
            graphics.FillEllipse(brush, ContainerRectangle);
        }
    }
}
