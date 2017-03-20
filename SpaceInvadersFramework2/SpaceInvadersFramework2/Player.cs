using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvadersFramework2
{
    class Player : SpriteGameObject
    {
        public Player (PlayingState playingState)
            :base("ship") {

        }
        public override void HandleInput(InputHelper inputHelper) {
            base.HandleInput(inputHelper);
            velocity.X = 0;
            if (inputHelper.IsKeyDown(Keys.Left)) {
                velocity.X = -500;
            }else 
            if (inputHelper.IsKeyDown(Keys.Right)) {
                velocity.X = 500;
            }
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            position = Vector2.Clamp(position, Vector2.Zero, new Vector2(SpaceInvaders.Screen.X - Width, SpaceInvaders.Screen.Y));
        }
    }
}
