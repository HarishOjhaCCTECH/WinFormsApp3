using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public delegate void ProcessRect(Point3D startPoint, float length, float height);

    internal class Rectangle
    {
        private Point3D[] _points = new Point3D[4];

        public float Length { set; get; }
        public float Height { set; get; }
        public Point3D[] Points() { return _points; }

        public Rectangle() { }
        public Rectangle(Point3D[] points) { _points = points; }

        public static void Make(Point3D startPoint, float length, float height)
        {

            float x = startPoint.X;
            float y = startPoint.Y;
            float z = startPoint.Z;
            Point3D[] tempPoints = new Point3D[4];
            if (DataStorage.planeNum == 1) // xy plane, x is length, y is height
            {
                tempPoints = new Point3D[] {
                    new Point3D(x, y, z),
                    new Point3D(x + length, y, z),
                    new Point3D(x + length, y + height, z),
                    new Point3D(x, y + height, z)
                };

            }
            else if (DataStorage.planeNum == 2) // yz plane, z is length, y is height
            {
                tempPoints = new Point3D[] {
                    new Point3D(x, y, z),
                    new Point3D(x, y, z+length),
                    new Point3D(x, y+height, z+length),
                    new Point3D(x, y+height, z)
                };

            }
            else if (DataStorage.planeNum == 3) // xz plane, x is length, z is height
            {
                tempPoints = new Point3D[] {
                    new Point3D(x, y, z),
                    new Point3D(x+length, y, z),
                    new Point3D(x+length, y, z+height),
                    new Point3D(x, y, z+height)
                };
            }

            DataStorage.rectangle = new Rectangle(tempPoints);
            DataStorage.rectangle.Length = length;
            DataStorage.rectangle.Height = height;

        }

    }


    

    
}
