namespace CalculatorV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double Save = 0;
        public static double Calc = 0;
        public static char ope = ' ';
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Calc = double.Parse(textBox1.Text);
            switch (ope)
            {
                case '+':
                    textBox2.Text += Calc.ToString();
                    textBox2.Text += "=";
                    Save += Calc;
                    textBox1.Text = Save.ToString();
                    break;
                case '-':
                    textBox2.Text += Calc.ToString();
                    textBox2.Text += "=";
                    Save -= Calc;
                    textBox1.Text = Save.ToString();
                    break;
                case '*':
                    textBox2.Text += Calc.ToString();
                    textBox2.Text += "=";
                    Save *= Calc;
                    textBox1.Text = Save.ToString();
                    break;
                case '/':
                    if (Calc == 0)
                    {
                        textBox1.Text = "";
                        MessageBox.Show("Cannot divive by 0", "Division error");
                        textBox2.Text = "";
                        Save = 0;
                        break;
                    }
                    else
                    {
                        textBox2.Text += Calc.ToString();
                        textBox2.Text += "=";
                        Save /= Calc;
                        textBox1.Text = Save.ToString();
                        break;
                    }
                default: break;
            }
            textBox1.Text = Save.ToString();
            Calc = Save;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Save = double.Parse(textBox1.Text);
            textBox1.Text = "";
            ope = '+';
            textBox2.Text += (Save.ToString() + " " + ope + " ");

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Save = double.Parse(textBox1.Text);
            textBox1.Text = "";
            ope = '-';
            textBox2.Text += (Save.ToString() + " " + ope + " ");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Save = double.Parse(textBox1.Text);
            textBox1.Text = "";
            ope = '*';
            textBox2.Text += (Save.ToString() + " " + ope + " ");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Save = double.Parse(textBox1.Text);
            textBox1.Text = "";
            ope = '/';
            textBox2.Text += (Save.ToString() + " " + ope + " ");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Calc = double.Parse(textBox1.Text);
            Calc = -Calc;
            textBox2.Text = Calc.ToString();
            textBox1.Text = Calc.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Calc = double.Parse(textBox1.Text);
            Calc *= Calc;
            textBox2.Text = Calc.ToString();
            textBox1.Text = Calc.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Calc = double.Parse(textBox1.Text);
            Calc = 1 / Calc;
            textBox2.Text = Calc.ToString();
            textBox1.Text = Calc.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Calc = double.Parse(textBox1.Text);
            Calc /= 100;
            textBox2.Text = Calc.ToString();
            textBox1.Text = Calc.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            String del = textBox1.Text;
            del = del.Remove(del.Length - 1);
            textBox1.Text = del;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (!textBox1.Text.Contains('.'))
            {
                textBox1.Text += '.';
            }
            Calc = double.Parse(textBox1.Text);
            textBox2.Text = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}