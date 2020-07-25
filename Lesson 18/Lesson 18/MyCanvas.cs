using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18
{
    public class MyCanvas
    {
        public const int maxWidth = 800;
        public const int maxHeight = 600;
        private static int buttonIndex = 0;
        private static MyButton[] buttons = new MyButton[MaxButtons];
        private static int MaxButtons = 3;

        public static bool CreateNewButton(int x1, int y1, int x2, int y2)
        {
            return false;
        }

        public static bool MoveButton(int buttonNumber, int x, int y)
        {
            return false;
        }

        public static bool DeleteLastButton()
        {
            return false;
        }

        public static void ClearAllButtons()
        {

        }

        public static int GetCurrentNumberOfButtons()
        {
            return 0;
        }

        public static int GetMaxNumberOfButtons()
        {
            return MaxButtons;
        }

        public static int GetTheMaxWidthOfTheButton()
        {
            return maxWidth;
        }

        public static int GetTheMaxHeightOfTheButton()
        {
            return maxHeight;
        }

        public static bool IsPointInsideAButton(int x, int y)
        {
            return false;
        }

        public static bool CheckIfAnyButtonIsOverlapping()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
