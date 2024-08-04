using System;
using System.Drawing;
using WinFormsApp3;

namespace WinFormsApp3
{
    static internal class DataStorage
    {
        public static PointF panelMidPoint;
        public static PointF[] xAxis = new PointF[2];
        public static PointF[] yAxis = new PointF[2];
        public static PointF[] zAxis = new PointF[2];
        public static int planeNum = 0;
        public static Rectangle rectangle = new Rectangle();
        public static Rectangle transformedRectangle = new Rectangle();
    }
}
