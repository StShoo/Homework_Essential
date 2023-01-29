namespace Homework_E_12_task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(Convert.ToInt32(textBox1.Text) < 60) 
            {
                textBox1.Text = AddSecond(textBox1.Text);
            }
        }

        private void InitializeTimer()
        {
            timer1.Interval= 1000;
            timer1.Start();
            timer1.Enabled= false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private string AddSecond(string time)
        {
            return Convert.ToString(Convert.ToInt32(time) + 1);
        }
    }
}