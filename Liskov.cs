namespace SOLIDExamples.Liskov
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        public override int Width
        {
            set
            {
                base.Width = base.Height = value;
            }
        }

        public override int Height
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