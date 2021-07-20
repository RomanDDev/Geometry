﻿using System;
using System.Drawing;
using Geometry.ApplicationLayer.Enums;
using Geometry.DomainLayer.Interfaces;
using Geometry.DomainLayer.Models.BaseShapes;
using Geometry.DomainLayer.Models.Shapes;

namespace Geometry.ApplicationLayer.Tools
{
    /// <summary>
    /// Tool for drawing new shapes
    /// </summary>
    public class DrawTool : BaseTool
    {
        public DrawTool(IShapeRepository repository) : base(repository)
        {
            BrushShape = BrushShapes.NoShape;
        }

        public BrushShapes BrushShape { get; set; }

        protected override void HandleMouseUp(Rectangle selectionRectangle)
        {
            
            var zIndex = new Random().Next(10);
            //TODO: Refactor to the factory of shapes
            GeometryShape shape;
            switch (BrushShape)
            {
                case BrushShapes.NoShape:
                    return;
                case BrushShapes.Ellipse:
                    shape = new Circle(zIndex, Color.White, Color.Black, selectionRectangle);
                    break;
                case BrushShapes.Quadrangle:
                    shape = new Quadrangle(zIndex, Color.White, Color.Black, selectionRectangle);
                    break;
                case BrushShapes.Triangle:
                    shape = new Triangle(zIndex, Color.White, Color.Black, selectionRectangle);
                    break;
                case BrushShapes.Rhombus:
                    shape = new Rhombus(zIndex, Color.White, Color.Black, selectionRectangle);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            ShapeRepository.AddShape(shape);
        }

        protected override void HandleMouseDown(Point? startMousePoint)
        {
            //Do nothing
        }
    }
}
