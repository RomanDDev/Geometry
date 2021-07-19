using System;
using System.Drawing;

namespace Geometry.DomainLayer.Models.BaseShapes
{
    /// <summary>
    /// Basic abstract class for geometrical shapes
    /// </summary>
    public abstract class GeometryShape
    {
        private Rectangle _containerRectangle;
        private readonly int _zIndex;
        private readonly Color _backColor;
        private readonly Color _borderColor;

        /// <summary>
        /// Order of elements. 
        /// An element with greater index is in front of an element with lower index.
        /// </summary>
        public int ZIndex => _zIndex;
        
        /// <summary>
        /// Fill color
        /// </summary>
        public Color BackColor => _backColor;

        /// <summary>
        /// The color of shapes border
        /// </summary>
        public Color BorderColor => _borderColor;

        /// <summary>
        /// Rectangle, in which the shape is inscribed
        /// </summary>
        public Rectangle ContainerRectangle => _containerRectangle;

        protected GeometryShape(int zIndex, Color backColor, Color borderColor, Rectangle containerRectangle)
        {
            _zIndex = zIndex;
            _backColor = backColor;
            _borderColor = borderColor;
            _containerRectangle = containerRectangle;
        }

        /// <summary>
        /// Either the shape contains the point or not
        /// </summary>
        /// <param name="p"></param>
        /// <returns>True if the point is inside the shape borders, otherwise - false</returns>
        public bool ContainsPoint(Point p)
        {
            return _containerRectangle.Contains(p);
        }

        /// <summary>
        /// Either the shapes container rectangle intersects with given rectangle or not
        /// </summary>
        /// <param name="rect">The rectangle to check intersection</param>
        /// <returns>True if they intersect, otherwise false</returns>
        public bool IntersectsRectangle(Rectangle rect)
        {
            return _containerRectangle.IntersectsWith(rect);
        }

        /// <summary>
        /// Either the shape can be moved using the displacements or not
        /// </summary>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <param name="container">The rectangle, that determines the drawing surface</param>
        /// <returns>Returns true if the shape can be moved, otherwise - false</returns>
        public bool CanMove(int dx, int dy, Rectangle container)
        {
            var newRectangle = new Rectangle(_containerRectangle.X + dx, _containerRectangle.Y + dy, _containerRectangle.Width, _containerRectangle.Height);
            return container.Contains(newRectangle);
        }

        /// <summary>
        /// Draws the shape using the graphics
        /// </summary>
        /// <param name="graphics">Drawing surface</param>
        public void Draw(Graphics graphics)
        {
            DrawBorder(graphics);
            FillShape(graphics);
            DrawInteractivePoints(graphics);
        }

        /// <summary>
        /// Draws the shapes border using the graphics
        /// </summary>
        /// <param name="graphics">Drawing surface</param>
        public abstract void DrawBorder(Graphics graphics);

        /// <summary>
        /// Fills the shape with color using the graphics
        /// </summary>
        /// <param name="graphics">Drawing surface</param>
        public abstract void FillShape(Graphics graphics);

        /// <summary>
        /// Draws the interactive points of the shape using the graphics if any exists
        /// </summary>
        /// <param name="graphics">Drawing surface</param>
        public abstract void DrawInteractivePoints(Graphics graphics);

        /// <summary>
        /// Handler for shape selection
        /// </summary>
        public void Select()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Handler for shape deselection
        /// </summary>
        public void Deselect()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Handler for shape movement
        /// </summary>
        /// <param name="dx">delta x</param>
        /// <param name="dy">delta y</param>
        public virtual void Move(int dx, int dy)
        {
            var newRectangle = new Rectangle(_containerRectangle.X + dx, _containerRectangle.Y + dy, _containerRectangle.Width, _containerRectangle.Height);
            _containerRectangle = newRectangle;
        }
    }
}
