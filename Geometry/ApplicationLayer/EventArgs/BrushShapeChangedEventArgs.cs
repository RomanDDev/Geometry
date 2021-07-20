using Geometry.ApplicationLayer.Enums;

namespace Geometry.ApplicationLayer.EventArgs
{
    public class BrushShapeChangedEventArgs : System.EventArgs
    {
        public BrushShapes Shape { get; }

        public BrushShapeChangedEventArgs(BrushShapes shape)
        {
            Shape = shape;
        }
    }
}
