using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;
using OpenAirSim.Core;

namespace OpenAirSim
{
    public static class Program
    {
        static void Main()
        {
            using (var game = new GameMain())
            game.Run();
        }
    }
}
