namespace WinFormsApp_task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Timer Timer1 = new();
            Timer1.Start();
            Timer1.Interval = 1000;
            Timer1.Tick += TimeInterval;

        }


     

        public void TimeInterval(object sender, EventArgs e)
        {
            if (button1.Text == "Baku")
            {
                DateTime dt = DateTime.Now;
                label1.Text = dt.ToString();
            }
            else
            {
                DateTime dt = DateTime.Now.AddHours(-3);
                label1.Text = dt.ToString();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Baku")
            {
                button1.Text = "London";
                TimeInterval(this, EventArgs.Empty);
                label1.Text=DateTime.Now.AddHours(-3).ToString();   
                pictureBox1.ImageLocation = "london1.jpg";
            }

            else
            {
                button1.Text = "Baku";
                TimeInterval(sender, EventArgs.Empty);
                label1.Text = DateTime.Now.ToString();
                pictureBox1.ImageLocation = "baku.jpg";
            }
        }
    }
}
