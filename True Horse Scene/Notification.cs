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
        public static void SpaceInfoMessage(Vector2 textPos, string text)
        {
            Globals.spriteBatch.DrawString(Globals.spriteFont , text, new Vector2(textPos.X - text.Length*10, textPos.Y), Color.White);
        }

        public static void WinMessage(Vector2 textPos, string text)
        {
            Globals.spriteBatch.DrawString(Globals.spriteFont, text, textPos, Color.Red);
        }
    }
}
