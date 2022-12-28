
namespace Peanut.Graphics.Shapes
{
	public class Line: IShape
	{
		private int X1, Y1, X2, Y2;

		public Line(int x1, int y1, int x2, int y2)
		{
			X1 = x1;
			Y1 = y1;
			X2 = x2;
			X2 = x2;
		}

		public List<Point2D> GetDrawable()
		{
			return GenPoints();
		}

		private List<Point2D> GenPoints()
		{
			List<Point2D> pts = new();
			int dx = Math.Abs(X2 - X1);
			int dy = Math.Abs(Y2 - Y1);
			int steps = 0;
			if (dx > dy) steps = dx;
			else steps = dy;

			dx /= steps;
			dy /= steps;

			int x = X1;
			int y = Y1;

			int i = 0;
			while(i < steps)
			{
                pts.Add(new Point2D(x, y));
                x += dx;
				y += dy;
				i++;
			}
			return pts;
		}
	}
}