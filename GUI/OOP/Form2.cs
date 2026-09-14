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
        
        public Form2()
        {
            
            InitializeComponent();
        }

        private void box_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            label1.Text = checkbox.Checked.ToString();
        }

        private void mose_move_control(object sender, MouseEventArgs e)
        { 
            move_control_label.Text = e.X.ToString() + ", " + e.Y.ToString();
        }
    }
}
