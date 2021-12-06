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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void транспортное_средствоBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.транспортное_средствоBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inscompDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Страховой_полис". При необходимости она может быть перемещена или удалена.
            this.страховой_полисTableAdapter.Fill(this.inscompDataSet.Страховой_полис);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Город". При необходимости она может быть перемещена или удалена.
            this.городTableAdapter.Fill(this.inscompDataSet.Город);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Транспортное_средство". При необходимости она может быть перемещена или удалена.
            this.транспортное_средствоTableAdapter.Fill(this.inscompDataSet.Транспортное_средство);

        }

        private void транспортное_средствоDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { }
            catch { Close(); }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string NameField;
            NameField = "Марка";
            int Index;
            Index = транспортное_средствоBindingSource.Find(NameField, textBox1.Text);
            if (Index > -1)
                транспортное_средствоBindingSource.Position = Index;
            else MessageBox.Show("Запись не найдена. Измените запрос и повторите попытку.");
        }
    }
}
