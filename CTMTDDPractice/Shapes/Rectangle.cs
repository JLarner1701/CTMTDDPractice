namespace CTMTDDPractice.Shapes
{
    public class Rectangle
    {
        private readonly int _length;
        private readonly int _width;

        public Rectangle(int length, int width)
        {
            _length = length;
            _width = width;
        }

        public int Perimeter()
        {
            return _length * 2 + _width * 2;
        }

        public int Area()
        {
            return _length * _width;
        }
    }
}