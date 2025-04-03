using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Color
    {        
        public byte Red {get;}
        public byte Green {get;}
        public byte Blue {get;}
        public byte Alpha {get;}

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }



        public string GetColor
        {
            get => $"{Red},{Green},{Blue},{Alpha}";
        }

        public byte GetGray
        {
            get => (byte)((Red+Green+Blue)/3);
        }

    }
}