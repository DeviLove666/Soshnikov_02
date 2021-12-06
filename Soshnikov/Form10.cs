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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Транспортное_средство1". При необходимости она может быть перемещена или удалена.
            this.транспортное_средство1TableAdapter.Fill(this.inscompDataSet.Транспортное_средство1);

        }
    }
}
