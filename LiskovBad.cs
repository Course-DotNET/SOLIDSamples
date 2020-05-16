using System.Runtime.InteropServices.ComTypes;

namespace SOLIDExamples
{

    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        public new int Width
        {
            set
            {
                base.Width = base.Height = value;
            }
        }

        public new int Height
        {
            set
            {
                base.Width = base.Height = value;
            }
        }

    }

    public class LiskovBad
    {
        public void Main()
        {
            var rectangle = new Rectangle();
            rectangle.Width = 10;
            rectangle.Height = 15;
            var area = rectangle.GetArea();

            var square = new Square();
            square.Height = 10;
            var area1 = square.GetArea();
        }
        
    }
}