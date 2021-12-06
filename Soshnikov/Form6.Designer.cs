
namespace Soshnikov
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label кодLabel;
            System.Windows.Forms.Label объектLabel;
            System.Windows.Forms.Label клиентLabel;
            System.Windows.Forms.Label сотрудникLabel;
            System.Windows.Forms.Label сраховая_суммаLabel;
            System.Windows.Forms.Label страховая_премияLabel;
            System.Windows.Forms.Label страховой_полисLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.inscompDataSet = new Soshnikov.inscompDataSet();
            this.договор_страхованияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договор_страхованияTableAdapter = new Soshnikov.inscompDataSetTableAdapters.Договор_страхованияTableAdapter();
            this.tableAdapterManager = new Soshnikov.inscompDataSetTableAdapters.TableAdapterManager();
            this.кодTextBox = new System.Windows.Forms.TextBox();
            this.объектComboBox = new System.Windows.Forms.ComboBox();
            this.клиентComboBox = new System.Windows.Forms.ComboBox();
            this.сотрудникComboBox = new System.Windows.Forms.ComboBox();
            this.сраховая_суммаTextBox = new System.Windows.Forms.TextBox();
            this.страховая_премияTextBox = new System.Windows.Forms.TextBox();
            this.страховой_полисComboBox = new System.Windows.Forms.ComboBox();
            this.транспортное_средствоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.транспортное_средствоTableAdapter = new Soshnikov.inscompDataSetTableAdapters.Транспортное_средствоTableAdapter();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new Soshnikov.inscompDataSetTableAdapters.КлиентTableAdapter();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter = new Soshnikov.inscompDataSetTableAdapters.СотрудникTableAdapter();
            this.страховой_полисBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.страховой_полисTableAdapter = new Soshnikov.inscompDataSetTableAdapters.Страховой_полисTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            кодLabel = new System.Windows.Forms.Label();
            объектLabel = new System.Windows.Forms.Label();
            клиентLabel = new System.Windows.Forms.Label();
            сотрудникLabel = new System.Windows.Forms.Label();
            сраховая_суммаLabel = new System.Windows.Forms.Label();
            страховая_премияLabel = new System.Windows.Forms.Label();
            страховой_полисLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inscompDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договор_страхованияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховой_полисBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(страховой_полисLabel);
            this.panel1.Controls.Add(this.страховой_полисComboBox);
            this.panel1.Controls.Add(страховая_премияLabel);
            this.panel1.Controls.Add(this.страховая_премияTextBox);
            this.panel1.Controls.Add(сраховая_суммаLabel);
            this.panel1.Controls.Add(this.сраховая_суммаTextBox);
            this.panel1.Controls.Add(сотрудникLabel);
            this.panel1.Controls.Add(this.сотрудникComboBox);
            this.panel1.Controls.Add(клиентLabel);
            this.panel1.Controls.Add(this.клиентComboBox);
            this.panel1.Controls.Add(объектLabel);
            this.panel1.Controls.Add(this.объектComboBox);
            this.panel1.Controls.Add(кодLabel);
            this.panel1.Controls.Add(this.кодTextBox);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 269);
            this.panel1.TabIndex = 0;
            // 
            // inscompDataSet
            // 
            this.inscompDataSet.DataSetName = "inscompDataSet";
            this.inscompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // договор_страхованияBindingSource
            // 
            this.договор_страхованияBindingSource.DataMember = "Договор_страхования";
            this.договор_страхованияBindingSource.DataSource = this.inscompDataSet;
            // 
            // договор_страхованияTableAdapter
            // 
            this.договор_страхованияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Soshnikov.inscompDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГородTableAdapter = null;
            this.tableAdapterManager.Договор_страхованияTableAdapter = this.договор_страхованияTableAdapter;
            this.tableAdapterManager.КлиентTableAdapter = this.клиентTableAdapter;
            this.tableAdapterManager.СотрудникTableAdapter = this.сотрудникTableAdapter;
            this.tableAdapterManager.Страховой_полисTableAdapter = this.страховой_полисTableAdapter;
            this.tableAdapterManager.Транспортное_средствоTableAdapter = this.транспортное_средствоTableAdapter;
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Location = new System.Drawing.Point(13, 20);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(29, 13);
            кодLabel.TabIndex = 0;
            кодLabel.Text = "Код:";
            // 
            // кодTextBox
            // 
            this.кодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договор_страхованияBindingSource, "Код", true));
            this.кодTextBox.Location = new System.Drawing.Point(121, 17);
            this.кодTextBox.Name = "кодTextBox";
            this.кодTextBox.Size = new System.Drawing.Size(196, 20);
            this.кодTextBox.TabIndex = 1;
            // 
            // объектLabel
            // 
            объектLabel.AutoSize = true;
            объектLabel.Location = new System.Drawing.Point(13, 47);
            объектLabel.Name = "объектLabel";
            объектLabel.Size = new System.Drawing.Size(48, 13);
            объектLabel.TabIndex = 2;
            объектLabel.Text = "Объект:";
            // 
            // объектComboBox
            // 
            this.объектComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.договор_страхованияBindingSource, "Объект", true));
            this.объектComboBox.DataSource = this.транспортное_средствоBindingSource;
            this.объектComboBox.DisplayMember = "Марка";
            this.объектComboBox.FormattingEnabled = true;
            this.объектComboBox.Location = new System.Drawing.Point(121, 44);
            this.объектComboBox.Name = "объектComboBox";
            this.объектComboBox.Size = new System.Drawing.Size(196, 21);
            this.объектComboBox.TabIndex = 3;
            this.объектComboBox.ValueMember = "Код";
            // 
            // клиентLabel
            // 
            клиентLabel.AutoSize = true;
            клиентLabel.Location = new System.Drawing.Point(13, 75);
            клиентLabel.Name = "клиентLabel";
            клиентLabel.Size = new System.Drawing.Size(46, 13);
            клиентLabel.TabIndex = 4;
            клиентLabel.Text = "Клиент:";
            // 
            // клиентComboBox
            // 
            this.клиентComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.договор_страхованияBindingSource, "Клиент", true));
            this.клиентComboBox.DataSource = this.клиентBindingSource;
            this.клиентComboBox.DisplayMember = "ФИО";
            this.клиентComboBox.FormattingEnabled = true;
            this.клиентComboBox.Location = new System.Drawing.Point(121, 72);
            this.клиентComboBox.Name = "клиентComboBox";
            this.клиентComboBox.Size = new System.Drawing.Size(196, 21);
            this.клиентComboBox.TabIndex = 5;
            this.клиентComboBox.ValueMember = "Код";
            // 
            // сотрудникLabel
            // 
            сотрудникLabel.AutoSize = true;
            сотрудникLabel.Location = new System.Drawing.Point(13, 103);
            сотрудникLabel.Name = "сотрудникLabel";
            сотрудникLabel.Size = new System.Drawing.Size(63, 13);
            сотрудникLabel.TabIndex = 6;
            сотрудникLabel.Text = "Сотрудник:";
            // 
            // сотрудникComboBox
            // 
            this.сотрудникComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.договор_страхованияBindingSource, "Сотрудник", true));
            this.сотрудникComboBox.DataSource = this.сотрудникBindingSource;
            this.сотрудникComboBox.DisplayMember = "ФИО";
            this.сотрудникComboBox.FormattingEnabled = true;
            this.сотрудникComboBox.Location = new System.Drawing.Point(121, 100);
            this.сотрудникComboBox.Name = "сотрудникComboBox";
            this.сотрудникComboBox.Size = new System.Drawing.Size(196, 21);
            this.сотрудникComboBox.TabIndex = 7;
            this.сотрудникComboBox.ValueMember = "Код";
            // 
            // сраховая_суммаLabel
            // 
            сраховая_суммаLabel.AutoSize = true;
            сраховая_суммаLabel.Location = new System.Drawing.Point(13, 131);
            сраховая_суммаLabel.Name = "сраховая_суммаLabel";
            сраховая_суммаLabel.Size = new System.Drawing.Size(94, 13);
            сраховая_суммаLabel.TabIndex = 8;
            сраховая_суммаLabel.Text = "Сраховая сумма:";
            // 
            // сраховая_суммаTextBox
            // 
            this.сраховая_суммаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договор_страхованияBindingSource, "Сраховая_сумма", true));
            this.сраховая_суммаTextBox.Location = new System.Drawing.Point(121, 128);
            this.сраховая_суммаTextBox.Name = "сраховая_суммаTextBox";
            this.сраховая_суммаTextBox.Size = new System.Drawing.Size(196, 20);
            this.сраховая_суммаTextBox.TabIndex = 9;
            // 
            // страховая_премияLabel
            // 
            страховая_премияLabel.AutoSize = true;
            страховая_премияLabel.Location = new System.Drawing.Point(13, 158);
            страховая_премияLabel.Name = "страховая_премияLabel";
            страховая_премияLabel.Size = new System.Drawing.Size(104, 13);
            страховая_премияLabel.TabIndex = 10;
            страховая_премияLabel.Text = "Страховая премия:";
            // 
            // страховая_премияTextBox
            // 
            this.страховая_премияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договор_страхованияBindingSource, "Страховая_премия", true));
            this.страховая_премияTextBox.Location = new System.Drawing.Point(121, 155);
            this.страховая_премияTextBox.Name = "страховая_премияTextBox";
            this.страховая_премияTextBox.Size = new System.Drawing.Size(196, 20);
            this.страховая_премияTextBox.TabIndex = 11;
            // 
            // страховой_полисLabel
            // 
            страховой_полисLabel.AutoSize = true;
            страховой_полисLabel.Location = new System.Drawing.Point(13, 185);
            страховой_полисLabel.Name = "страховой_полисLabel";
            страховой_полисLabel.Size = new System.Drawing.Size(96, 13);
            страховой_полисLabel.TabIndex = 12;
            страховой_полисLabel.Text = "Страховой полис:";
            // 
            // страховой_полисComboBox
            // 
            this.страховой_полисComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.договор_страхованияBindingSource, "Страховой_полис", true));
            this.страховой_полисComboBox.DataSource = this.страховой_полисBindingSource;
            this.страховой_полисComboBox.DisplayMember = "Серия";
            this.страховой_полисComboBox.FormattingEnabled = true;
            this.страховой_полисComboBox.Location = new System.Drawing.Point(121, 182);
            this.страховой_полисComboBox.Name = "страховой_полисComboBox";
            this.страховой_полисComboBox.Size = new System.Drawing.Size(196, 21);
            this.страховой_полисComboBox.TabIndex = 13;
            this.страховой_полисComboBox.ValueMember = "Код";
            // 
            // транспортное_средствоBindingSource
            // 
            this.транспортное_средствоBindingSource.DataMember = "Транспортное_средство";
            this.транспортное_средствоBindingSource.DataSource = this.inscompDataSet;
            // 
            // транспортное_средствоTableAdapter
            // 
            this.транспортное_средствоTableAdapter.ClearBeforeFill = true;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.inscompDataSet;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.inscompDataSet;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // страховой_полисBindingSource
            // 
            this.страховой_полисBindingSource.DataMember = "Страховой_полис";
            this.страховой_полисBindingSource.DataSource = this.inscompDataSet;
            // 
            // страховой_полисTableAdapter
            // 
            this.страховой_полисTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 290);
            this.Controls.Add(this.panel1);
            this.Name = "Form6";
            this.Text = "Запись";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inscompDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договор_страхованияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховой_полисBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private inscompDataSet inscompDataSet;
        private System.Windows.Forms.BindingSource договор_страхованияBindingSource;
        private inscompDataSetTableAdapters.Договор_страхованияTableAdapter договор_страхованияTableAdapter;
        private inscompDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox кодTextBox;
        private System.Windows.Forms.ComboBox страховой_полисComboBox;
        private System.Windows.Forms.TextBox страховая_премияTextBox;
        private System.Windows.Forms.TextBox сраховая_суммаTextBox;
        private System.Windows.Forms.ComboBox сотрудникComboBox;
        private System.Windows.Forms.ComboBox клиентComboBox;
        private System.Windows.Forms.ComboBox объектComboBox;
        private inscompDataSetTableAdapters.Транспортное_средствоTableAdapter транспортное_средствоTableAdapter;
        private System.Windows.Forms.BindingSource транспортное_средствоBindingSource;
        private inscompDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private inscompDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private inscompDataSetTableAdapters.Страховой_полисTableAdapter страховой_полисTableAdapter;
        private System.Windows.Forms.BindingSource страховой_полисBindingSource;
        private System.Windows.Forms.Button button1;
    }
}