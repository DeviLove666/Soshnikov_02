
namespace Soshnikov
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.inscompDataSet = new Soshnikov.inscompDataSet();
            this.транспортное_средствоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.транспортное_средствоTableAdapter = new Soshnikov.inscompDataSetTableAdapters.Транспортное_средствоTableAdapter();
            this.tableAdapterManager = new Soshnikov.inscompDataSetTableAdapters.TableAdapterManager();
            this.городTableAdapter = new Soshnikov.inscompDataSetTableAdapters.ГородTableAdapter();
            this.страховой_полисTableAdapter = new Soshnikov.inscompDataSetTableAdapters.Страховой_полисTableAdapter();
            this.транспортное_средствоBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.транспортное_средствоBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.транспортное_средствоDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.городBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.страховойполисBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.городBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.городDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inscompDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоBindingNavigator)).BeginInit();
            this.транспортное_средствоBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.городBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховойполисBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.городBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.городDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // inscompDataSet
            // 
            this.inscompDataSet.DataSetName = "inscompDataSet";
            this.inscompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Soshnikov.inscompDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГородTableAdapter = this.городTableAdapter;
            this.tableAdapterManager.Договор_страхованияTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.Страховой_полисTableAdapter = this.страховой_полисTableAdapter;
            this.tableAdapterManager.Транспортное_средствоTableAdapter = this.транспортное_средствоTableAdapter;
            // 
            // городTableAdapter
            // 
            this.городTableAdapter.ClearBeforeFill = true;
            // 
            // страховой_полисTableAdapter
            // 
            this.страховой_полисTableAdapter.ClearBeforeFill = true;
            // 
            // транспортное_средствоBindingNavigator
            // 
            this.транспортное_средствоBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.транспортное_средствоBindingNavigator.BindingSource = this.транспортное_средствоBindingSource;
            this.транспортное_средствоBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.транспортное_средствоBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.транспортное_средствоBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.транспортное_средствоBindingNavigatorSaveItem});
            this.транспортное_средствоBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.транспортное_средствоBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.транспортное_средствоBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.транспортное_средствоBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.транспортное_средствоBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.транспортное_средствоBindingNavigator.Name = "транспортное_средствоBindingNavigator";
            this.транспортное_средствоBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.транспортное_средствоBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.транспортное_средствоBindingNavigator.TabIndex = 0;
            this.транспортное_средствоBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // транспортное_средствоBindingNavigatorSaveItem
            // 
            this.транспортное_средствоBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.транспортное_средствоBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("транспортное_средствоBindingNavigatorSaveItem.Image")));
            this.транспортное_средствоBindingNavigatorSaveItem.Name = "транспортное_средствоBindingNavigatorSaveItem";
            this.транспортное_средствоBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.транспортное_средствоBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.транспортное_средствоBindingNavigatorSaveItem.Click += new System.EventHandler(this.транспортное_средствоBindingNavigatorSaveItem_Click);
            // 
            // транспортное_средствоDataGridView
            // 
            this.транспортное_средствоDataGridView.AutoGenerateColumns = false;
            this.транспортное_средствоDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.транспортное_средствоDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.транспортное_средствоDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.транспортное_средствоDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.транспортное_средствоDataGridView.DataSource = this.транспортное_средствоBindingSource;
            this.транспортное_средствоDataGridView.Location = new System.Drawing.Point(0, 28);
            this.транспортное_средствоDataGridView.Name = "транспортное_средствоDataGridView";
            this.транспортное_средствоDataGridView.RowHeadersVisible = false;
            this.транспортное_средствоDataGridView.Size = new System.Drawing.Size(800, 220);
            this.транспортное_средствоDataGridView.TabIndex = 1;
            this.транспортное_средствоDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.транспортное_средствоDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn2.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Гос_номер";
            this.dataGridViewTextBoxColumn3.HeaderText = "Гос. номер";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ПТС";
            this.dataGridViewTextBoxColumn4.HeaderText = "ПТС";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Собственник";
            this.dataGridViewTextBoxColumn5.HeaderText = "Собственник";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 170;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Город";
            this.dataGridViewTextBoxColumn6.DataSource = this.городBindingSource1;
            this.dataGridViewTextBoxColumn6.DisplayMember = "Название";
            this.dataGridViewTextBoxColumn6.HeaderText = "Город";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "Код";
            // 
            // городBindingSource1
            // 
            this.городBindingSource1.DataMember = "Город";
            this.городBindingSource1.DataSource = this.inscompDataSet;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Страховой_полис";
            this.dataGridViewTextBoxColumn7.DataSource = this.страховойполисBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Серия";
            this.dataGridViewTextBoxColumn7.HeaderText = "Страховой полис";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "Код";
            // 
            // страховойполисBindingSource
            // 
            this.страховойполисBindingSource.DataMember = "Страховой_полис";
            this.страховойполисBindingSource.DataSource = this.inscompDataSet;
            // 
            // городBindingSource
            // 
            this.городBindingSource.DataMember = "Город";
            this.городBindingSource.DataSource = this.inscompDataSet;
            // 
            // городDataGridView
            // 
            this.городDataGridView.AutoGenerateColumns = false;
            this.городDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.городDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.городDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.городDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.городDataGridView.DataSource = this.городBindingSource;
            this.городDataGridView.Location = new System.Drawing.Point(0, 254);
            this.городDataGridView.Name = "городDataGridView";
            this.городDataGridView.RowHeadersVisible = false;
            this.городDataGridView.Size = new System.Drawing.Size(381, 136);
            this.городDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn8.HeaderText = "Код";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn9.HeaderText = "Название города";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 160;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn10.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(486, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 130);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск транспортного средства по марке";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(56, 65);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(150, 28);
            this.button14.TabIndex = 4;
            this.button14.Text = "Найти";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.городDataGridView);
            this.Controls.Add(this.транспортное_средствоDataGridView);
            this.Controls.Add(this.транспортное_средствоBindingNavigator);
            this.Name = "Form3";
            this.Text = "Транспортное средство";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inscompDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоBindingNavigator)).EndInit();
            this.транспортное_средствоBindingNavigator.ResumeLayout(false);
            this.транспортное_средствоBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средствоDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.городBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховойполисBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.городBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.городDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private inscompDataSet inscompDataSet;
        private System.Windows.Forms.BindingSource транспортное_средствоBindingSource;
        private inscompDataSetTableAdapters.Транспортное_средствоTableAdapter транспортное_средствоTableAdapter;
        private inscompDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator транспортное_средствоBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton транспортное_средствоBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView транспортное_средствоDataGridView;
        private inscompDataSetTableAdapters.ГородTableAdapter городTableAdapter;
        private System.Windows.Forms.BindingSource городBindingSource;
        private System.Windows.Forms.DataGridView городDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private inscompDataSetTableAdapters.Страховой_полисTableAdapter страховой_полисTableAdapter;
        private System.Windows.Forms.BindingSource городBindingSource1;
        private System.Windows.Forms.BindingSource страховойполисBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox1;
    }
}