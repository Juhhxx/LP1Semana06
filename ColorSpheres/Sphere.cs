using System;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color _color;
        private int _radius;
        private int _throw;
        Sphere(Color _color, int _radius)
        {
            this._color = _color;
            this._radius = _radius;
            _throw = 0;
        }
        public void Pop()
        {
            _radius = 0;
        }
        public void Throw()
        {
            _throw += 1;
        }
        public int GetTimesThrown()
        {
            return _throw;
        }
    }
}