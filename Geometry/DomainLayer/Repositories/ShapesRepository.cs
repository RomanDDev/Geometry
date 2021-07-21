using System;
using System.Collections.Generic;
using Geometry.DomainLayer.Interfaces;
using Geometry.DomainLayer.Models.BaseShapes;

namespace Geometry.DomainLayer.Repositories
{
    /// <summary>
    /// Collection - stored repository of editor shapes
    /// </summary>
    public class ShapesRepository : IShapeRepository
    {
        /// <summary>
        /// The collection of editor shapes
        /// </summary>
        private readonly List<GeometryShape> _shapes = new List<GeometryShape>();

        ///<inheritdoc />
        public IEnumerable<GeometryShape> GetAllShapes()
        {
            return _shapes.ToArray();
        }

        ///<inheritdoc />
        public void AddShape(GeometryShape shape)
        {
            if (_shapes.Contains(shape))
                throw new InvalidOperationException(Properties.Resources.NoShapeDuplicatesAllowedMessage);
            _shapes.Add(shape);
        }

        ///<inheritdoc />
        public void DeleteShape(GeometryShape shape)
        {
            if (!_shapes.Contains(shape))
                throw new KeyNotFoundException(Properties.Resources.MissingShapeErrorMessage);
            _shapes.Remove(shape);
        }
    }
}
