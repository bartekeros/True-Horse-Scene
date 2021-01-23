using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace True_Horse_Scene
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private SpriteFont spriteFont;

        public static Texture2D spriteTexture;
        private Texture2D horseTexture;
        private float horseScaling = 0.1f;
        private Vector2 horsePosition = new Vector2(screenWidth / 2, screenHeight - 20);

        public static readonly int screenHeight = 500;
        public static readonly int screenWidth = 500;

        private Sprite sprite;
        private LevelMap levelMap;

        public static bool isColidate;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();

            sprite = new Sprite();
            levelMap = new LevelMap();
            sprite.playerPosition = new Vector2(0, 0);

            graphics.PreferredBackBufferHeight = screenHeight;
            graphics.PreferredBackBufferWidth = screenWidth;

            graphics.ApplyChanges();

        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            spriteTexture = Content.Load<Texture2D>("sprite");
            horseTexture = Content.Load<Texture2D>("horse");

            spriteFont = Content.Load<SpriteFont>("font");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            sprite.Move(levelMap, spriteTexture);
         

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(spriteTexture, sprite.playerPosition, Color.White);
            spriteBatch.Draw(horseTexture, horsePosition, null, Color.White, 0, new Vector2(horseTexture.Width/2, horseTexture.Height/2),
                horseScaling, SpriteEffects.None, 1);

            if (sprite.CheckColidation(horsePosition, 45) == true)
            {
                Notification.SpaceInfoMessage(spriteFont, spriteBatch, new Vector2(screenWidth / 2, 20), "Space");
                isColidate = true;
            }
            else { isColidate = false; }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
