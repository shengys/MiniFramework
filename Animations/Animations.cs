using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rquirrel_Ranger.Utilities;

namespace Rquirrel_Ranger.Animations
{
    public abstract class Animations : IAnimations
    {
        protected Dictionary<string, Rectangle[]> _animations;
        protected Spritesheet _spritesheet;
        protected Vector2 _position;

        protected bool _playAllTime = true;

        protected float _timePerFrame = 0.1f;
        protected float _timeFromLastUpdate;

        protected string _currentAnimation;
        protected string _lastAnimation;

        protected int _currentFrame = 0;
        protected int _direction = 1;

        protected Animations(int positionX, int positionY, string spritesheet, string defaultAnimation)
        {
            _currentAnimation = defaultAnimation;
            _lastAnimation = defaultAnimation;

            _animations = new Dictionary<string, Rectangle[]>();

            // Inisialitations.
            InitAnimations();

            _playAllTime = true;

            _position.X = positionX;
            _position.Y = positionY;

            _spritesheet = new Spritesheet(Ressources.Images[spritesheet], _animations[_currentAnimation][_currentFrame].Width,
                _animations[_currentAnimation][_currentFrame].Height, _animations[_currentAnimation][_currentFrame].X,
                _animations[_currentAnimation][_currentFrame].Y, (int)_position.X, (int)_position.Y);
        }

        // Jouer une animation.
        public virtual void Play(string animation)
        {
            _lastAnimation = _currentAnimation;
            _currentAnimation = animation;

            if (_currentAnimation != _lastAnimation)
                _currentFrame = 0;
        }

        protected abstract void InitAnimations();

        ///////// UPDATE & DRAW /////////
        public virtual void Update(GameTime gameTime, int positionX, int positionY, int direction)
        {
            _direction = direction;

            _timeFromLastUpdate += (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Jouer animation en boucle //
            if (_timeFromLastUpdate >= _timePerFrame)
            {
                if (_currentFrame == _animations[_currentAnimation].Length - 1)
                {
                    _timeFromLastUpdate = 0;
                    _currentFrame = 0;
                }
                else
                {
                    _timeFromLastUpdate = 0;
                    _currentFrame++;
                }
            }

            _position.X = positionX;
            _position.Y = positionY;

            _spritesheet.Update(gameTime, _animations[_currentAnimation][_currentFrame].Width, _animations[_currentAnimation][_currentFrame].Height,
                _animations[_currentAnimation][_currentFrame].X, _animations[_currentAnimation][_currentFrame].Y, (int)_position.X, (int)_position.Y);
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (_direction > 0)
                _spritesheet.Draw(spriteBatch);
            else
            {
                _spritesheet.Draw(spriteBatch, true);
            }
        }
    }
}
