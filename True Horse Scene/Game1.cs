using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace True_Horse_Scene
{
    public class Game1 : Game
    {
        private Sprite sprite;
        private LevelMap levelMap;

        public static bool isHorseColidate;

        public Game1()
        {
            Globals.graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();

            sprite = new Sprite();
            levelMap = new LevelMap();
            sprite.playerPosition = new Vector2(0, 0);

            Globals.graphics.PreferredBackBufferHeight = Globals.screenHeight;
            Globals.graphics.PreferredBackBufferWidth = Globals.screenWidth;

            Globals.graphics.ApplyChanges();

        }

        protected override void LoadContent()
        {
            Globals.spriteBatch = new SpriteBatch(GraphicsDevice);

            Sprite.spriteTexture = Content.Load<Texture2D>("sprite");
            Globals.horseTexture = Content.Load<Texture2D>("horse");
            Globals.grassTexture = Content.Load<Texture2D>("grass");
            Globals.doorTexture = Content.Load<Texture2D>("door");
            Globals.wallTexture = Content.Load<Texture2D>("wall");

            Globals.spriteFont = Content.Load<SpriteFont>("font");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            sprite.Move(levelMap, Sprite.spriteTexture);
         

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            Globals.spriteBatch.Begin();

            levelMap.DrawCurrentLevel(sprite);  


            Globals.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
