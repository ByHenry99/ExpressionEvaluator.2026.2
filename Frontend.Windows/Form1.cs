using Backend;

namespace Frontend.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ".";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "/";
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "^";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "*";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "-";
        }

        private void btnOpenParenthesis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "(";
        }

        private void btnCloseParentehsis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ")";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.TextLength-1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += $"={ExpressionEvaluator.Evaluate(txtDisplay.Text)}";
        }
    }
}
