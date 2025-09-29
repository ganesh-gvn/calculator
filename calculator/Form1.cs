namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;
        private void button2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtTotal.Text = txtTotal.Text + "";
            if (txtTotal.Text == "0")
                txtTotal.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);

            if (option.Equals("+"))
            {
                result = num1 + num2;
                txtTotal.Text = result.ToString();
            }
            else if (option.Equals("-"))
            {
                result = num1 - num2;
                txtTotal.Text = result.ToString();
            }
            else if (option.Equals("*"))
            {
                result = num1 * num2;
                txtTotal.Text = result.ToString();
            }
            else if (option.Equals("/"))
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    txtTotal.Text = result.ToString();
                }
                else
                {
                    txtTotal.Text = "cannot divide by zero";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            //  txtTotal.Text = txtTotal.Text + "";
            // if (txtTotal.Text == "0")
            // txtTotal.Clear();

        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (!txtTotal.Text.Contains("."))
            {
              if(string.IsNullOrEmpty(txtTotal.Text))
                {
                    txtTotal.Text = "0.";
                }
                else
                {
                    txtTotal.Text = txtTotal.Text + ".";
                }
            }
            else
            {
                txtTotal.Text +="";
            }

        }
    }
}
