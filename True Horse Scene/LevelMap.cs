using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace True_Horse_Scene
{
    public class LevelMap
    {
        public void CheckBoundaries(Vector2 pos, Sprite sprite, Texture2D spriteTexture)
        {
            if (pos.X > Game1.screenWidth - spriteTexture.Width/2)
                pos.X = Game1.screenWidth - spriteTexture.Width/2;
            if (pos.Y > Game1.screenHeight - spriteTexture.Height/2)
                pos.Y = Game1.screenHeight - spriteTexture.Height/2;

            if (pos.X + spriteTexture.Width/2 < 0)
                pos.X = -spriteTexture.Width / 2;
            if (pos.Y + spriteTexture.Height / 2 < 0)
                pos.Y = -spriteTexture.Height / 2;

            sprite.playerPosition = pos;
        }

    }
}
