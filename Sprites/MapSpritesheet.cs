using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace ZeldaNES.Sprites
{
    public class MapSpritesheet
    {
        public List<Spritesheet> _spritesheet;

        public Texture2D _texture;

        public int _tileWidth;
        public int _tileHeight;
        public int _nbTilesWidth;
        public int _nbTilesHeight;

        public int _offset;

        public MapSpritesheet(Texture2D texture, int tileWidth, int tileHeight, int offset = 0)
        {
            _spritesheet = new List<Spritesheet>();

            _texture = texture;

            _tileWidth = tileWidth;
            _tileHeight = tileHeight;

            _offset = offset;

            _nbTilesWidth = _texture.Width / _tileWidth;
            _nbTilesHeight = _texture.Height / _tileHeight;
        }

        public void SlideSprites()
        {
            for(int i = 0;i < _nbTilesHeight;i++)
            {
                for(int j = 0;j < _nbTilesWidth;j++)
                {
                    int x = j * _tileWidth + _offset;
                    int y = i * _tileHeight + _offset;
                    

                }
            }
        }
    }
}
