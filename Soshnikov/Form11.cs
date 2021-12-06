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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.серия_полисаССС". При необходимости она может быть перемещена или удалена.
            this.серия_полисаСССTableAdapter.Fill(this.inscompDataSet.серия_полисаССС);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.серия_полисаЕЕЕ". При необходимости она может быть перемещена или удалена.
            this.серия_полисаЕЕЕTableAdapter.Fill(this.inscompDataSet.серия_полисаЕЕЕ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inscompDataSet.серия_полисаВВВ". При необходимости она может быть перемещена или удалена.
            this.серия_полисаВВВTableAdapter.Fill(this.inscompDataSet.серия_полисаВВВ);
            if (data.seria == 1) серия_полисаВВВDataGridView.Visible= true;
            if (data.seria == 2) серия_полисаСССDataGridView.Visible = true;
            if (data.seria == 3) серия_полисаЕЕЕDataGridView.Visible = true;
        }
    }
}
