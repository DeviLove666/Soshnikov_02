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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Рязань". При необходимости она может быть перемещена или удалена.
            this.рязаньTableAdapter.Fill(this.inscompDataSet.Рязань);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Москва". При необходимости она может быть перемещена или удалена.
            this.москваTableAdapter.Fill(this.inscompDataSet.Москва);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Липецк". При необходимости она может быть перемещена или удалена.
            this.липецкTableAdapter.Fill(this.inscompDataSet.Липецк);
            if (data.gorod == 1) рязаньDataGridView.Visible = true;
            if (data.gorod == 2) липецкDataGridView.Visible = true;
            if (data.gorod == 3) москваDataGridView.Visible = true;
        }
    }
}
