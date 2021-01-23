using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace True_Horse_Scene
{
    public static class Notification
    {
        public static void SpaceInfoMessage(SpriteFont font, SpriteBatch spriteBatch, Vector2 textPos, string text)
        {
            spriteBatch.DrawString(font, text, new Vector2(textPos.X - text.Length*10, textPos.Y), Color.White);
        }

        public static void WinMessage(SpriteFont font, SpriteBatch spriteBatch, Vector2 textPos, string text)
        {

        }
    }
}
