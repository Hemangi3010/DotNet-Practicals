using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender , EventArgs e) {
            ColorDialog c = new ColorDialog();
            c.AllowFullOpen = false;
            c.ShowHelp = true;
            c.Color = textBox1.ForeColor;

            if (c.ShowDialog() == DialogResult.OK) {
                textBox1.BackColor = c.Color;
            }
        
        }
    }
}
