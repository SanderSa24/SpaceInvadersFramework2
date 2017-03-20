using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace SpaceInvadersFramework2
{
    
    public class SpaceInvaders : GameEnvironment
    {
        public SpaceInvaders()
        {
            Content.RootDirectory = "Content";
        }
        protected override void LoadContent()
        {
            
            spriteBatch = new SpriteBatch(GraphicsDevice);
            GameStateManager.AddGameState("playingState", new PlayingState());
            GameStateManager.SwitchTo("playingState");
            
        }
        
    }
}
