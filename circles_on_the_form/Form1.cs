namespace circles_on_the_form
{
    public partial class Form1 : Form
    {
        private const int move = 10;
        private const int scale = 10;

        Storage storage = new Storage(0);
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            storage.Show(e.Graphics);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            bool isCtrl = (Control.ModifierKeys & Keys.Control) == Keys.Control;

            if (!storage.Select(e.X, e.Y, isCtrl))
            {
                Rectangle bounds = panel1.ClientRectangle;
                storage.Draw(e.X, e.Y, bounds);
            }

            panel1.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                storage.SwitchTyep(0);
            }
            else if (e.KeyCode == Keys.D2)
            {
                storage.SwitchTyep(1);
            }
            else if (e.KeyCode == Keys.D3)
            {
                storage.SwitchTyep(2);
            }
            else if (e.KeyCode == Keys.R)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    storage.SetColor(dialog.Color);
                }

                panel1.Invalidate();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                storage.Remove();
                panel1.Invalidate();
            }
            else if (e.KeyCode == Keys.E)
            {
                Rectangle bounds = panel1.ClientRectangle;

                storage.Scale(scale, bounds);
                panel1.Invalidate();
            }
            else if (e.KeyCode == Keys.Q)
            {
                Rectangle bounds = panel1.ClientRectangle;

                storage.Scale(-scale, bounds);
                panel1.Invalidate();
            }
            else if (e.KeyCode == Keys.A)
            {
                Rectangle bounds = panel1.ClientRectangle;

                storage.Move(-move, 0, bounds);
                panel1.Invalidate();
            }
            else if (e.KeyCode == Keys.D)
            {
                Rectangle bounds = panel1.ClientRectangle;

                storage.Move(move, 0, bounds);
                panel1.Invalidate();
            }
            else if (e.KeyCode == Keys.W)
            {
                Rectangle bounds = panel1.ClientRectangle;

                storage.Move(0, -move, bounds);
                panel1.Invalidate();
            }
            else if (e.KeyCode == Keys.S)
            {
                Rectangle bounds = panel1.ClientRectangle;

                storage.Move(0, move, bounds);
                panel1.Invalidate();
            }
            else if (e.KeyCode == Keys.Z)
            {
                storage.Undo();
                panel1.Invalidate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            storage.SwitchTyep(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            storage.SwitchTyep(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            storage.SwitchTyep(2);
        }
    }
}
