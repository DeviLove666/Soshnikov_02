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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.seria = 1;
            Form11 fr11 = new Form11();
            fr11.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data.seria = 2;
            Form11 fr11 = new Form11();
            fr11.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data.seria = 3;
            Form11 fr11 = new Form11();
            fr11.ShowDialog();
        }
    }
}
