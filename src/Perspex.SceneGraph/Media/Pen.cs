﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System.Collections.Generic;

namespace Perspex.Media
{
    /// <summary>
    /// Describes how a stroke is drawn.
    /// </summary>
    public class Pen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pen"/> class.
        /// </summary>
        /// <param name="brush">The brush used to draw.</param>
        /// <param name="thickness">The stroke thickness.</param>
        public Pen(
            Brush brush, 
            double thickness = 1.0,
            DashStyle dashStyle = null, PenLineCap dashCap = PenLineCap.Flat, PenLineCap startLineCap = PenLineCap.Flat, 
            PenLineCap endLineCap = PenLineCap.Flat, PenLineJoin lineJoin = PenLineJoin.Miter, double miterLimit = 10.0)
        {
            Brush = brush;
            Thickness = thickness;
            StartLineCap = startLineCap;
            EndLineCap = endLineCap;
            LineJoin = lineJoin;
            MiterLimit = miterLimit;
            DashStyle = dashStyle;
            DashCap = dashCap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pen"/> class.
        /// </summary>
        /// <param name="color">The stroke color.</param>
        /// <param name="thickness">The stroke thickness.</param>
        public Pen(
            uint color, 
            double thickness = 1.0,
            DashStyle dashStyle = null, PenLineCap dashCap = PenLineCap.Flat, PenLineCap startLineCap = PenLineCap.Flat,
            PenLineCap endLineCap = PenLineCap.Flat, PenLineJoin lineJoin = PenLineJoin.Miter, double miterLimit = 10.0)
        {
            Brush = new SolidColorBrush(color);
            Thickness = thickness;
            StartLineCap = startLineCap;
            EndLineCap = endLineCap;
            LineJoin = lineJoin;
            MiterLimit = miterLimit;
            DashStyle = dashStyle;
            DashCap = dashCap;
        }

        /// <summary>
        /// Gets the brush used to draw the stroke.
        /// </summary>
        public Brush Brush { get; }

        /// <summary>
        /// Gets the stroke thickness.
        /// </summary>
        public double Thickness { get; } = 1.0;

        public DashStyle DashStyle { get; }

        public PenLineCap DashCap { get; }

        public PenLineCap StartLineCap { get; } = PenLineCap.Flat;

        public PenLineCap EndLineCap { get; } = PenLineCap.Flat;

        public PenLineJoin LineJoin { get; } = PenLineJoin.Miter;

        public double MiterLimit { get; } = 10.0;
    }
}
