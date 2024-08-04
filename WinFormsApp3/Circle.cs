using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class Circle
    {
        private Point3D _center;
        private static float _radius = 10;

        public Circle(Point3D center, float radius) { _center = center; _radius = radius; }


        // finding the border poins of all the cirles
        public static void FindBorderPoints(Rectangle rect, int planeNum, List<PointF[]> points)
        {
            
            // determining the number of circles
            (int circleRowCount, int circleColumnCount) = ((int)(rect.Height / (_radius * 3)), (int)(rect.Length / (_radius * 3)));
            int circleCount = circleRowCount * circleColumnCount;


            // finding the center for all the circles
            List<Point3D> circleCentersList = new List<Point3D>();
            for (int i = 1; i <= circleRowCount; i++)
            {
                for (int j = 1; j <= circleColumnCount; j++)
                {
                    (float tempX, float tempY, float tempZ) = (0, 0, 0);
                    if (planeNum == 1) // xy plane, x is length, y is height
                    {
                        tempX = ((rect.Length / (circleColumnCount + 1)) * j) + rect.Points()[0].X;
                        tempY = ((rect.Height / (circleRowCount + 1)) * i) + rect.Points()[0].Y;
                        tempZ = 0;
                    }
                    else if (planeNum == 2) // yz plane, z is length, y is height
                    {
                        tempX = 0;
                        tempY = ((rect.Height / (circleColumnCount + 1)) * j) + rect.Points()[0].Y;
                        tempZ = ((rect.Length / (circleRowCount + 1)) * i) + rect.Points()[0].Z;
                    }
                    else if (planeNum == 3) // xz plane, x is length, z is height
                    {
                        tempX = ((rect.Length / (circleColumnCount + 1)) * j) + rect.Points()[0].X;
                        tempY = 0;
                        tempZ = ((rect.Height / (circleRowCount + 1)) * i) + rect.Points()[0].Z;
                    }

                    circleCentersList.Add(new Point3D(tempX, tempY, tempZ));
                }
            }


            // determining the border points for all the circle
            points.Capacity = circleCount;
            for (int i = 0; i < circleCount; i++)
            {
                PointF[] tempArr = new PointF[1000];
                for (int j = 0; j < tempArr.Length; j++)
                {

                    (float x, float y, float z) = (0, 0, 0);
                    double theta = 2.0 * Math.PI * j / tempArr.Length;
                    if (planeNum == 1)
                    {
                        x = circleCentersList[i].X + (float)(_radius * Math.Cos(theta));
                        y = circleCentersList[i].Y + (float)(_radius * Math.Sin(theta));
                        z = 0;
                    }
                    else if (planeNum == 2)
                    {
                        x = 0;
                        y = circleCentersList[i].Y + (float)(_radius * Math.Sin(theta));
                        z = circleCentersList[i].Z + (float)(_radius * Math.Cos(theta));
                    }
                    else if (planeNum == 3)
                    {
                        x = circleCentersList[i].X + (float)(_radius * Math.Cos(theta));
                        y = 0;
                        z = circleCentersList[i].Z + (float)(_radius * Math.Sin(theta));
                    }
                    tempArr[j] = Point3D.Coordinates(x, y, z);

                }
                points.Add(tempArr);
            }
            
        }

    }
}
