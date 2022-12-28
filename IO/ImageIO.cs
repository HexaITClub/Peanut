using Peanut.Graphics;

namespace Peanut.IO
{
    public class ImageIO
    {
        public static bool Save(Image image, string path, string ext)
        {
            Console.WriteLine("Saving " + image + " as " + path);
            return true;
        }
    }
}