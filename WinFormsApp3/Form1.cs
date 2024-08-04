using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private bool buttonClicked = false;

        private PointF[] points1 = new PointF[4];
        private PointF[] points2 = new PointF[4];
        public static List<PointF[]> points3 = new List<PointF[]>();

        public Form1()
        {
            InitializeComponent();
            _panel.Paint += new PaintEventHandler(Panel1_Paint);
        }


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            // drawing three axes
            e.Graphics.DrawLines(new Pen(Color.Red, 3), DataStorage.xAxis);
            e.Graphics.DrawLines(new Pen(Color.Green, 3), DataStorage.yAxis);
            e.Graphics.DrawLines(new Pen(Color.Blue, 3), DataStorage.zAxis);


            if (buttonClicked)
            {
                // making rectangle on screen
                e.Graphics.DrawPolygon(new Pen(Color.White, 3), points1);


                // making tranformed rectangle
                e.Graphics.DrawPolygon(new Pen(Color.Aquamarine, 3), points2);


                // making circles on screen
                Pen redPen = new Pen(Color.Red, 3);
                for (int i = 0; i < points3.Count; i++) { e.Graphics.DrawPolygon(redPen, points3[i]); }
                redPen.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            DataStorage.panelMidPoint = new PointF((int)(_panel.Width / 2f), (int)(_panel.Height / 2f));

            DataStorage.xAxis = new PointF[] { Point3D.Coordinates(0, 0, 0), Point3D.Coordinates(50, 0, 0) };
            DataStorage.yAxis = new PointF[] { Point3D.Coordinates(0, 0, 0), Point3D.Coordinates(0, 50, 0) };
            DataStorage.zAxis = new PointF[] { Point3D.Coordinates(0, 0, 0), Point3D.Coordinates(0, 0, 50) };


            float length = Convert.ToSingle(_lengthTextBox.Text);
            float height = Convert.ToSingle(_heightTextBox.Text);
            Point3D rectStart = new Point3D(0, 0, 0);


            // determining the coordinates of rectangle
            if (_xyPlaneCheckBox.Checked)
            {
                float xBox = Convert.ToSingle(_x1TextBox.Text);
                float yBox = Convert.ToSingle(_y1TextBox.Text);
                float zBox = 0f;
                rectStart = new Point3D(xBox, yBox, zBox);
                DataStorage.planeNum = 1;
                DataManager.MakeRectangle(rectStart, length, height);


            }
            else if (_yzPlaneCheckBox.Checked)
            {
                float xBox = 0;
                float yBox = Convert.ToSingle(_y2TextBox.Text);
                float zBox = Convert.ToSingle(_z2TextBox.Text);
                rectStart = new Point3D(xBox, yBox, zBox);
                DataStorage.planeNum = 2;
                DataManager.MakeRectangle(rectStart, length, height);

            }
            else if (_xzPlaneCheckBox.Checked)
            {
                float xBox = Convert.ToSingle(_x3TextBox.Text);
                float yBox = 0;
                float zBox = Convert.ToSingle(_z3TextBox.Text);
                rectStart = new Point3D(xBox, yBox, zBox);
                DataStorage.planeNum = 3;
                DataManager.MakeRectangle(rectStart, length, height);

            }


            // converting Point3D to pointf for drawing
            DataManager.Convert3DtoFloat(DataStorage.rectangle.Points(), points1);


            // Force the form to repaint and draw the rectangle
            _panel.Invalidate();

            // diabling the controls for user
            _x1TextBox.Enabled = false;
            _y1TextBox.Enabled = false;
            _y2TextBox.Enabled = false;
            _z2TextBox.Enabled = false;
            _x3TextBox.Enabled = false;
            _z3TextBox.Enabled = false;
            _lengthTextBox.Enabled = false;
            _heightTextBox.Enabled = false;
            _xyPlaneCheckBox.Enabled = false;
            _xzPlaneCheckBox.Enabled = false;
            _yzPlaneCheckBox.Enabled = false;
            _tranformButton.Enabled = true;
            _drawButton.Enabled = false;

        }


        private void _resetButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void _tranformButton_Click(object sender, EventArgs e)
        {
            DataManager.Transform();
            DataManager.FindCirclePoints();
            DataManager.Convert3DtoFloat(DataStorage.transformedRectangle.Points(), points2);

            // Force the form to repaint and draw the transformed rectangle and circles
            _panel.Invalidate();
            _tranformButton.Enabled = false;
        }

        private void _xyPlaneCheckBox_Click(object sender, EventArgs e)
        {
            _yzPlaneCheckBox.Enabled = false;
            _xzPlaneCheckBox.Enabled = false;
            _y2TextBox.Enabled = false;
            _z2TextBox.Enabled = false;
            _x3TextBox.Enabled = false;
            _z3TextBox.Enabled = false;
            _tranformButton.Enabled = false;
        }

        private void _yzPlaneCheckBox_Click(object sender, EventArgs e)
        {
            _xyPlaneCheckBox.Enabled = false;
            _xzPlaneCheckBox.Enabled = false;
            _x1TextBox.Enabled = false;
            _y1TextBox.Enabled = false;
            _x3TextBox.Enabled = false;
            _z3TextBox.Enabled = false;
            _tranformButton.Enabled = false;
        }

        private void _xzPlaneCheckBox_Click(object sender, EventArgs e)
        {
            _xyPlaneCheckBox.Enabled = false;
            _yzPlaneCheckBox.Enabled = false;
            _x1TextBox.Enabled = false;
            _y1TextBox.Enabled = false;
            _y2TextBox.Enabled = false;
            _z2TextBox.Enabled = false;
            _tranformButton.Enabled = false;
        }
    }

}
