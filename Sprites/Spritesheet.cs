using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeldaNES.Sprites
{
    public class Spritesheet : Sprite
    {
        private Rectangle _sourceRect;

        public Spritesheet(Texture2D texture, int width, int height, int spriteX, int spriteY, int positionX = 0, int positionY = 0) : 
            base(texture, positionX, positionY)
        {
            _texture = texture;

            _position.X = positionX;
            _position.Y = positionY;

            _sourceRect = new Rectangle(spriteX, spriteY, width, height);
        }

        public void Update(GameTime gameTime, int width, int height, int spriteX, int spriteY, int positionX, int positionY)
        {
            _sourceRect.Width = width;
            _sourceRect.Height = height;
            _sourceRect.X = spriteX;
            _sourceRect.Y = spriteY;

            _position.X = positionX;
            _position.Y = positionY;
        }

        public void Draw(SpriteBatch spriteBatch, bool flip = false)
        {
            spriteBatch.Begin();

            if (!flip)
                spriteBatch.Draw(_texture, _position, _sourceRect, Color.White);
            else
                spriteBatch.Draw(_texture, _position, null, _sourceRect, null, 0, null, Color.White, SpriteEffects.FlipHorizontally);

            spriteBatch.End();
        }
    }
}
