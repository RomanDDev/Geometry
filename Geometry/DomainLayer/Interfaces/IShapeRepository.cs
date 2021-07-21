using System.Collections.Generic;
using Geometry.DomainLayer.Models.BaseShapes;

namespace Geometry.DomainLayer.Interfaces
{
    /// <summary>
    /// Container interface of current editor geometry shapes
    /// </summary>
    public interface IShapeRepository
    {
        /// <summary>
        /// Gets all existing shapes
        /// </summary>
        /// <returns></returns>
        IEnumerable<GeometryShape> GetAllShapes();

        /// <summary>
        /// Adds shape to the collection
        /// </summary>
        /// <param name="shape"></param>
        void AddShape(GeometryShape shape);

        /// <summary>
        /// Removes shape from the collection
        /// </summary>
        /// <param name="shape"></param>
        void DeleteShape(GeometryShape shape);
    }
}
