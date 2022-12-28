namespace Peanut.Graphics.Shapes
{
	public class Circle: IShape
	{
		private int CenterX { get; set; }
		private int CenterY { get; set; }
		private int Radius { get; set; }

		public Circle(int centerx, int centery, int radius)
		{
			CenterX = centerx;
			CenterY = centery;
			Radius = radius;
		}

		public List<Point2D> GetDrawable()
		{
			return null;
		}
	}
}