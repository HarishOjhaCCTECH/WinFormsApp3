using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    static internal class Transformation
    {
        // rotating polygon about x axis
        
        public static Point3D[] RotateX(Point3D[] polygon, double angleInDegree) 
        {
            double angleInRadian = (Math.PI / 180)*angleInDegree;
            float[][] rotationMatrix = [
                [1,0,0],
                [0,(float)Math.Cos(angleInRadian), (float)-Math.Sin(angleInRadian)],
                [0,(float)Math.Sin(angleInRadian), (float)Math.Cos(angleInRadian)]
            ];

            
            // matrix multiplication
            Point3D[] tempPoints = new Point3D[polygon.Length];
            for (int j =0; j < polygon.Length; j++)
            {
                float[] tempArr = new float[3];
                for (int i = 0; i < 3; i++)
                {
                    tempArr[i] = polygon[j].X * rotationMatrix[i][0] + polygon[j].Y * rotationMatrix[i][1] + polygon[j].Z * rotationMatrix[i][2];
                }
                tempPoints[j] = new Point3D(tempArr[0], tempArr[1], tempArr[2]);   
            }
            return tempPoints;
        }

        // rotating polygon about y axis
        [Obsolete("This method is deprecated, use RotateY instead")]
        public static Point3D[] RotateY(Point3D[] polygon, double angleInDegree)
        {
            double angleInRadian = (Math.PI / 180) * angleInDegree;
            float[][] rotationMatrix = [
                [(float)Math.Cos(angleInRadian), 0, (float)Math.Sin(angleInRadian)],
                [0,1,0],
                [(float)-Math.Sin(angleInRadian), 0, (float)Math.Cos(angleInRadian)],

            ];


            // matrix multiplication
            Point3D[] tempPoints = new Point3D[polygon.Length];
            for (int j = 0; j < polygon.Length; j++)
            {
                float[] tempArr = new float[3];
                for (int i = 0; i < 3; i++)
                {
                    tempArr[i] = polygon[j].X * rotationMatrix[i][0] + polygon[j].Y * rotationMatrix[i][1] + polygon[j].Z * rotationMatrix[i][2];
                }
                tempPoints[j] = new Point3D(tempArr[0], tempArr[1], tempArr[2]);
            }
            return tempPoints;

        }

        // rotating polygon about z axis
        public static Point3D[] RotateZ(Point3D[] polygon, double angleInDegree)
        {
            double angleInRadian = (Math.PI / 180) * angleInDegree;
            float[][] rotationMatrix = [
                [(float)Math.Cos(angleInRadian), (float)-Math.Sin(angleInRadian),0],
                [(float)Math.Sin(angleInRadian), (float)Math.Cos(angleInRadian), 0],
                [0,0,1]

            ];


            // matrix multiplication
            Point3D[] tempPoints = new Point3D[polygon.Length];
            for (int j = 0; j < polygon.Length; j++)
            {
                float[] tempArr = new float[3];
                for (int i = 0; i < 3; i++)
                {
                    tempArr[i] = polygon[j].X * rotationMatrix[i][0] + polygon[j].Y * rotationMatrix[i][1] + polygon[j].Z * rotationMatrix[i][2];
                }
                tempPoints[j] = new Point3D(tempArr[0], tempArr[1], tempArr[2]);
            }

            return tempPoints;
        }
        public static void Scale(List<Point3D> polygon, float scale)
        {
            for (int i = 0; i < polygon.Count; i++)
            {
                polygon[i].X *= scale;
                polygon[i].Y *= scale;
                polygon[i].Z *= scale;
            }
        }

    }
}
