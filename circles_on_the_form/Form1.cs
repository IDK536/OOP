namespace circles_on_the_form
{
    public partial class Form1 : Form
    {
        Storage storage = new Storage();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < storage.GetLength(); i++)
            {
                CCircle circle = storage.Get(i);
                if (circle.IsSelected)
                {
                    e.Graphics.DrawEllipse(
                        Pens.Blue,
                        circle.x - CCircle.radius,
                        circle.y - CCircle.radius,
                        CCircle.radius * 2,
                        CCircle.radius * 2
                    );
                }
                else
                {
                    e.Graphics.DrawEllipse(
                        Pens.Black,
                        circle.x - CCircle.radius,
                        circle.y - CCircle.radius,
                        CCircle.radius * 2,
                        CCircle.radius * 2
                    );
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bool isCtrl = false;
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                isCtrl = true;
            }



            bool isSelected = false;
            if (isCtrl)
            {
                for (int i = 0; i < storage.GetLength(); i++)
                {
                    CCircle circle = storage.Get(i);
                    if (circle.In(e.X, e.Y))
                    {
                        circle.IsSelected = true;
                        isSelected = true;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < storage.GetLength(); i++)
                {
                    CCircle circle = storage.Get(i);

                    if (circle.In(e.X, e.Y))
                    {
                        if (!isSelected)
                        {
                            circle.IsSelected = true;
                        }
                        else
                        {
                            circle.IsSelected = false;
                        }
                        isSelected = true;
                    }
                    else
                    {
                        circle.IsSelected = false;
                    }
                }
            }

            if (!isSelected)
            {
                CCircle newCircle = new CCircle(e.X, e.Y);
                storage.Add(newCircle);
            }

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                storage.Remove();
                Invalidate();
            }
        }
    }
}
