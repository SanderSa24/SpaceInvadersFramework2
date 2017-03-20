using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework2
{
    class Invader: SpriteGameObject
    {
        public Invader(String assetName): base(assetName) {
            velocity.X = 100;
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (BoundingBox.Left < 0 || BoundingBox.Right > SpaceInvaders.Screen.X)
            {
                velocity.X *= -1;
                position.Y += 32;
            }
        }
    }
}
