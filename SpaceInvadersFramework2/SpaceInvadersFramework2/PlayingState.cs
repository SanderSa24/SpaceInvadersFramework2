﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework2
{
    class PlayingState : GameObjectList
    {
        Player player;
        GameObjectList invaders;
        public PlayingState() {
            player = new Player(this);
            invaders = new GameObjectList();

            var xPos = SpaceInvaders.Screen.X / 2 - player.Width / 2;
            var yPos =  SpaceInvaders.Screen.Y - player.Width;
            player.Position = new Vector2(xPos, yPos);
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 4; j++) {
                   var asset = "green_invader"; 
                   if (j == 1)   asset = "yellow_invader"; 
                   if (j == 2)   asset = "red_invader"; 
                   if (j == 3)   asset = "blue_invader"; 
                  var invader = new Invader(asset);
                    invader.Position = new Vector2(i*64,j*64);
                    invaders.Add(invader);
                }
            }
            Add(player);
            Add(invaders);
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
