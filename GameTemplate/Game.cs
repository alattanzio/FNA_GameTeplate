using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Color = Microsoft.Xna.Framework.Color;
using System;

public class Game : Microsoft.Xna.Framework.Game
{
  GraphicsDeviceManager graphics;
  SpriteBatch spriteBatch;

  public Game()
  {
    graphics = new GraphicsDeviceManager(this);
    Content.RootDirectory = "Content";
  }

  protected override void Initialize()
  {
    base.Initialize();
  }

  protected override void LoadContent()
  {
    spriteBatch = new SpriteBatch(GraphicsDevice);
  }

  protected override void Update(GameTime gameTime)
  {
    base.Update(gameTime);
  }

  protected override void Draw(GameTime gameTime)
  {
    GraphicsDevice.Clear(Color.CornflowerBlue);
    base.Draw(gameTime);
  }
}
