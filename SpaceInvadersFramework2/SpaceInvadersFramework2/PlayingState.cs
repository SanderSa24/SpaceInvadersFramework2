using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework2
{
    class PlayingState : GameObjectList
    {
        Player player;
        public PlayingState() {
            player = new Player(this);
            var xPos = SpaceInvaders.Screen.X / 2 - player.Width / 2;
            var yPos =  SpaceInvaders.Screen.Y - player.Width;
            player.Position = new Vector2(xPos, yPos);
            Add(player);
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
