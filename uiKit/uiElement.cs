using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace uiKit
{
    class uiElement
    {
        public Point location;
        public Point size;

        public Color color;

        public uiElement(Point location, Point size, Color color)
        {
            this.location = location;
            this.size = size;
            this.color = color;
        }
    }
}
