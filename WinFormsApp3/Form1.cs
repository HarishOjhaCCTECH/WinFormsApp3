using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp3;



namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        public static PointF[] points1 = new PointF[4];
        private PointF[] points2 = new PointF[4];
        public static List<PointF[]> points3 = new List<PointF[]>();
        public static PointF[] polygonPointsFloat;
        private PointF _panelMidPoint;
        private PointF[] _xAxis;
        private PointF[] _yAxis;
        private PointF[] _zAxis;
        


        public Form1()
        {
            InitializeComponent();
            _panelMidPoint = new PointF((int)(_panel.Width / 2f), (int)(_panel.Height / 2f));
            DataStorage.paintPanelCenter = _panelMidPoint;

            PointF origin = Point3D.Coordinates(0, 0, 0);
            _xAxis = new PointF[] { origin, Point3D.Coordinates(50, 0, 0) };
            _yAxis = new PointF[] { origin, Point3D.Coordinates(0, 50, 0) };
            _zAxis = new PointF[] { origin, Point3D.Coordinates(0, 0, 50) };

            _xAxisLabel.Location = new Point((int)Point3D.Coordinates(60, 0, 0).X, (int)Point3D.Coordinates(60, 0, 0).Y);
            _yAxisLabel.Location = new Point((int)Point3D.Coordinates(0, 70, 0).X, (int)Point3D.Coordinates(0, 70, 0).Y);
            _zAxisLabel.Location = new Point((int)Point3D.Coordinates(0, 0, 60).X, (int)Point3D.Coordinates(0, 0, 60).Y);




            _tranformButton.Enabled = false;

            _x1TextBox.Enabled = false;
            _y1TextBox.Enabled = false;
            _y2TextBox.Enabled = false;
            _z2TextBox.Enabled = false;
            _x3TextBox.Enabled = false;
            _z3TextBox.Enabled = false;
            _lengthTextBox.Enabled = false;
            _heightTextBox.Enabled = false;

            _heightTextBox.TextChanged += TextBox_NumbersFilled;
            _lengthTextBox.TextChanged += TextBox_NumbersFilled;
            panel1.MouseWheel += Panel1_MouseWheel;
            panel2.MouseWheel += Panel2_MouseWheel;
            panel3.MouseWheel += Panel3_MouseWheel;
            _panel.Paint += new PaintEventHandler(_panel_Paint);
        }

        #region Mouse Panels
        private void Panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                DataManager.RotateX();
            }
            else
            {
                DataManager.ReverseRotateX();
            }
            _panel.Invalidate();
        }

        private void Panel2_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                DataManager.RotateY();
            }
            else
            {
                DataManager.ReverseRotateY();
            }
            _panel.Invalidate();
        }

        private void Panel3_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                DataManager.RotateZ();
            }
            else
            {
                DataManager.ReverseRotateZ();
            }
            _panel.Invalidate();
        }
        #endregion

        private void TextBox_NumbersFilled(object? sender, EventArgs e)
        {
            if (IsAllTextBoxFilledWithNumbers())
            {
                ExecuteDrawCommand();
            }
        }
        private bool IsAllTextBoxFilledWithNumbers()
        {
            bool isHeightGiven = int.TryParse(_heightTextBox.Text, out _);
            bool isLengthGiven = int.TryParse(_lengthTextBox.Text, out _);
            return isHeightGiven && isLengthGiven;
        }

        private void ExecuteDrawCommand()
        {
            float length, height;
            try
            {
                length = Convert.ToSingle(_lengthTextBox.Text);
                height = Convert.ToSingle(_heightTextBox.Text);
            }
            catch (Exception ex)
            {
                throw new System.FormatException("Invalid input");
            }

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
            _tranformButton.Enabled = true;

        }


        private void _panel_Paint(object sender, PaintEventArgs e)
        {
            // drawing three axes
            e.Graphics.DrawLines(new Pen(Color.Red, 3), _xAxis);
            e.Graphics.DrawLines(new Pen(Color.Green, 3), _yAxis);
            e.Graphics.DrawLines(new Pen(Color.Blue, 3), _zAxis);


            // making rectangle on screen
            e.Graphics.DrawPolygon(new Pen(Color.White, 3), points1);


            // making tranformed rectangle
            e.Graphics.DrawPolygon(new Pen(Color.Aquamarine, 3), points2);


            // making circles on screen
            Pen redPen = new Pen(Color.Red, 3);
            for (int i = 0; i < points3.Count; i++) { e.Graphics.DrawPolygon(redPen, points3[i]); }
            redPen.Dispose();



            // Check if polygonPoints is valid before drawing
            if (polygonPointsFloat != null && polygonPointsFloat.Length >= 3)
            {
                e.Graphics.DrawPolygon(new Pen(Color.Yellow, 3), polygonPointsFloat);
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void _resetButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void _tranformButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataManager.Transform();
                DataManager.FindCirclePoints();
                DataManager.Convert3DtoFloat(DataStorage.transformedRectangle.Points(), points2);

                // Force the form to repaint and draw the transformed rectangle and circles
                _panel.Invalidate();
                _tranformButton.Enabled = false;
            }
            catch (Exception ex)
            {
                // Handle the exception here
                throw new Exception("no input");
            }
        }

        #region Plane CheckBoxes
        private void _xyPlaneCheckBox_Click(object sender, EventArgs e)
        {
            points1 = new PointF[4];
            _yzPlaneCheckBox.CheckState = CheckState.Unchecked;
            _xzPlaneCheckBox.CheckState = CheckState.Unchecked;

            _x1TextBox.Enabled = true;
            _y1TextBox.Enabled = true;
            _y2TextBox.Enabled = false;
            _z2TextBox.Enabled = false;
            _x3TextBox.Enabled = false;
            _z3TextBox.Enabled = false;

            _y2TextBox.Clear();
            _z2TextBox.Clear();
            _x3TextBox.Clear();
            _z3TextBox.Clear();

            _lengthTextBox.Clear();
            _heightTextBox.Clear();

            _lengthTextBox.Enabled = true;
            _heightTextBox.Enabled = true;

            _tranformButton.Enabled = false;
            _panel.Invalidate();
        }

        private void _yzPlaneCheckBox_Click(object sender, EventArgs e)
        {
            points1 = new PointF[4];
            _xyPlaneCheckBox.CheckState = CheckState.Unchecked;
            _xzPlaneCheckBox.CheckState = CheckState.Unchecked;

            _x1TextBox.Enabled = false;
            _y1TextBox.Enabled = false;
            _y2TextBox.Enabled = true;
            _z2TextBox.Enabled = true;
            _x3TextBox.Enabled = false;
            _z3TextBox.Enabled = false;

            _x1TextBox.Clear();
            _y1TextBox.Clear();
            _x3TextBox.Clear();
            _z3TextBox.Clear();

            _lengthTextBox.Clear();
            _heightTextBox.Clear();

            _lengthTextBox.Enabled = true;
            _heightTextBox.Enabled = true;
            
            _tranformButton.Enabled = false;
            _panel.Invalidate();
        }

        private void _xzPlaneCheckBox_Click(object sender, EventArgs e)
        {
            points1 = new PointF[4];
            _xyPlaneCheckBox.CheckState = CheckState.Unchecked;
            _yzPlaneCheckBox.CheckState = CheckState.Unchecked;

            _x1TextBox.Enabled = false;
            _y1TextBox.Enabled = false;
            _y2TextBox.Enabled = false;
            _z2TextBox.Enabled = false;
            _x3TextBox.Enabled = true;
            _z3TextBox.Enabled = true;

            _x1TextBox.Clear();
            _y1TextBox.Clear();
            _y2TextBox.Clear();
            _z2TextBox.Clear();

            _lengthTextBox.Clear();
            _heightTextBox.Clear();

            _lengthTextBox.Enabled = true;
            _heightTextBox.Enabled = true;

            _tranformButton.Enabled = false;
            _panel.Invalidate();
        }
        #endregion

        private Form _popupForm; // Declare a private field to store the popup form
        private void DisplayPopup(string message)
        {
            // Check if the popup form is already created
            if (_popupForm == null || _popupForm.IsDisposed)
            {
                // Create a new form for the popup
                _popupForm = new Form();

                // Set the properties of the form
                _popupForm.Text = "Popup";
                _popupForm.Size = new Size(300, 200);
                _popupForm.StartPosition = FormStartPosition.CenterScreen;

                // Create a label to display the message
                Label messageLabel = new Label();
                messageLabel.Text = message;
                messageLabel.Dock = DockStyle.Fill;
                messageLabel.TextAlign = ContentAlignment.MiddleCenter;

                // Add the label to the form
                _popupForm.Controls.Add(messageLabel);
            }
            else
            {
                // Update the message label of the existing popup form
                Label messageLabel = (Label)_popupForm.Controls[0];
                messageLabel.Text = message;
            }

            // Show the form as a non-modal dialog
            _popupForm.Show();
        }

        private void _xyzReadButton_Click(object sender, EventArgs e)
        {
            DataManager.Read();
            _panel.Invalidate();
        }

    }
}
