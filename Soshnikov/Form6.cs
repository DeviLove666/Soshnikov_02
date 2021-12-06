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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void договор_страхованияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.договор_страхованияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inscompDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Страховой_полис". При необходимости она может быть перемещена или удалена.
            this.страховой_полисTableAdapter.Fill(this.inscompDataSet.Страховой_полис);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.inscompDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.inscompDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Транспортное_средство". При необходимости она может быть перемещена или удалена.
            this.транспортное_средствоTableAdapter.Fill(this.inscompDataSet.Транспортное_средство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Договор_страхования". При необходимости она может быть перемещена или удалена.
            this.договор_страхованияTableAdapter.Fill(this.inscompDataSet.Договор_страхования);
            if (data.mode == 1) договор_страхованияBindingSource.AddNew();
            if (data.mode == 2)
            {
                int pos = договор_страхованияBindingSource.Find("Код", data.code);
                договор_страхованияBindingSource.Position = pos;
            }
            if (data.mode == 3)
            {
                int pos = договор_страхованияBindingSource.Find("Код", data.code);
                договор_страхованияBindingSource.Position = pos;
                panel1.Enabled = false;
            }
        }

    }
}
