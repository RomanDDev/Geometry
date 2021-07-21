using System.Drawing;

namespace Geometry.DomainLayer.Models.BaseShapes
{
    /// <summary>
    /// Base class for shapes that haven`t got any interactive points
    /// </summary>
    public abstract class PassiveShape : GeometryShape
    {
        protected sealed override void DrawInteractivePoints(Graphics graphics) { }

        protected PassiveShape(int zIndex, Color backColor, Color borderColor, Rectangle containerRectangle) : base(
            zIndex, backColor, borderColor, containerRectangle)
        {
        }
    }
}
