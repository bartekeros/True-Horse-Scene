using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace True_Horse_Scene
{
    static class KeyboardManager
    {
        public static Keys GetKey(KeyboardState kbState)
        {
            if (kbState.IsKeyDown(Keys.Right)) { return Keys.Right; }
            if (kbState.IsKeyDown(Keys.Left)) { return Keys.Left; }
            if (kbState.IsKeyDown(Keys.Up)) { return Keys.Up; }
            if (kbState.IsKeyDown(Keys.Down)) { return Keys.Down; }

            return Keys.Zoom;
        }
    }
}
