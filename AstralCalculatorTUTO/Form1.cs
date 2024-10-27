using System.Numerics;

namespace Tuto
{
    public partial class Form1 : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public Point mouselocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text += "0"; //adds a 0 to the TxtBox
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text += "1"; //adds 1 to the TxtBox
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text += "2"; //adds 2 to the TxtBox
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text += "3"; //adds 3 to the TxtBox
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text += "4"; //adds 4 to the TxtBox
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text += "5"; //adds 5 to the TxtBox
            }
        }
        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text += "6"; //adds 6 to the TxtBox
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text += "7"; //adds 7 to the TxtBox
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text += "8"; //adds 8 to the TxtBox
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text += "9"; //adds 9 to the TxtBox
            }
        }

        private void MinusPlusBtn_Click(object sender, EventArgs e) //makes the value in the TxtBox negative/positive, it is indeed a "toggle"//
        {
            if (TxtBox.Text.Contains("-"))
            {
                TxtBox.Text = TxtBox.Text.Trim('-');
            }
            else
            {
                TxtBox.Text = "-" + TxtBox.Text;
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e) //Plus
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "+";
        }

        private void DivideBtn_Click(object sender, EventArgs e) //divides
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "/";
        }
        private void MultiplyBtn_Click(object sender, EventArgs e) //multiplies
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "*";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = ""; //clears everything in the text box
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-": //Equal supports minus//
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst - valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

                case "+": //Equal supports plus//
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst + valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

                case "*": //Equal supports Multiply//
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst * valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

                case "/":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst / valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

            }
        }

        private void DotBtn_Click(object sender, EventArgs e) //adds a dot to ur TxtBox (can be used to do small numbers)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += ".";
            }
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(-e.X, -e.Y); //This is to make the UI's drag position/movement
        }

        private void mouse_Move(object sender, MouseEventArgs e) //Drag system of UI
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouselocation.X, mouselocation.Y);
                Location = mousePose;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //makes the ui minimized//
        }
    }
}