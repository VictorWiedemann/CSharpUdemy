using System;
using System.Drawing;

namespace CSharpUdemy
{
    public partial class Position
    {
        public int X;
        public int Y;

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Position newLocation)
        {

            //This is identical to:
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;

            //handle the case a null is thrown
            if (newLocation == null)
            {
                throw new ArgumentException("newLocation error");
            }

            Move(newLocation.X, newLocation.Y);
        }
    }
}