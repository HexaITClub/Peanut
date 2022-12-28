namespace Peanut.Graphics
{
    public abstract class Image
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Image(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public abstract int[] GetDrawable();
    }

    public class PPMImage : Image
    {
        public PPMImage(int width, int height) : base(width, height) { }

        override public int[] GetDrawable()
        {
            return new int[] { 5, 4 };
        }
    }
}

