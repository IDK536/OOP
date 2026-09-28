using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{


    public partial class Form2 : Form
    {
        private bool Is_chack;
        public Form2()
        {
            Is_chack = false;
            List<Collor> BackColors = new List<Collor>
            {
                new Collor {color=Color.Green, Name="green" }, new Collor {color=Color.Red, Name="red" }, new Collor {color=Color.Blue, Name="blue" },
            };

            InitializeComponent();
            comboBox1.DataSource = BackColors;
            comboBox1.DisplayMember = "Name";
        }

        private void box_ChackedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            label1.Text = checkbox.Checked.ToString();
        }

        private void mouse_move_control(object sender, MouseEventArgs e)
        {
            move_control_label.Text = e.X.ToString() + ", " + e.Y.ToString();
        }

        private void combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            Collor color = (Collor)box.SelectedItem;
            panel1.BackColor = color.color;
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                panel1.MouseMove += mouse_move_control;
            }
            else
            {
                panel1.MouseMove -= mouse_move_control;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 1)
            {
                radioButton1.Checked = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (trackBar1.Value == trackBar1.Maximum)
            {
                trackBar1.Value = trackBar1.Minimum;
                return;
            }
            trackBar1.Value += 1;
        }

    }

    public class Collor
    {

        public Color color { get; set; }
        public string Name { get; set; }

    }
}
