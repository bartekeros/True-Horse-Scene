using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace True_Horse_Scene
{
    public static class Globals
    {
        public static GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch;
        public static SpriteFont spriteFont;

        public static Texture2D grassTexture;
        public static Texture2D doorTexture;
        public static Texture2D wallTexture;
        public static Texture2D horseTexture;

        public static readonly int screenHeight = 500;
        public static readonly int screenWidth = 500;


        public static float horseScaling = 0.1f;
        public static Vector2 horsePosition = new Vector2(Globals.screenWidth / 2, Globals.screenHeight - 20);

    }
}
