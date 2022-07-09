using Tutorial3D;
using Tutorial3D.GameLoop;

namespace OpenGL.GL
{
    class Program
    {
        public static void Main(string[] args)
        {
            Game game = new TestGame(800, 600, "Test Game");
            game.Run();
        }
    }
}