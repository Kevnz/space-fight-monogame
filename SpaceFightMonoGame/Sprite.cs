using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

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
			
		}
	}
}