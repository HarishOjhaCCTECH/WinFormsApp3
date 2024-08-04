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
        private const double _90Deg = Math.PI / 2;
        public static Point3D[] RotateX(Point3D[] polygon) 
        {
            float[][] rotationMatrix = [
                [1, 0, 0],
                [0, 0, -1],
                [0, 1, 0]
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
        public static Point3D[] RotateY(Point3D[] polygon)
        {
            float[][] rotationMatrix = [
                [0, 0, 1],
                [0, 1, 0],
                [-1, 0, 0]
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
        public static Point3D[] RotateZ(Point3D[] polygon)
        {
            float[][] rotationMatrix = [
                [0, -1, 0],
                [1, 0, 0],
                [0, 0, 1]
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
    }
}
