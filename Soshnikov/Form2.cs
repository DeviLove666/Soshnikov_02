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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void страховой_полисBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.страховой_полисBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inscompDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.inscompDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Страховой_полис". При необходимости она может быть перемещена или удалена.
            this.страховой_полисTableAdapter.Fill(this.inscompDataSet.Страховой_полис);

        }

        private void страховой_полисDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void страховой_полисDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { }
            catch { Close(); }
        }
    }
}
