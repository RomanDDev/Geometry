using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Geometry.ApplicationLayer.Enums;
using Geometry.ApplicationLayer.Tools;
using Geometry.DomainLayer.Interfaces;
using Geometry.DomainLayer.Models.BaseShapes;
using Geometry.DomainLayer.Models.Shapes;
using Moq;
using NUnit.Framework;

namespace GeometryTests
{
    public class Tests
    {
        private List<GeometryShape> shapes = new List<GeometryShape>();
        private DrawTool testingTool = null;
        private MouseEventArgs startMouseEventArgs = new MouseEventArgs(MouseButtons.Left, 1, 10, 10, 0);
        private MouseEventArgs endMouseEventArgs = new MouseEventArgs(MouseButtons.Left, 1, 30, 30, 0);

        [SetUp]
        public void Setup()
        {
            shapes.Clear();
            var mock = new Mock<IShapeRepository>();
            mock.Setup(repo => repo.GetAllShapes()).Returns(shapes);
            mock.Setup(repo => repo.AddShape(It.IsAny<GeometryShape>())).Callback<GeometryShape>(shape => shapes.Add(shape));
            testingTool = new DrawTool(mock.Object);
        }

        [Test]
        public void HandleMouseUp_WithNoShape_ThrowsException()
        {
            testingTool.BrushShape = BrushShapes.NoShape;
            Assert.Throws<InvalidOperationException>(() => testingTool.HandleMouseUp(endMouseEventArgs));
        }

        [Test]
        public void HandleMouseUp_WithoutHandlingMouseDown_ThrowsException()
        {
            testingTool.BrushShape = BrushShapes.Ellipse;
            Assert.Throws<InvalidOperationException>(() => testingTool.HandleMouseUp(endMouseEventArgs));
        }

        [Test]
        public void HandleMouseUp_WithEllipseShape_AddsEllipseToCollection()
        {
            Assert.IsFalse(shapes.Any());
            testingTool.BrushShape = BrushShapes.Ellipse;
            testingTool.HandleMouseDown(startMouseEventArgs);
            testingTool.HandleMouseUp(endMouseEventArgs);
            Assert.AreEqual(1, shapes.Count(shape => shape is Ellipse));
        }

        [Test]
        public void HandleMouseUp_WithSameMouseCoordinates_DoesNotAddAnyShape()
        {
            Assert.IsFalse(shapes.Any());
            testingTool.BrushShape = BrushShapes.Ellipse;
            testingTool.HandleMouseDown(startMouseEventArgs);
            testingTool.HandleMouseUp(startMouseEventArgs);
            Assert.IsFalse(shapes.Any());

        }

        [Test]
        public void HandleMouseUp_With_DoesNotAddAnyShape()
        {
            Assert.IsFalse(shapes.Any());
            testingTool.BrushShape = BrushShapes.Ellipse;
            testingTool.HandleMouseDown(startMouseEventArgs);
            testingTool.HandleMouseUp(startMouseEventArgs);
            Assert.IsFalse(shapes.Any());

        }
    }
}