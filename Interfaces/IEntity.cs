using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Rquirrel_Ranger
{
    public interface IEntity
    {
        void Draw(SpriteBatch spriteBatch);
        void Update(GameTime gameTime);
    }
}