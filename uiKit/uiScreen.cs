using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace uiKit
{
    class uiScreen
    {
        public int width;
        public int height;

        public List<uiElement> elements = new List<uiElement>();

        public uiScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
