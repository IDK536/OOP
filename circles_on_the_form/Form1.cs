namespace circles_on_the_form
{
    public partial class Form1 : Form
    {
        private const int move = 10;
        private const int scale = 10;

        Storage storage = new Storage(1);
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
                storage.Draw(e.X, e.Y);
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
            else if (e.KeyCode == Keys.Q)
            {
                storage.Scale(scale);
                panel1.Invalidate();
            }
            else if (e.KeyCode == Keys.A)
            {
                storage.Move(-move, 0);
                panel1.Invalidate();
            }
            else if (e.KeyCode == Keys.D)
            {
                storage.Move(move, 0);
                panel1.Invalidate();
            }
            else if (e.KeyCode == Keys.W)
            {
                storage.Move(0, -move);
                panel1.Invalidate();
            }
            else if (e.KeyCode == Keys.S)
            {
                storage.Move(0, move);
                panel1.Invalidate();
            }
            else if (e.KeyCode == Keys.Z)
            {
                storage.Undo();
                panel1.Invalidate();
            }


        }
    }
}
