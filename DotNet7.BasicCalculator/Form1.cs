using System.Data;

namespace DotNet7.BasicCalculator
{
    public partial class BasicCalculator : Form
    {
        public BasicCalculator()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";

        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";

        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";

        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";

        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";

        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtResult.Text += ".";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtResult.Text += "+";

        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            txtResult.Text += "-";

        }
        private void btnMuliple_Click(object sender, EventArgs e)
        {
            txtResult.Text += "*";

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            txtResult.Text += "/";

        }

        private void btnRemainderDivision_Click(object sender, EventArgs e)
        {
            txtResult.Text += "%";

        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            try
            {
                var result = Math.Pow(double.Parse(txtResult.Text), 2);
                txtResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Expression");
            }
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            try
            {
                var result = Math.Pow(double.Parse(txtResult.Text), 3);
                txtResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Expression");
            }
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            try
            {
                var result = Math.Sqrt(double.Parse(txtResult.Text));
                txtResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Expression");
            }
        }

        private void btnCubeRoot_Click(object sender, EventArgs e)
        {
            try
            {
                var result = Math.Cbrt(double.Parse(txtResult.Text));
                txtResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Expression");
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(txtResult.Text, null);
                txtResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Expression");
            }
        }

        private void btnRemoveLastInput_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                var currentInput = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
                txtResult.Text = currentInput;
            }
            else
            {
                MessageBox.Show("Invalid Expression");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

    }
}
