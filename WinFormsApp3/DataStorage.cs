using System;
using System.Drawing;
using WinFormsApp3;

namespace WinFormsApp3
{
    static internal class DataStorage
    {
        public static PointF paintPanelCenter;
        public static int planeNum = 0;
        public static Rectangle rectangle = new Rectangle();
        public static Rectangle transformedRectangle = new Rectangle();
        public static Point3D[] polygon3DPoints;
    }
}
