namespace WinFormsApp_task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();

            int maxX = this.Width - label1.Width;
            int maxY = this.Height - label1.Height;

            label1.Location = new Point(random.Next(maxX), random.Next(maxY));
        }
    }
}
