using Microsoft.Xna.Framework;

namespace GameTemplate
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      using (Game game = new Game())
      {
        game.Run();
      }
    }
  }
}