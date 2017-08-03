using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeldaNES.Sprites
{
    public class Sprite
    {
        protected Texture2D _texture;
        protected Vector2 _position;

        public Sprite(Texture2D texture, int x = 0, int y = 0)
        {
            _texture = texture;

            _position.X = x;
            _position.Y = y;
        }

        public void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch, bool flip = false)
        {
            spriteBatch.Begin();

            if (!flip)
                spriteBatch.Draw(_texture, _position, null, null, null, 0, null, Color.White, SpriteEffects.FlipHorizontally);
            else
                spriteBatch.Draw(_texture, _position, Color.White);

            spriteBatch.End();
        }
    }
}
