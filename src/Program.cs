using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;

namespace OpenAirSim
{
    public class OpenAirSimGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D? _mapTexture;

        public OpenAirSimGame()
        {
            // When starting, this will open the GUI of the game and some initial assets when loading
            _graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = 1280,
                PreferredBackBufferHeight = 720
            };
            Content.RootDirectory = "assets";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // Variables and every necessary data to start a game session
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // Verification of the existence of placeholder_map.png is verified here, and then loaded if it exists
            string mapPath = Path.Combine(Content.RootDirectory, "placeholder_map.png");
            if (File.Exists(mapPath))
            {
                using var stream = File.OpenRead(mapPath);
                _mapTexture = Texture2D.FromStream(GraphicsDevice, stream);
            }
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            if (_mapTexture != null)
                _spriteBatch.Draw(_mapTexture, Vector2.Zero, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }

    public static class Program
    {
        public static void Main()
        {
            using var game = new OpenAirSimGame();
            game.Run();
        }
    }
}
