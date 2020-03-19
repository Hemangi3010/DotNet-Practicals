using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Sorted = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add("Net Technology");
            listBox2.Items.Add("Java");
            listBox2.Items.Add("Web Technology");
            listBox2.Items.Add("software engineering");
            listBox2.Items.Add("theory of computation");
            listBox2.SelectionMode = SelectionMode.MultiExtended;

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        

        private void button1_Click(object sender , EventArgs e) {
            for(int i=0;i<listBox2.Items.Count;i++) { 
                if (listBox2.SelectedIndex != -1) {
                    listBox1.Items.Add(listBox2.SelectedItem);
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }

        }

    }
}
