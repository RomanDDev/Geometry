using System.Drawing;

namespace Geometry.DomainLayer.Models.BaseShapes
{
    public abstract class PassiveShape : GeometryShape
    {
        public sealed override void DrawInteractivePoints(Graphics graphics) { }

        protected PassiveShape(int zIndex, Color backColor, Color borderColor, Rectangle containerRectangle) : base(
            zIndex, backColor, borderColor, containerRectangle)
        {
        }
    }
}
