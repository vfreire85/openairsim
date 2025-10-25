using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using OpenAirSim.Graphics;
using OpenAirSim.Input;

namespace OpenAirSim.Core
{
    public class GameMain : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private GraphicsManager _graphicsManager;
        private InputManager _inputManager;

        public GameMain()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphicsManager = new GraphicsManager(GraphicsDevice);
            _inputManager = new InputManager();

            // Initial game configs (window size etc.)
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.ApplyChanges();

            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: load textures, models and other content from Content/
        }

        protected override void Update(GameTime gameTime)
        {
            _inputManager.Update();
            if (_inputManager.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Escape))
                Exit();

            // Closes games if user presses ESC
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: update game logic (input, physics, entities, etc.)
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _graphicsManager.BeginDraw(Color.CornflowerBlue);
            // future: draw map, aircraft, interface.
            _graphicsManager.EndDraw();
        }
    }
}
