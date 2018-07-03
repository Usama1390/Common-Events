using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PassBackEvent(this, null);
            if (sender.Equals(fileToolStripMenuItem))
            {
                MessageBox.Show("File");
            }
            if (sender.Equals(editToolStripMenuItem))
            {
                MessageBox.Show("Edit");
            }

            if (sender.Equals(viewToolStripMenuItem))
            {
                MessageBox.Show("view");
            }

            if (sender.Equals(projectToolStripMenuItem))
            {
                MessageBox.Show("project");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sender.Equals(button3))
            {
                Form2 obj = new Form2();
                obj.Show();
            }

            if (sender.Equals(button4))
            {
                Form3 obj = new Form3();
                obj.Show();
            }
        }
    }
}
