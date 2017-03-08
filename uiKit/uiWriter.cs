using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace uiKit
{
    class uiWriter
    {
        private ExtendedSpriteBatch spriteBatch;
        private GraphicsDeviceManager graphics;

        public uiWriter(GraphicsDeviceManager graphics, ExtendedSpriteBatch spriteBatch)
        {
            this.spriteBatch = spriteBatch;
            this.graphics = graphics;
        }

        public void Draw(uiScreen ui)
        {
            spriteBatch.Begin();

            foreach(uiElement element in ui.elements)
            {
                Rectangle rec = new Rectangle(ToNativeSize(ui, element.location), ToNativeSize(ui, element.size));
                spriteBatch.DrawRectangle(rec, element.color);
                spriteBatch.FillRectangle(rec, element.color);
                
            }

            spriteBatch.End();
        }

        public Point ToNativeSize(uiScreen ui, Point p)
        {
            //Get form size
            int formHeight = graphics.PreferredBackBufferHeight;
            int formWidth = graphics.PreferredBackBufferWidth;

            return new Point((formWidth / ui.width) * p.X, (formHeight / ui.height) * p.Y);
        }
    }
}
