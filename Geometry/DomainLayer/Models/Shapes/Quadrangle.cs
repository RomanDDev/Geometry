﻿using System.Drawing;
using Geometry.DomainLayer.Models.BaseShapes;

namespace Geometry.DomainLayer.Models.Shapes
{
    public class Quadrangle : InteractiveShape
    {
        protected Quadrangle(int zIndex, Color backColor, Color borderColor, Rectangle rectangle) : base(zIndex, backColor, borderColor, rectangle)
        {
        }

        public override void DrawBorder(Graphics graphics)
        {
            throw new System.NotImplementedException();
        }

        public override void FillShape(Graphics graphics)
        {
            throw new System.NotImplementedException();
        }

        protected override void UpdateInteractivePoints()
        {
            throw new System.NotImplementedException();
        }
    }
}