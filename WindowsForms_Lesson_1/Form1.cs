namespace WindowsForms_Lesson_1
{
    public partial class Form1 : Form
    {
        int start_X;
        int start_Y;
        int finish_X;
        int finish_Y;
        int length;
        int width;
        int begin_X;
        int begin_Y;
        Label label2 = new Label();

        public Form1()
        {
            label2.Visible = false;
            label2.Size=new Size(this.Width, 18);
            label2.ForeColor = Color.Chocolate;
            this.Controls.Add(label2);
            InitializeComponent();


        }


        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {


            finish_X = e.X;
            finish_Y = e.Y;

            if (start_X < finish_X)
            {
                width = finish_X - start_X;
                begin_X = start_X;
            }

            else
            {
                width = start_X - finish_X;
                begin_X = finish_X;

            }

            if (start_Y < finish_Y)
            {
                length = finish_Y - start_Y;
                begin_Y = start_Y;
            }

            else
            {
                length = start_Y - finish_Y;
                begin_Y = finish_Y;
            }


            Label label = new Label();
            if (width >= 10 && length >= 10)
            {

                Label textLabel = new Label();
                textLabel.Location = new Point(begin_X, begin_Y);
                textLabel.BackColor = Color.Aqua;
                textLabel.Size = new Size(width, length);
                this.Controls.Add(textLabel);
                label2.Visible = false;
                textLabel.MouseClick += label2_MouseClick;
            }

            else
            {
                string message = "Label must have minimum width and height of 10";
                MessageBox.Show(message);

            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            start_X = e.X;
            start_Y = e.Y;

        }


        private void label2_MouseClick(object sender, MouseEventArgs e)
        {

            if (sender is Label label1)
            {
                if (e.Button == MouseButtons.Left)

                {
                    label1.Visible = false;
                    label2.Visible = false;
                }
                else
                {
                    label2.Visible = true;
                    label2.Text = $"Area: {label1.Width * label1.Height} Coordinates: ({begin_X},{begin_Y})";
                }
            }
        }
    }
}
