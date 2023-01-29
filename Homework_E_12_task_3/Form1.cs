namespace Homework_E_12_task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(new Presenter(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).Sum());
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(new Presenter(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).Min());
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(new Presenter(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).Mult());
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0") 
            {
                textBox2.Text = "Error";
            } else
            {
                textBox2.Text = Convert.ToString(new Presenter(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).Div());
            }
        }
    }
}