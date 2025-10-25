using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace OpenAirSim.Graphics
{
    /// <summary>
    /// Manages all the graphics of the game:
    /// - Texture loading;
    /// - Sprite drawing;
    /// - Viewport and camera update;
    /// </summary>
    public class GraphicsManager
    {
        private readonly GraphicsDevice _graphicsDevice;
        private readonly SpriteBatch _spriteBatch;

        public GraphicsManager(GraphicsDevice graphicsDevice)
        {
            _graphicsDevice = graphicsDevice ?? throw new ArgumentNullException(nameof(graphicsDevice));
            _spriteBatch = new SpriteBatch(_graphicsDevice);
        }

        /// <summary>
        /// Called at each frame beginning to prepare the drawing.
        /// </summary>
        public void BeginDraw(Color backgroundColor)
        {
            _graphicsDevice.Clear(backgroundColor);
            _spriteBatch.Begin();
        }

        /// <summary>
        /// Draws texture on screen.
        /// </summary>
        public void DrawTexture(Texture2D texture, Vector2 position)
        {
            if (texture == null) return;
            _spriteBatch.Draw(texture, position, Color.White);
        }

        /// <summary>
        /// Ends frame.
        /// </summary>
        public void EndDraw()
        {
            _spriteBatch.End();
        }

        public void Dispose()
        {
            _spriteBatch.Dispose();
        }
    }
}
