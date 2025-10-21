namespace calculator
{
    public partial class Form1 : Form
    {
        float num1;
        float num2;
        string option;
        float result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtTotal.Text += "";
            if (txtTotal.Text == "0")
                txtTotal.Clear();

        }

        private void Num_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtTotal.Text += btn.Text;
        }

        private void Op_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            option = btn.Text;
            num1 = float.Parse(txtTotal.Text);
            txtTotal.Clear();
        }
        private void btnEql_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(txtTotal.Text);

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
