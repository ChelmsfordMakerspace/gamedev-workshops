#region Using Statements
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

#endregion

namespace MazeGameExample
{
	/// <summary>
	/// This is the main type for your game
	/// </summary>
	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		Texture2D t_player;

		Rectangle r_player;

		Wall[] walls = new Wall[4];

		public Game1 ()
		{
			graphics = new GraphicsDeviceManager (this);
			Content.RootDirectory = "Content";	            
			graphics.IsFullScreen = false;
			graphics.PreferredBackBufferWidth = 800;
			graphics.PreferredBackBufferHeight = 600;
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize ()
		{
			// TODO: Add your initialization logic here
			r_player = new Rectangle(0,0,24,24);
			walls[0] = new Wall();
			walls[1] = new Wall();
			walls[2] = new Wall();
			walls[3] = new Wall();


			walls[0]. r_pos = new Rectangle(50,50,32,32);
			
			walls[1]. r_pos  = new Rectangle(100,100,32,32);
			
			walls[2]. r_pos  = new Rectangle(150,150,32,32);
			
			walls[3]. r_pos  = new Rectangle(200,200,32,32);

			base.Initialize ();
				
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent ()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch (GraphicsDevice);
			t_player = Content.Load<Texture2D>("Sprites/char.png");
			Texture2D t_wall = Content.Load<Texture2D>("Sprites/wall.png");
			foreach (Wall wall in walls) {
				wall.t_def = t_wall;
			}
			//TODO: use this.Content to load your game content here 
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update (GameTime gameTime)
		{
			// For Mobile devices, this logic will close the Game when the Back button is pressed

			if (Keyboard.GetState().IsKeyDown(Keys.Left))
			{
				r_player.X -= 1;
			}

			if (Keyboard.GetState().IsKeyDown(Keys.Right))
			{
				r_player.X += 1;
			}

			if (Keyboard.GetState().IsKeyDown(Keys.Up))
			{
				r_player.Y -= 1;
			}

			if (Keyboard.GetState().IsKeyDown(Keys.Down))
			{
				r_player.Y += 1;
			}

			// TODO: Add your update logic here			
			base.Update (gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw (GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear (Color.CornflowerBlue);
		
			//TODO: Add your drawing code here
			spriteBatch.Begin();
			spriteBatch.Draw(t_player,r_player,Color.White);
			foreach (Wall wall in walls) {
				spriteBatch.Draw(wall.t_def,wall.r_pos,Color.White);
			}
			spriteBatch.End();
			base.Draw (gameTime);
		}
	}
	public class Wall
	{
			public Rectangle r_pos;
			public Texture2D t_def;
	}

}

