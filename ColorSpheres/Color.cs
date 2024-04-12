using System;

namespace ColorSpheres
{
    public class Color
    {
        private byte _red;
        private byte _green;
        private byte _blue;
        private byte _alpha;
        Color(byte _red, byte _green, byte _blue, byte _alpha)
        {
            this._red = _red;
            this._green = _green;
            this._blue = _blue;
            this._alpha= _alpha;
        }
        Color(byte _red, byte _green, byte _blue)
        {
            this._red = _red;
            this._green = _green;
            this._blue = _blue;
            this._alpha= 255;
        }
    }
}