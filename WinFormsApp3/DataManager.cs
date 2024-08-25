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

        public static void Read()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.Title = "Select a File";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<Point3D> temp = new List<Point3D>();
                try
                {
                    temp = XYZReader.ReadXYZ(filePath);
                }
                catch (Exception ex)
                {
                    throw new Exception("Invalid file format", ex);
                }

                DataStorage.polygon3DPoints = temp.ToArray();
                Form1.polygonPointsFloat = new PointF[DataStorage.polygon3DPoints.Length];
                Convert3DtoFloat(DataStorage.polygon3DPoints, Form1.polygonPointsFloat);
                
            }
        }

        #region Rotation code
        public static void RotateX()
        {
            if(0 != DataStorage.rectangle.Height)
            {
                DataStorage.rectangle = new Rectangle(Transformation.RotateX(DataStorage.rectangle.Points(), 10));
                Convert3DtoFloat(DataStorage.rectangle.Points(), Form1.points1);
            }
            if(null != DataStorage.polygon3DPoints)
            {
                DataStorage.polygon3DPoints = Transformation.RotateX(DataStorage.polygon3DPoints, 10);
                Convert3DtoFloat(DataStorage.polygon3DPoints, Form1.polygonPointsFloat);
            }
            
        }
        public static void RotateY()
        {
            if (0 != DataStorage.rectangle.Height)
            {
                DataStorage.rectangle = new Rectangle(Transformation.RotateY(DataStorage.rectangle.Points(), 10));
                Convert3DtoFloat(DataStorage.rectangle.Points(), Form1.points1);
            }
            if (null != DataStorage.polygon3DPoints)
            {
                DataStorage.polygon3DPoints = Transformation.RotateY(DataStorage.polygon3DPoints, 10);
                Convert3DtoFloat(DataStorage.polygon3DPoints, Form1.polygonPointsFloat);
            }
        }
        public static void RotateZ()
        {
            if (0 != DataStorage.rectangle.Height)
            {
                DataStorage.rectangle = new Rectangle(Transformation.RotateZ(DataStorage.rectangle.Points(), 10));
                Convert3DtoFloat(DataStorage.rectangle.Points(), Form1.points1);
            }
            if (null != DataStorage.polygon3DPoints)
            {
                DataStorage.polygon3DPoints = Transformation.RotateZ(DataStorage.polygon3DPoints, 10);
                Convert3DtoFloat(DataStorage.polygon3DPoints, Form1.polygonPointsFloat);
            }

        }
        public static void ReverseRotateX()
        {
            if (0 != DataStorage.rectangle.Height)
            {
                DataStorage.rectangle = new Rectangle(Transformation.RotateX(DataStorage.rectangle.Points(), -10));
                Convert3DtoFloat(DataStorage.rectangle.Points(), Form1.points1);
            }
            if (null != DataStorage.polygon3DPoints)
            {
                DataStorage.polygon3DPoints = Transformation.RotateX(DataStorage.polygon3DPoints, -10);
                Convert3DtoFloat(DataStorage.polygon3DPoints, Form1.polygonPointsFloat);
            }
        }
        public static void ReverseRotateY()
        {
            if (0 != DataStorage.rectangle.Height)
            {
                DataStorage.rectangle = new Rectangle(Transformation.RotateY(DataStorage.rectangle.Points(), -10));
                Convert3DtoFloat(DataStorage.rectangle.Points(), Form1.points1);
            }
            if (null != DataStorage.polygon3DPoints)
            {
                DataStorage.polygon3DPoints = Transformation.RotateY(DataStorage.polygon3DPoints, -10);
                Convert3DtoFloat(DataStorage.polygon3DPoints, Form1.polygonPointsFloat);
            }
        }
        public static void ReverseRotateZ()
        {
            if (0 != DataStorage.rectangle.Height)
            {
                DataStorage.rectangle = new Rectangle(Transformation.RotateZ(DataStorage.rectangle.Points(), -10));
                Convert3DtoFloat(DataStorage.rectangle.Points(), Form1.points1);
            }
            if (null != DataStorage.polygon3DPoints)
            {
                DataStorage.polygon3DPoints = Transformation.RotateZ(DataStorage.polygon3DPoints, -10);
                Convert3DtoFloat(DataStorage.polygon3DPoints, Form1.polygonPointsFloat);
            }
        }
        #endregion


    }
}
