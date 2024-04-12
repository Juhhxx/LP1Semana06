using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        public Color Color { get; }
        public int Radius { get; private set; }
        private int _throw;
        
        public Sphere(Color color, int radius)
        {
            Color = color;
            Radius = radius;
            _throw = 0;
        }
        public int Throw
        {
            get => _throw;

            private set
            {
                if (Radius > 0)
                {
                    _throw += 1;
                }
            }
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