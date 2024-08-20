using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    static internal class DataManager
    {                
        public static void MakeRectangle(Point3D startPoint, float length, float height)
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

            } else if (DataStorage.planeNum == 2) // yz plane, z is length, y is height
            {
                tempPoints = new Point3D[] {
                    new Point3D(x, y, z),
                    new Point3D(x, y, z+length),
                    new Point3D(x, y+height, z+length),
                    new Point3D(x, y+height, z)
                };

            }else if (DataStorage.planeNum == 3) // xz plane, x is length, z is height
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


        // rotating rectangle about anyone axis
        public static void Transform()
        {
            if (DataStorage.planeNum == 1)
            {
                DataStorage.transformedRectangle = new Rectangle (Transformation.RotateX(DataStorage.rectangle.Points(), 90));
                DataStorage.transformedRectangle.Length = DataStorage.rectangle.Length;
                DataStorage.transformedRectangle.Height = DataStorage.rectangle.Height;
                DataStorage.planeNum = 3;//converting plane number from xy to xz
            }
            else if (DataStorage.planeNum == 2)
            {
                DataStorage.transformedRectangle = new Rectangle(Transformation.RotateY(DataStorage.rectangle.Points(),90));
                DataStorage.transformedRectangle.Length = DataStorage.rectangle.Length;
                DataStorage.transformedRectangle.Height = DataStorage.rectangle.Height;
                DataStorage.planeNum = 1;//converting plane number from yz to xy

            }
            else if (DataStorage.planeNum == 3)
            {
                DataStorage.transformedRectangle = new Rectangle(Transformation.RotateZ(DataStorage.rectangle.Points(),90));
                DataStorage.transformedRectangle.Length = DataStorage.rectangle.Length;
                DataStorage.transformedRectangle.Height = DataStorage.rectangle.Height;
                DataStorage.planeNum = 2;//converting plane number from xz to yz
            }

        }


        public static void Convert3DtoFloat(Point3D[] arr1, PointF[] arr2) 
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = Point3D.Coordinates(arr1[i].X, arr1[i].Y, arr1[i].Z);
            }
        }


        public static void FindCirclePoints()
        {
            Circle.FindBorderPoints(DataStorage.transformedRectangle, DataStorage.planeNum, Form1.points3);
        }

        public static List<Point3D> Read(string filePath)
        {
            return XYZReader.ReadXYZ(filePath);            
        }

        public static void RotateX()
        {
            DataStorage.rectangle = new Rectangle(Transformation.RotateX(DataStorage.rectangle.Points(), 10));
        }
        public static void RotateY() 
        {
            DataStorage.rectangle = new Rectangle(Transformation.RotateY(DataStorage.rectangle.Points(), 10));
        }
        public static void RotateZ()
        {
            DataStorage.rectangle = new Rectangle(Transformation.RotateZ(DataStorage.rectangle.Points(), 10));
        }


        public static void ReverseRotateX()
        {
            DataStorage.rectangle = new Rectangle(Transformation.RotateX(DataStorage.rectangle.Points(), -10));
        }
        public static void ReverseRotateY() {
            DataStorage.rectangle = new Rectangle(Transformation.RotateY(DataStorage.rectangle.Points(), -10));
        }
        public static void ReverseRotateZ()
        {
            DataStorage.rectangle = new Rectangle(Transformation.RotateZ(DataStorage.rectangle.Points(), -10));
        }


    }
}
