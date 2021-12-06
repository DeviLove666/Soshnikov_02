using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soshnikov
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data.gorod = 2;
            Form12 fr12 = new Form12();
            fr12.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.gorod = 1;
            Form12 fr12 = new Form12();
            fr12.ShowDialog();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            data.gorod = 3;
            Form12 fr12 = new Form12();
            fr12.ShowDialog();
        }
    }
}
