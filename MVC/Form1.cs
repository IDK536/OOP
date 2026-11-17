using System.Windows.Forms;

namespace MVC
{
    public partial class Form1 : Form
    {
        bool isUpdate = false; 
        Numbers numbers;
        public Form1()
        {
            numbers = new Numbers();
            numbers.Load();

            InitializeComponent();

            numbers.ChangeEvent += Show;
            numbers.Show();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Show(object? sender, EventArgs e)
        {
            if (isUpdate) return;
            isUpdate = true;

            textBox1.Text = numbers.A.ToString();
            textBox2.Text = numbers.B.ToString();
            textBox3.Text = numbers.C.ToString();

            numericUpDown1.Text = numbers.A.ToString();
            numericUpDown2.Text = numbers.B.ToString();
            numericUpDown3.Text = numbers.C.ToString();

            trackBar1.Value = numbers.A;
            trackBar2.Value = numbers.B;
            trackBar3.Value = numbers.C;

            isUpdate = false;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            bool isParse = int.TryParse(textBox1.Text, out int value);
            if (isParse)
                numbers.A = value;
            else
                textBox1.Text = numbers.A.ToString();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            bool isParse = int.TryParse(textBox2.Text, out int value);
            if (isParse)
                numbers.B = value;
            else
                textBox2.Text = numbers.B.ToString();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            bool isParse = int.TryParse(textBox3.Text, out int value);
            if (isParse)
                numbers.C = value;
            else
                textBox3.Text = numbers.C.ToString();

        }
        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            numbers.A = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_Leave(object sender, EventArgs e)
        {
            numbers.B = (int)numericUpDown2.Value;

        }
        private void numericUpDown3_Leave(object sender, EventArgs e)
        {
            numbers.C = (int)numericUpDown3.Value;

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (isUpdate) return;

            numbers.A = trackBar1.Value;
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            if (isUpdate) return;

            numbers.B = trackBar2.Value;
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            if (isUpdate) return;

            numbers.C = trackBar3.Value;
        }


        private void Form1_Closing(object sender, EventArgs e)
        {
            numbers.Save();
        }


    }
}
