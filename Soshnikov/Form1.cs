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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void страховой_полисBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.договор_страхованияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inscompDataSet);

        }

        private void договор_страхованияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.договор_страхованияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inscompDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Транспортное_средство". При необходимости она может быть перемещена или удалена.
            this.транспортное_средствоTableAdapter.Fill(this.inscompDataSet.Транспортное_средство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.inscompDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.inscompDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Страховой_полис". При необходимости она может быть перемещена или удалена.
            this.страховой_полисTableAdapter.Fill(this.inscompDataSet.Страховой_полис);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.Договор_страхования". При необходимости она может быть перемещена или удалена.
            this.договор_страхованияTableAdapter.Fill(this.inscompDataSet.Договор_страхования);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            data.mode = 3;
            data.code = ((inscompDataSet.Договор_страхованияRow)((System.Data.DataRowView)договор_страхованияBindingSource.Current).Row).Код;
            Form6 fr6 = new Form6();
            fr6.ShowDialog();
            this.договор_страхованияTableAdapter.Fill(this.inscompDataSet.Договор_страхования);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            data.mode = 1;
            Form6 fr6 = new Form6();
            fr6.ShowDialog();
            this.договор_страхованияTableAdapter.Fill(this.inscompDataSet.Договор_страхования);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            data.mode = 2;
            data.code = ((inscompDataSet.Договор_страхованияRow)((System.Data.DataRowView)договор_страхованияBindingSource.Current).Row).Код;
            Form6 fr6 = new Form6();
            fr6.ShowDialog();
            this.договор_страхованияTableAdapter.Fill(this.inscompDataSet.Договор_страхования);
        }

        private void договор_страхованияDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { }
            catch { Close();  }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form9 fr9 = new Form9();
            fr9.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form10 fr10 = new Form10();
            fr10.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form8 fr8 = new Form8();
            fr8.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовая работа по дисиплине МДК 05.03 студента группы ИСП-43 Сошникова Артёма", "О программе");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    static class data
    {
        public static int code;
        public static int mode;
        public static int seria;
        public static int gorod;
    }
}
