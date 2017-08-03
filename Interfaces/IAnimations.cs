using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Rquirrel_Ranger
{
    public interface IAnimations
    {
        void Draw(SpriteBatch spriteBatch);
        void Play(string animation);
        void Update(GameTime gameTime, int positionX, int positionY, int direction);
    }
}