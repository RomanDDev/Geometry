using System.Drawing;
using System.Linq;
using Geometry.DomainLayer.Interfaces;

namespace Geometry.ApplicationLayer.Tools
{
    /// <summary>
    /// Tool for selecting shapes
    /// </summary>
    public class SelectTool : BaseTool
    {
        public SelectTool(IShapeRepository shapeRepository):base(shapeRepository)
        {
        }

        #region Input event handlers

        protected override void HandleMouseUp(Rectangle selectionRectangle)
        {
            foreach (var geometryShape in ShapeRepository.GetAllShapes().Where(shape => shape.IntersectsRectangle(selectionRectangle)))
                geometryShape.Select();
        }

        protected override void HandleMouseDown(Point? startMousePoint)
        {
            foreach (var geometryShape in ShapeRepository.GetAllShapes())
                geometryShape.Deselect();
        }

        #endregion
    }
}
