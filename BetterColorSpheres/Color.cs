using System;

namespace BetterColorSpheres
{
    public class Color
    {
        private readonly byte _red;
        private readonly byte _green;
        private readonly byte _blue;
        private readonly byte _alpha;
        public Color(byte _red, byte _green, byte _blue, byte _alpha)
        {
            this._red = _red;
            this._green = _green;
            this._blue = _blue;
            this._alpha= _alpha;
        }
        public Color(byte _red, byte _green, byte _blue)
        {
            this._red = _red;
            this._green = _green;
            this._blue = _blue;
            this._alpha= 255;
        }
        public byte GetRed()
        {
            return _red;
        }
        public byte GetGreen()
        {
            return _green;
        }
        public byte GetBlue()
        {
            return _blue;
        }
        public byte GetAlpha()
        {
            return _alpha;
        }
        public byte GetGray()
        {
            return (byte)((_red + _green + _blue)/3);
        }
    }
}