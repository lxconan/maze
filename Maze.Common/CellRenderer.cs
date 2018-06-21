﻿using System;
using System.Drawing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace Maze.Common
{
    public abstract class CellRenderer : IDisposable
    {
        public abstract void Render(
            IImageProcessingContext<Rgba32> context, 
            Rectangle cellArea, 
            RenderCell cell);

        protected abstract void Dispose(bool disposing);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}