using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceFightMonoGame
{
	public class Sprite
	{
		protected readonly Texture2D Texture;
		protected readonly Vector2 Location;

		public Sprite(Texture2D texture, Vector2 location)
		{
			Texture = texture;
			Location = location;
		} 

		public void Draw(SpriteBatch batch)
		{
			batch.Draw(Texture, Location, Color.Wheat);
		}
		public virtual void Update(GameTime gameTime)
		{

		}
	}

	public class Player : Sprite
	{
		public Player(Texture2D texture, Vector2 location) : base(texture,location) 
		{

		}

		public override void Update(GameTime gameTime)
		{
			//TODO add control
			base.Update(gameTime);
		}
	}
}