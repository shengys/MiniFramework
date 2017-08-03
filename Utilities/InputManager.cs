using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rquirrel_Ranger.Utilities
{
    public class InputManager
    {
        private KeyboardState _currentKeyboardState;
        private KeyboardState _lastKeyboardState;

        private MouseState _currentMouseState;
        private MouseState _lastMouseState;

        public InputManager(KeyboardState keyboardState)
        {
            _currentKeyboardState = keyboardState;
        }

        // Appuie clique gauche (une fois)
        public bool IsMouseLeftClick()
        {
            if ((_currentMouseState.LeftButton == ButtonState.Pressed) && (_lastMouseState.LeftButton == ButtonState.Released))
            {
                _lastMouseState = _currentMouseState;
                return true;
            }

            return false;
        }

        // Position X souris.
        public int GetMouseX()
        {
            return _currentMouseState.Position.X;
        }

        // Position Y souris.
        public int GetMouseY()
        {
            return _currentMouseState.Position.Y;
        }

        // Appuie prolongé d'une touche.
        public bool IsKeyDown(Keys key)
        {
            if (_currentKeyboardState.IsKeyDown(key))
            {
                _lastKeyboardState = _currentKeyboardState;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Relâchement d'une touche.
        public bool IsKeyPressedUp(Keys key)
        {
            if(_lastKeyboardState.IsKeyDown(key) && _currentKeyboardState.IsKeyUp(key))
            {
                _lastKeyboardState = _currentKeyboardState;
                return true;
            } else
            {
                return false;
            }
        }

        // Touche relâchée
        public bool IsKeyUp(Keys key)
        {
            if(_currentKeyboardState.IsKeyUp(key))
            {
                _lastKeyboardState = _currentKeyboardState;
                return true;
            } else
            {
                return false;
            }
        }

        // Appuie sur une touche (une seule fois)
        public bool IsKeyPressed(Keys key)
        {
            //_lastKeyboardState = _currentKeyboardState;

            if (_currentKeyboardState.IsKeyDown(key) && _lastKeyboardState.IsKeyUp(key))
            {
                _lastKeyboardState = _currentKeyboardState;
                return true;
            }

            return false;
        }

        public void Update(KeyboardState keyboardState, MouseState mouseState)
        {
            _lastKeyboardState = _currentKeyboardState;
            _currentKeyboardState = keyboardState;

            _lastMouseState = _currentMouseState;
            _currentMouseState = mouseState;
        }
    }
}
