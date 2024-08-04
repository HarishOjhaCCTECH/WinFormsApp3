using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class Rectangle
    {
        private Point3D[] _points = new Point3D[4];

        public float Length { set; get; }
        public float Height { set; get; }
        public Point3D[] Points() { return _points; }

        public Rectangle() { }
        public Rectangle(Point3D[] points) { _points = points; }
        
    }
}
