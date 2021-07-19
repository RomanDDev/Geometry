using System.Drawing;

namespace Geometry.DomainLayer.Models
{
    /// <summary>
    /// Basic abstract class for geometrical shapes
    /// </summary>
    public abstract class GeometryShape
    {
        private int _zIndex;
        private Color _backColor;
        private Color _borderColor;

        /// <summary>
        /// Order of elements. 
        /// An element with greater index is in front of an element with lower index.
        /// </summary>
        public int ZIndex
        {
            get => _zIndex;
            set { _zIndex = value; }
        }

        /// <summary>
        /// Fill color
        /// </summary>
        public Color BackColor => _backColor;

        /// <summary>
        /// The color of shape border
        /// </summary>
        public Color BorderColor => _borderColor;

        /// <summary>
        /// Draws the shape using the graphics
        /// </summary>
        /// <param name="graphics">Drawing surface</param>
        public abstract void Draw(Graphics graphics);

        /// <summary>
        /// Handler for shape selection
        /// </summary>
        public abstract void Select();

        /// <summary>
        /// Handler for shape movement
        /// </summary>
        /// <param name="dx">delta x</param>
        /// <param name="dy">delta y</param>
        public abstract void Move(int dx, int dy);

        /// <summary>
        /// Either the shape can be moved or not using the displacements
        /// </summary>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <param name="container">The rectangle, that determines the drawing surface</param>
        /// <returns>Returns true if the shape can be moved, otherwise - false</returns>
        public abstract bool CanMove(int dx, int dy, Rectangle container);
    }
}
