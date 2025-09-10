namespace CalculatorSayson
{
    public partial class Form1 : Form
    {
        //string currentInput = "";
        //double result = 0;
        //string operation = "";
        //bool operationPending = false;

        double x = 0;
        double y = 0;
        double result = 0.0;
        String type;
        bool hasResult = false;


        public Form1()
        {
            InitializeComponent();

        }
        private void equalButton_Click(object sender, EventArgs e)
        {
            try
            {
                y = Convert.ToDouble(tbResult.Text);
                switch (type)
                {
                    case "+":
                        result = x + y;
                        break;
                    case "-":
                        result = x - y;
                        break;
                    case "*":
                        result = x * y;
                        break;
                    case "/":
                        result = x / y;
                        break;
                }
                hasResult = true;
                tbResult.Text = Convert.ToString(result);
                x = result;
                currentOperation.Text = "";
            }
            catch (Exception ex)
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (hasResult == true)
            {
                tbResult.Text = "";
                hasResult = false;
            }
            tbResult.Text = tbResult.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbResult.Text))
            {
                String task = tbResult.Text;
                x = Convert.ToDouble(task);
                this.type = "+";
                tbResult.Text = "";
                currentOperation.Text = type;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = 0.0;
            y = 0.0;
            result = 0.0;
            type = "";
            tbResult.Text = "";
            hasResult = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (hasResult == true)
            {
                tbResult.Text = "";
                hasResult = false;
            }
            tbResult.Text = tbResult.Text + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (hasResult == true)
            {
                tbResult.Text = "";
                hasResult = false;
            }
            tbResult.Text = tbResult.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (hasResult == true)
            {
                tbResult.Text = "";
                hasResult = false;
            }
            tbResult.Text = tbResult.Text + "5";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (hasResult == true)
            {
                tbResult.Text = "";
                hasResult = false;
            }
            tbResult.Text = tbResult.Text + "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (hasResult == true)
            {
                tbResult.Text = "";
                hasResult = false;
            }
            tbResult.Text = tbResult.Text + "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (hasResult == true)
            {
                tbResult.Text = "";
                hasResult = false;
            }
            tbResult.Text = tbResult.Text + "9";
        }



        private void tbResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbResult.Text))
            {
                String task = tbResult.Text;
                x = Convert.ToDouble(task);
                this.type = "-";
                tbResult.Text = "";
                currentOperation.Text = type;
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbResult.Text))
            {
                String task = tbResult.Text;
                x = Convert.ToDouble(task);
                this.type = "*";
                tbResult.Text = "";
                currentOperation.Text = type;
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbResult.Text))
            {
                String task = tbResult.Text;
                x = Convert.ToDouble(task);
                this.type = "/";
                tbResult.Text = "";
                currentOperation.Text = type;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbResult.Text))
            {
                tbResult.Text = tbResult.Text.Substring(0, tbResult.Text.Length - 1);
            }

        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (hasResult == true)
            {
                tbResult.Text = "";
                hasResult = false;
            }
            tbResult.Text = tbResult.Text + "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (hasResult == true)
            {
                tbResult.Text = "";
                hasResult = false;
            }
            tbResult.Text = tbResult.Text + "4";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (hasResult == true)
            {
                tbResult.Text = "";
                hasResult = false;
            }
            tbResult.Text = tbResult.Text + "6";
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            tbResult.Text += ".";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
