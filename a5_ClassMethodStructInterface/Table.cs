using System;
namespace a5_ClassMethodStructInterface_Table
{
	public class Table
    {
        public int Width;
        public int Height;
        public int Lenght;
        private int _packageSize;

        public Table()
        {

        }

        public Table(int width, int height, int length)
        {
            Width = width;
            Height = height;
            Lenght = length;
        }

        public void CalculatingPackageSize(int width, int height, int length)
        {
            _packageSize = (Lenght * Width * Height) / 10000;
            Console.WriteLine($"Package size {_packageSize}m2");
        }

        public void ShowSettings()
        {
            Console.WriteLine($"Table setting:\nWidht {Width}\nHeight {Height}\nLenght {Lenght}");
        }
    }
}

