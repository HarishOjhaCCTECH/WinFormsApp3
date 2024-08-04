using System;
using System.Drawing;
namespace WinFormsApp3
{
    class Point3D
    {
        private float _x, _y, _z;

        public Point3D() { }
        public Point3D(float x, float y, float z) { _x = x; _y = y; _z = z; }

        public float X { get { return _x; } set { _x = value; } }
        public float Y { get { return _y; } set { _y = value; } }
        public float Z { get { return _z; } set { _z = value; } }

        public static PointF Coordinates(float x, float y, float z)
        {
            (float originX, float originY) = (DataStorage.panelMidPoint.X, DataStorage.panelMidPoint.Y);
            float sqrt3 = (float)Math.Sqrt(3);
            return new PointF(DataStorage.panelMidPoint.X - z + x, DataStorage.panelMidPoint.Y - (y + ((-z - x) / (sqrt3))));
        }
    }
}
