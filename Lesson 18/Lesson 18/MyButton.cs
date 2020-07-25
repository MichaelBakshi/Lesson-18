using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18
{
    internal class MyButton
    {
        protected Point topLeft;
        protected Point bottomRight;
        private int width;
        private int height;

        internal MyButton(int topLeft, int bottomRight)
        {

        }

        internal int GetWidth()
        {
            return width;
        }

        internal int GetHeight()
        {
            return height;
        }

        internal bool SetTopLeft(Point point)
        {
            return false;
        }

        internal bool SetBottomRight(Point point)
        {
            return false;
        }

        internal Point GetTopLeft()
        {
            return topLeft;
        }

        internal Point GetBottomRight()
        {
            return bottomRight;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
