using Microsoft.Xna.Framework.Input;

namespace OpenAirSim.Input
{
    /// <summary>
    /// Centralizes input capture from player:
    /// - Keyboard;
    /// - Mouse;
    /// </summary>
    public class InputManager
    {
        private KeyboardState _previousKeyboardState;
        private MouseState _previousMouseState;

        public KeyboardState CurrentKeyboardState { get; private set; }
        public MouseState CurrentMouseState { get; private set; }

        public void Update()
        {
            _previousKeyboardState = CurrentKeyboardState;
            _previousMouseState = CurrentMouseState;

            CurrentKeyboardState = Keyboard.GetState();
            CurrentMouseState = Mouse.GetState();
        }

        public bool IsKeyPressed(Keys key)
        {
            return CurrentKeyboardState.IsKeyDown(key) && !_previousKeyboardState.IsKeyDown(key);
        }

        public bool IsLeftClick()
        {
            return CurrentMouseState.LeftButton == ButtonState.Pressed &&
                   _previousMouseState.LeftButton == ButtonState.Released;
        }
    }
}
