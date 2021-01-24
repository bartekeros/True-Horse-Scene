using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace True_Horse_Scene
{
    public class LevelMap
    {
        private int currentLevel;

        public LevelMap()
        {
            currentLevel = 1;
        }

        public void CheckBoundaries(Vector2 pos, Sprite sprite, Texture2D spriteTexture)
        {
            if (pos.X > Globals.screenWidth - spriteTexture.Width/2)
                pos.X = Globals.screenWidth - spriteTexture.Width/2;
            if (pos.Y > Globals.screenHeight - spriteTexture.Height/2)
                pos.Y = Globals.screenHeight - spriteTexture.Height/2;

            if (pos.X + spriteTexture.Width/2 < 0)
                pos.X = -spriteTexture.Width / 2;
            if (pos.Y + spriteTexture.Height / 2 < 0)
                pos.Y = -spriteTexture.Height / 2;

            sprite.playerPosition = pos;
        }

        public void DrawCurrentLevel(Sprite sprite)
        {
            if (currentLevel == 1)
                DrawFirstLevel(sprite);
            else if (currentLevel == 2)
                DrawSecondLevel(sprite);

        }

        public void DrawFirstLevel(Sprite sprite)
        {
            Globals.spriteBatch.Draw(Globals.grassTexture, new Rectangle(0, 0, Globals.screenWidth, Globals.screenHeight), Color.White);
            Globals.spriteBatch.Draw(Globals.horseTexture, Globals.horsePosition, null, Color.White, 0, new Vector2(Globals.horseTexture.Width / 2, Globals.horseTexture.Height / 2),
               Globals.horseScaling, SpriteEffects.None, 1);

            Globals.spriteBatch.Draw(Globals.wallTexture, new Rectangle(450, 0, 50, 200), Color.White);
            Globals.spriteBatch.Draw(Globals.wallTexture, new Rectangle(450, 300, 50, 200), Color.White);

            Globals.spriteBatch.Draw(Globals.doorTexture, new Rectangle(450, 200, 50, 100), Color.White);

            Globals.spriteBatch.Draw(Sprite.spriteTexture, sprite.playerPosition, Color.White);

            if (sprite.CheckColidation(new Vector2(450 + Globals.doorTexture.Width / 2, 200 + Globals.doorTexture.Height / 2), 45))
            {
                currentLevel = 2;
                sprite.playerPosition = new Vector2(0, sprite.playerPositionCenter.Y);
            }

            if (sprite.CheckColidation(Globals.horsePosition, 45) == true)
            {
                Notification.SpaceInfoMessage(new Vector2(Globals.screenWidth / 2, 20), "Space");
                Game1.isHorseColidate = true;
            }
            else { Game1.isHorseColidate = false; }

        }

        public void DrawSecondLevel(Sprite sprite)
        {

            Globals.spriteBatch.Draw(Globals.grassTexture, new Rectangle(0, 0, Globals.screenWidth, Globals.screenHeight), Color.White);

            Globals.spriteBatch.Draw(Sprite.spriteTexture, sprite.playerPosition, Color.White);

            Notification.WinMessage(new Vector2(0, 20), "Congratulation, You entered second level!");
        }

    }
}
