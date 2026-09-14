using System.Diagnostics;

namespace OOP
{
    public partial class Form1 : Form
    {

        Stopwatch sw = new Stopwatch();
        public Form1()
        {
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

        private void Open_From2(object sender, EventArgs e) 
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
