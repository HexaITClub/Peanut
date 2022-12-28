namespace Peanut.Graphics.Shapes
{
	public class Path2D: IShape
	{
		public Path2D()
		{
		}

		public int[] GetDrawable()
		{
			return new int[] { 4, 5 };
		}
	}
}

