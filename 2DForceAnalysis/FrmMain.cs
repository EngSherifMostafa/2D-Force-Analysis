using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace _2DForceAnalysis
{
    public partial class FrmMain : Form
    {
        public FrmMain() => InitializeComponent();

        #region variables
        private double
            _rightAngleValue, _leftAngleValue, _weightValue,
            _rightOpposite, _rightAdjacent, _rightHypotenuse,
            _leftOpposite, _leftAdjacent, _leftHypotenuse;
        #endregion
        #region Drawing
        private void FrmMain_Shown(object sender, EventArgs e)
        {
            Draw_Axises();
            Draw_Weight();
            Draw_Forces();
        }
        private void chkDraw_CheckedChanged(object sender, EventArgs e)
        {
            Draw_Axises();
            Draw_Weight();
            Draw_Forces();
        }
        private void Draw_Axises()
        {
            var coordinates = CreateGraphics();

            // draw X Axis
            coordinates.DrawLine(
                new Pen(Color.White, 5),
                new Point(0, Height / 2),
                new Point(Width, Height / 2)
            );

            // draw Y Axis
            coordinates.DrawLine(
                new Pen(Color.White, 5),
                new Point(Width / 2, 0),
                new Point(Width / 2, Height)
            );
        }
        private void Draw_Weight()
        {
            var weight = CreateGraphics();
            var originalPoint = new Point(Width / 2, Height / 2);
            var weightRect = new Rectangle
            {
                Width = Width / 8,
                Height = Height / 8,
                X = originalPoint.X - Width / 8 / 2,
                Y = originalPoint.Y - Height / 8 / 2 + 100
            };

            weight.DrawRectangle(
                new Pen(Color.Aquamarine, 5),
                weightRect
            );

            weight.FillRectangle(Brushes.Aquamarine, weightRect);
        }
        private void Draw_Forces()
        {
            var rightForce = CreateGraphics();
            var leftForce = CreateGraphics();
            var downForce = CreateGraphics();

            var originalPoint = new Point(Width / 2, Height / 2);

            var pForce = new Pen(Color.Green, 5);
            pForce.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            rightForce.DrawLine(
                pForce,
                new Point(originalPoint.X + Width / 3, Height / 2 / 3),
                originalPoint
            );

            leftForce.DrawLine(
                pForce,
                new Point(originalPoint.X - Width / 3, Height / 2 / 3),
                originalPoint
            );

            downForce.DrawLine(
                pForce,
                new Point(originalPoint.X, originalPoint.Y + Height / 3),
                originalPoint
            );
        }
        #endregion
        #region Angle
        private void txtRightAngle_TextChanged(object sender, EventArgs e)
        {
            if (!CheckInput(txtRightAngle.Text, ref _rightAngleValue))
                txtRightAngle.Text = "";
        }
        private void txtLeftAngle_TextChanged(object sender, EventArgs e)
        {
            if (!CheckInput(txtLeftAngle.Text, ref _leftAngleValue))
                txtLeftAngle.Text = "";
        }
        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //level 0: check if digits
                _weightValue = Convert.ToDouble(txtWeight.Text);
            }
            catch (Exception)
            {
                txtWeight.Text = "";
            }
        }
        private bool CheckInput(string strInput, ref double numericValue)
        {
            //remove any unexpected inputs
            try
            {
                //level 0: check if digits
                numericValue = Convert.ToDouble(strInput);

                //level 1: check value [ value <= 360 ]
                if (numericValue > 360)
                {
                    var numOfLoops = (int)(numericValue / 360);
                    for (var i = 0; i < numOfLoops; i++)
                        numericValue -= 360;
                }

                //return true after all check levels end
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }
        #endregion
        #region Triangle
        private void chkRightTri_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRightTri.Checked)
            {   
                txtRightAngle.Enabled = false;
                txtRightAngle.Text = "";

                txtRightAdjacent.Enabled = true;
                txtRightOpposite.Enabled = true;
                txtRightHypotenuse.Enabled = true;
            }
            else
            {
                txtRightAngle.Enabled = true;

                txtRightAdjacent.Enabled = false;
                txtRightOpposite.Enabled = false;
                txtRightHypotenuse.Enabled = false;
                
                txtRightAdjacent.Text = "";
                txtRightOpposite.Text = "";
                txtRightHypotenuse.Text = "";
            }
        }
        private void chkLeftTri_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLeftTri.Checked)
            {
                txtLeftAngle.Enabled = false;
                txtLeftAngle.Text = "";

                txtLeftAdjacent.Enabled = true;
                txtLeftOpposite.Enabled = true;
                txtLeftHypotenuse.Enabled = true;
            }
            else
            {
                txtLeftAngle.Enabled = true;

                txtLeftAdjacent.Enabled = false;
                txtLeftOpposite.Enabled = false;
                txtLeftHypotenuse.Enabled = false;

                txtLeftAdjacent.Text = "";
                txtLeftOpposite.Text = "";
                txtLeftHypotenuse.Text = "";
            }
        }

        //check right textboxes digits
        private void txtRightOpposite_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //level 0: check if digits
                _rightOpposite = Convert.ToDouble(txtRightOpposite.Text);
            }
            catch (Exception)
            {
                txtRightOpposite.Text = "";
            }
        }
        private void txtRightAdjacent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //level 0: check if digits
                _rightAdjacent = Convert.ToDouble(txtRightAdjacent.Text);
            }
            catch (Exception)
            {
                txtRightAdjacent.Text = "";
            }
        }
        private void txtRightHypotenuse_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //level 0: check if digits
                _rightHypotenuse = Convert.ToDouble(txtRightHypotenuse.Text);
            }
            catch (Exception)
            {
                txtRightHypotenuse.Text = "";
            }
        }
        
        //check left textboxes digits
        private void txtLeftOpposite_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //level 0: check if digits
                _leftOpposite = Convert.ToDouble(txtLeftOpposite.Text);
            }
            catch (Exception)
            {
                txtLeftOpposite.Text = "";
            }
        }
        private void txtLeftAdjacent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //level 0: check if digits
                _leftAdjacent = Convert.ToDouble(txtLeftAdjacent.Text);
            }
            catch (Exception)
            {
                txtLeftAdjacent.Text = "";
            }
        }
        private void txtLeftHypotenuse_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //level 0: check if digits
                _leftHypotenuse = Convert.ToDouble(txtLeftHypotenuse.Text);
            }
            catch (Exception)
            {
                txtLeftHypotenuse.Text = "";
            }
        }
        #endregion

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //level 1: check value [ value in Kg = value * 9.8 ]
            if (rbKg.Checked)
                _weightValue *= 9.8;

            if (chkRightTri.Checked)
            {
                _rightAngleValue = Math.Atan(_rightOpposite / _rightAdjacent);
                _rightAngleValue *= 180 / Math.PI;
            }
            if (chkLeftTri.Checked)
            {
                _leftAngleValue = Math.Atan(_leftOpposite / _leftAdjacent);
                _leftAngleValue *= 180 / Math.PI;
            }

            var result = Solver.Elimination(_rightAngleValue, _leftAngleValue, _weightValue);
            txtForce1Val.Text = result[0].ToString(CultureInfo.InvariantCulture);
            txtForce2Val.Text = result[1].ToString(CultureInfo.InvariantCulture);

            _weightValue = Convert.ToDouble(txtWeight.Text);
        }
    }
}