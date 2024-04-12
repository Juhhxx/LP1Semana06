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
        public byte GetGray()
        {
            return (byte)((_red + _green + _blue)/3);
        }
    }
}