using System;
using System.Collections.Generic;
using Geometry.DomainLayer.Interfaces;
using Geometry.DomainLayer.Models.BaseShapes;

namespace Geometry.DomainLayer.Repositories
{
    public class ShapesRepository : IShapeRepository
    {
        private readonly List<GeometryShape> _shapes = new List<GeometryShape>();

        public IEnumerable<GeometryShape> GetAllShapes()
        {
            return _shapes.ToArray();
        }

        public void AddShape(GeometryShape shape)
        {
            if (_shapes.Contains(shape))
                throw new InvalidOperationException(Properties.Resources.NoShapeDuplicatesAllowedMessage);
            _shapes.Add(shape);
        }

        public void DeleteShape(GeometryShape shape)
        {
            if (!_shapes.Contains(shape))
                throw new KeyNotFoundException(Properties.Resources.MissingShapeErrorMessage);
            _shapes.Remove(shape);
        }
    }
}
