using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18
{
    internal class Point
    {
        private int _x;
        private int _y;

        internal Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        internal int GetX()
        {
            return _x;
        }

        internal int GetY()
        {
            return _y;
        }

        internal void SetX(int setX)
        {
            if (setX > 0 || setX<800 )
            {
                this._x = setX;
            }
            else
            {
                Console.WriteLine("Out the boundaries");
            }
        }

        internal void SetY(int setY)
        {
            if (setY > 0 || setY < 600)
            {
                this._y = setY;
            }
            else
            {
                Console.WriteLine("Out the boundaries");
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
