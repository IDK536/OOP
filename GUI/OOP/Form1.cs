using System.Diagnostics;

namespace OOP
{
    public partial class Form1 : Form
    {

        Stopwatch sw = new Stopwatch();
        Point button_Possition;
        public Form1()
        {
            button_Possition = new Point(100, 100);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sw.Start();
            this.ControlBox = false;
        }

        private void Work_Time_Click(object sender, EventArgs e)
        {
            textBox1.Text = sw.Elapsed.ToString(@"mm\:ss\.ff");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Open_Form2(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
        private void Create_Button_Click(object sender, EventArgs e)
        {
            Button newButton = new Button();
            newButton.Text = "Ckick to dekete this button";
            newButton.Location = button_Possition;
            newButton.BackColor = Color.White;

            newButton.Click += Delete_Button_Click;

            this.Controls.Add(newButton);

            button_Possition.Y += 10;
        }

        private void Delete_Button_Click(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.Controls.Remove(button);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Red, 40, 40 ,40 ,40);
        }
    }
}
