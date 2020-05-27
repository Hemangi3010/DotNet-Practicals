using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
             textBox1.Enabled=true;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            //int x = 297, y = 22;
            textBox1.Size = new System.Drawing.Size(--297, --22 );
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //int x = 297, y = 22;
            textBox1.Size = new System.Drawing.Size(x = x + 5, y = y + 5);
        }
    }
}
