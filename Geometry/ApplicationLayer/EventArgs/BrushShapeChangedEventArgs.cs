using Geometry.ApplicationLayer.Enums;

namespace Geometry.ApplicationLayer.EventArgs
{
    /// <summary>
    /// Event args to store current selected brush shape
    /// </summary>
    public class BrushShapeChangedEventArgs : System.EventArgs
    {
        public BrushShapes Shape { get; }

        public BrushShapeChangedEventArgs(BrushShapes shape)
        {
            Shape = shape;
        }
    }
}
