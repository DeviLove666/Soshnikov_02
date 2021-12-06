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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                Form1 fr1 = new Form1();
                fr1.ShowDialog();
            }
            else MessageBox.Show("Такого пользователя не существует", "Предупреждение");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
