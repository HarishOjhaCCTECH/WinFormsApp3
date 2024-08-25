namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _x1TextBox = new TextBox();
            _y1TextBox = new TextBox();
            _label1 = new Label();
            _label3 = new Label();
            _label4 = new Label();
            _panel = new Panel();
            _zAxisLabel = new Label();
            _yAxisLabel = new Label();
            _xAxisLabel = new Label();
            _xyPlaneCheckBox = new CheckBox();
            _xzPlaneCheckBox = new CheckBox();
            _yzPlaneCheckBox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            _lengthTextBox = new TextBox();
            _heightTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            _z2TextBox = new TextBox();
            _y2TextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            _z3TextBox = new TextBox();
            _x3TextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            _resetButton = new Button();
            _tranformButton = new Button();
            label10 = new Label();
            _xyzReadButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            _panel.SuspendLayout();
            SuspendLayout();
            // 
            // _x1TextBox
            // 
            _x1TextBox.Location = new Point(894, 73);
            _x1TextBox.Name = "_x1TextBox";
            _x1TextBox.Size = new Size(41, 27);
            _x1TextBox.TabIndex = 0;
            // 
            // _y1TextBox
            // 
            _y1TextBox.Location = new Point(980, 73);
            _y1TextBox.Name = "_y1TextBox";
            _y1TextBox.Size = new Size(41, 27);
            _y1TextBox.TabIndex = 1;
            // 
            // _label1
            // 
            _label1.AutoSize = true;
            _label1.ForeColor = Color.Black;
            _label1.Location = new Point(867, 9);
            _label1.Name = "_label1";
            _label1.Size = new Size(98, 20);
            _label1.TabIndex = 9;
            _label1.Text = "Starting Point";
            // 
            // _label3
            // 
            _label3.AutoSize = true;
            _label3.ForeColor = Color.Black;
            _label3.Location = new Point(873, 287);
            _label3.Name = "_label3";
            _label3.Size = new Size(54, 20);
            _label3.TabIndex = 11;
            _label3.Text = "Length";
            // 
            // _label4
            // 
            _label4.AutoSize = true;
            _label4.ForeColor = Color.Black;
            _label4.Location = new Point(873, 326);
            _label4.Name = "_label4";
            _label4.Size = new Size(54, 20);
            _label4.TabIndex = 12;
            _label4.Text = "Height";
            // 
            // _panel
            // 
            _panel.Controls.Add(_zAxisLabel);
            _panel.Controls.Add(_yAxisLabel);
            _panel.Controls.Add(_xAxisLabel);
            _panel.Location = new Point(1, 1);
            _panel.Name = "_panel";
            _panel.Size = new Size(860, 475);
            _panel.TabIndex = 14;
            _panel.Paint += _panel_Paint;
            // 
            // _zAxisLabel
            // 
            _zAxisLabel.AutoSize = true;
            _zAxisLabel.Location = new Point(319, 312);
            _zAxisLabel.Name = "_zAxisLabel";
            _zAxisLabel.Size = new Size(16, 20);
            _zAxisLabel.TabIndex = 5;
            _zAxisLabel.Text = "z";
            // 
            // _yAxisLabel
            // 
            _yAxisLabel.AutoSize = true;
            _yAxisLabel.Location = new Point(420, 189);
            _yAxisLabel.Name = "_yAxisLabel";
            _yAxisLabel.Size = new Size(16, 20);
            _yAxisLabel.TabIndex = 4;
            _yAxisLabel.Text = "y";
            // 
            // _xAxisLabel
            // 
            _xAxisLabel.AutoSize = true;
            _xAxisLabel.Location = new Point(553, 312);
            _xAxisLabel.Name = "_xAxisLabel";
            _xAxisLabel.Size = new Size(16, 20);
            _xAxisLabel.TabIndex = 3;
            _xAxisLabel.Text = "x";
            // 
            // _xyPlaneCheckBox
            // 
            _xyPlaneCheckBox.AutoSize = true;
            _xyPlaneCheckBox.Location = new Point(867, 43);
            _xyPlaneCheckBox.Name = "_xyPlaneCheckBox";
            _xyPlaneCheckBox.Size = new Size(94, 24);
            _xyPlaneCheckBox.TabIndex = 21;
            _xyPlaneCheckBox.Text = "X-Y Plane";
            _xyPlaneCheckBox.UseVisualStyleBackColor = true;
            _xyPlaneCheckBox.Click += _xyPlaneCheckBox_Click;
            // 
            // _xzPlaneCheckBox
            // 
            _xzPlaneCheckBox.AutoSize = true;
            _xzPlaneCheckBox.Location = new Point(873, 207);
            _xzPlaneCheckBox.Name = "_xzPlaneCheckBox";
            _xzPlaneCheckBox.Size = new Size(95, 24);
            _xzPlaneCheckBox.TabIndex = 22;
            _xzPlaneCheckBox.Text = "X-Z Plane";
            _xzPlaneCheckBox.UseVisualStyleBackColor = true;
            _xzPlaneCheckBox.Click += _xzPlaneCheckBox_Click;
            // 
            // _yzPlaneCheckBox
            // 
            _yzPlaneCheckBox.AutoSize = true;
            _yzPlaneCheckBox.Location = new Point(867, 136);
            _yzPlaneCheckBox.Name = "_yzPlaneCheckBox";
            _yzPlaneCheckBox.Size = new Size(94, 24);
            _yzPlaneCheckBox.TabIndex = 23;
            _yzPlaneCheckBox.Text = "Y-Z Plane";
            _yzPlaneCheckBox.UseVisualStyleBackColor = true;
            _yzPlaneCheckBox.Click += _yzPlaneCheckBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(867, 76);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 24;
            label1.Text = "X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(957, 76);
            label2.Name = "label2";
            label2.Size = new Size(20, 20);
            label2.TabIndex = 25;
            label2.Text = "Y:";
            // 
            // _lengthTextBox
            // 
            _lengthTextBox.Location = new Point(933, 287);
            _lengthTextBox.Name = "_lengthTextBox";
            _lengthTextBox.Size = new Size(41, 27);
            _lengthTextBox.TabIndex = 3;
            // 
            // _heightTextBox
            // 
            _heightTextBox.Location = new Point(933, 324);
            _heightTextBox.Name = "_heightTextBox";
            _heightTextBox.Size = new Size(41, 27);
            _heightTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(957, 163);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 29;
            label3.Text = "Z:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(867, 163);
            label4.Name = "label4";
            label4.Size = new Size(20, 20);
            label4.TabIndex = 28;
            label4.Text = "Y:";
            // 
            // _z2TextBox
            // 
            _z2TextBox.Location = new Point(980, 160);
            _z2TextBox.Name = "_z2TextBox";
            _z2TextBox.Size = new Size(41, 27);
            _z2TextBox.TabIndex = 27;
            // 
            // _y2TextBox
            // 
            _y2TextBox.Location = new Point(894, 160);
            _y2TextBox.Name = "_y2TextBox";
            _y2TextBox.Size = new Size(41, 27);
            _y2TextBox.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(957, 240);
            label5.Name = "label5";
            label5.Size = new Size(21, 20);
            label5.TabIndex = 33;
            label5.Text = "Z:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(867, 240);
            label6.Name = "label6";
            label6.Size = new Size(21, 20);
            label6.TabIndex = 32;
            label6.Text = "X:";
            // 
            // _z3TextBox
            // 
            _z3TextBox.Location = new Point(980, 237);
            _z3TextBox.Name = "_z3TextBox";
            _z3TextBox.Size = new Size(41, 27);
            _z3TextBox.TabIndex = 31;
            // 
            // _x3TextBox
            // 
            _x3TextBox.Location = new Point(894, 237);
            _x3TextBox.Name = "_x3TextBox";
            _x3TextBox.Size = new Size(41, 27);
            _x3TextBox.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(862, 103);
            label7.Name = "label7";
            label7.Size = new Size(165, 20);
            label7.TabIndex = 34;
            label7.Text = "--------------------------";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(862, 190);
            label8.Name = "label8";
            label8.Size = new Size(165, 20);
            label8.TabIndex = 35;
            label8.Text = "--------------------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(862, 267);
            label9.Name = "label9";
            label9.Size = new Size(165, 20);
            label9.TabIndex = 36;
            label9.Text = "--------------------------";
            // 
            // _resetButton
            // 
            _resetButton.Location = new Point(867, 447);
            _resetButton.Name = "_resetButton";
            _resetButton.Size = new Size(150, 29);
            _resetButton.TabIndex = 37;
            _resetButton.Text = "Reset";
            _resetButton.UseVisualStyleBackColor = true;
            _resetButton.Click += _resetButton_Click;
            // 
            // _tranformButton
            // 
            _tranformButton.Location = new Point(873, 412);
            _tranformButton.Name = "_tranformButton";
            _tranformButton.Size = new Size(150, 29);
            _tranformButton.TabIndex = 38;
            _tranformButton.Text = "Transform";
            _tranformButton.UseVisualStyleBackColor = true;
            _tranformButton.Click += _tranformButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(867, 354);
            label10.Name = "label10";
            label10.Size = new Size(165, 20);
            label10.TabIndex = 39;
            label10.Text = "--------------------------";
            // 
            // _xyzReadButton
            // 
            _xyzReadButton.Location = new Point(411, 482);
            _xyzReadButton.Name = "_xyzReadButton";
            _xyzReadButton.Size = new Size(150, 29);
            _xyzReadButton.TabIndex = 41;
            _xyzReadButton.Text = "upload .xyz file";
            _xyzReadButton.UseVisualStyleBackColor = true;
            _xyzReadButton.Click += _xyzReadButton_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(804, 514);
            panel1.Name = "panel1";
            panel1.Size = new Size(43, 52);
            panel1.TabIndex = 48;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(878, 514);
            panel2.Name = "panel2";
            panel2.Size = new Size(49, 52);
            panel2.TabIndex = 49;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(957, 514);
            panel3.Name = "panel3";
            panel3.Size = new Size(49, 52);
            panel3.TabIndex = 49;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(815, 486);
            label11.Name = "label11";
            label11.Size = new Size(16, 20);
            label11.TabIndex = 50;
            label11.Text = "x";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(980, 486);
            label12.Name = "label12";
            label12.Size = new Size(16, 20);
            label12.TabIndex = 51;
            label12.Text = "z";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(894, 486);
            label13.Name = "label13";
            label13.Size = new Size(16, 20);
            label13.TabIndex = 52;
            label13.Text = "y";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(645, 530);
            label14.Name = "label14";
            label14.Size = new Size(123, 20);
            label14.TabIndex = 53;
            label14.Text = "Scroll Rotater =>";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1033, 575);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(_xyzReadButton);
            Controls.Add(label10);
            Controls.Add(_tranformButton);
            Controls.Add(_resetButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(_z3TextBox);
            Controls.Add(_x3TextBox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(_z2TextBox);
            Controls.Add(_y2TextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_label1);
            Controls.Add(_yzPlaneCheckBox);
            Controls.Add(_xzPlaneCheckBox);
            Controls.Add(_xyPlaneCheckBox);
            Controls.Add(_panel);
            Controls.Add(_label4);
            Controls.Add(_label3);
            Controls.Add(_heightTextBox);
            Controls.Add(_lengthTextBox);
            Controls.Add(_y1TextBox);
            Controls.Add(_x1TextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            _panel.ResumeLayout(false);
            _panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox _x1TextBox;
        private TextBox _y1TextBox;
        
        private Label _label1;
        private Label _label3;
        private Label _label4;
        private Panel _panel;
        private CheckBox _xyPlaneCheckBox;
        private CheckBox _xzPlaneCheckBox;
        private CheckBox _yzPlaneCheckBox;
        private Label label1;
        private Label label2;
        private TextBox _lengthTextBox;
        private TextBox _heightTextBox;
        private Label label3;
        private Label label4;
        private TextBox _z2TextBox;
        private TextBox _y2TextBox;
        private Label label5;
        private Label label6;
        private TextBox _z3TextBox;
        private TextBox _x3TextBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button _resetButton;
        private Button _tranformButton;
        private Label label10;
        private Button _xyzReadButton;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label _xAxisLabel;
        private Label _zAxisLabel;
        private Label _yAxisLabel;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}
