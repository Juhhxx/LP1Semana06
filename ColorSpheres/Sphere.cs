using System;

namespace ColorSpheres
{
    public class Sphere
    {
        private readonly Color _color;
        private int _radius;
        private int _throw;
        public Sphere(Color _color, int _radius)
        {
            this._color = _color;
            this._radius = _radius;
            _throw = 0;
        }
        public Color GetColor()
        {
            return _color;
        }
        public void Pop()
        {
            _radius = 0;
        }
        public void Throw()
        {
            if (_radius > 0)
            {
                _throw += 1;
            }
        }
        public int GetTimesThrown()
        {
            return _throw;
        }
    }
}