using System;
namespace a5_ClassMethodStructInterface_PlayerPosition
{
	public class PlayerPosition
	{
        public PlayerPosition(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }

        public int Y { get; private set; }
    }
}

