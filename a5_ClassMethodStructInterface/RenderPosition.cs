using System;
namespace a5_ClassMethodStructInterface_RenderPosition
{
	public class RenderPosition
	{
        public void Draw(int x, int y, char ch = 'ø')
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ch);
        }
    }
}

