using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeletextProgramFAB.FABClasses
{
    public static class FABTeletextControlCharacters
    {

        public enum ColorsText
        {
            Black = 0,
            Red = 1,
            Green = 2,
            Yellow = 3,
            Blue = 4,
            Magenta = 5,
            Cyan = 6,
            White = 7,
        }

        public enum ControlGraphic
        {
            Black = 16,
            Red = 17,
            Green = 18, 
            Yellow = 19,
            Blue = 20,             
            Magenta = 21,
            Cyan = 22,
            White = 23,
        }

        public enum ControlsOther
        {
            Flash = 8,
            Steady = 9,
            EndBox = 10,
            StartBox = 11,
            NormalHeight = 12,
            DoubleHeight = 13,
            DoubleWidth = 14,
            DoubleSize = 15,
            Conceal = 24,
            ContiguousGraphics = 25,
            SeparatedGraphics = 26,
            Twist = 27,
            BlackBackground = 28,
            NewBackground = 29,
            HoldGraphics = 30,
            ReleaseGraphics = 31,
        }
    }
}
