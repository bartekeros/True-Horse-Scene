using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace True_Horse_Scene
{
    public class Sprite
    {
        public static Texture2D spriteTexture;
        public Vector2 playerPosition;
        public Vector2 playerPositionCenter;
        public float playerSpeed { get; set; } = 10;


        public void Move(LevelMap levelMap, Texture2D tex)
        {
            KeyboardState kbState = Keyboard.GetState();

            if (kbState.IsKeyDown(Keys.Right))
            {
                playerPosition.X += playerSpeed;
                levelMap.CheckBoundaries(new Vector2(playerPosition.X + playerSpeed, playerPosition.Y), this, tex);
            }
            if (kbState.IsKeyDown(Keys.Left))
            {
                playerPosition.X -= playerSpeed;
                levelMap.CheckBoundaries(new Vector2(playerPosition.X - playerSpeed, playerPosition.Y), this, tex);
            }
            if (kbState.IsKeyDown(Keys.Down))
            {
                playerPosition.Y += playerSpeed;
                levelMap.CheckBoundaries(new Vector2(playerPosition.X, playerPosition.Y + playerSpeed), this, tex);
            }
            if (kbState.IsKeyDown(Keys.Up))
            {
                playerPosition.Y -= playerSpeed;
                levelMap.CheckBoundaries(new Vector2(playerPosition.X, playerPosition.Y - playerSpeed), this, tex);
            }

            if (kbState.IsKeyDown(Keys.Space) && Game1.isHorseColidate == true)
            {
                Environment.Exit(1);
            }

            playerPositionCenter = new Vector2(playerPosition.X + spriteTexture.Width / 2, playerPosition.Y + spriteTexture.Height / 2);
        }

        public bool CheckColidation(Vector2 pos, float radius)
        {
            if(playerPositionCenter.X < pos.X + radius &&
                playerPositionCenter.X > pos.X - radius &&
                playerPositionCenter.Y < pos.Y + radius &&
                playerPositionCenter.Y > pos.Y - radius)
            {
                return true;
            }
            return false;
        }
    }
}
