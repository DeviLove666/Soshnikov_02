
namespace Soshnikov
{
    partial class Form12
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
            this.inscompDataSet = new Soshnikov.inscompDataSet();
            this.липецкBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.липецкTableAdapter = new Soshnikov.inscompDataSetTableAdapters.ЛипецкTableAdapter();
            this.tableAdapterManager = new Soshnikov.inscompDataSetTableAdapters.TableAdapterManager();
            this.липецкDataGridView = new System.Windows.Forms.DataGridView();
            this.москваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.москваTableAdapter = new Soshnikov.inscompDataSetTableAdapters.МоскваTableAdapter();
            this.москваDataGridView = new System.Windows.Forms.DataGridView();
            this.рязаньBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рязаньTableAdapter = new Soshnikov.inscompDataSetTableAdapters.РязаньTableAdapter();
            this.рязаньDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inscompDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.липецкBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.липецкDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.москваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.москваDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рязаньBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рязаньDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inscompDataSet
            // 
            this.inscompDataSet.DataSetName = "inscompDataSet";
            this.inscompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // липецкBindingSource
            // 
            this.липецкBindingSource.DataMember = "Липецк";
            this.липецкBindingSource.DataSource = this.inscompDataSet;
            // 
            // липецкTableAdapter
            // 
            this.липецкTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Soshnikov.inscompDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГородTableAdapter = null;
            this.tableAdapterManager.Договор_страхованияTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.Страховой_полисTableAdapter = null;
            this.tableAdapterManager.Транспортное_средствоTableAdapter = null;
            // 
            // липецкDataGridView
            // 
            this.липецкDataGridView.AutoGenerateColumns = false;
            this.липецкDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.липецкDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.липецкDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.липецкDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.липецкDataGridView.DataSource = this.липецкBindingSource;
            this.липецкDataGridView.Location = new System.Drawing.Point(0, 0);
            this.липецкDataGridView.Name = "липецкDataGridView";
            this.липецкDataGridView.RowHeadersVisible = false;
            this.липецкDataGridView.Size = new System.Drawing.Size(788, 116);
            this.липецкDataGridView.TabIndex = 1;
            this.липецкDataGridView.Visible = false;
            // 
            // москваBindingSource
            // 
            this.москваBindingSource.DataMember = "Москва";
            this.москваBindingSource.DataSource = this.inscompDataSet;
            // 
            // москваTableAdapter
            // 
            this.москваTableAdapter.ClearBeforeFill = true;
            // 
            // москваDataGridView
            // 
            this.москваDataGridView.AutoGenerateColumns = false;
            this.москваDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.москваDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.москваDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.москваDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.москваDataGridView.DataSource = this.москваBindingSource;
            this.москваDataGridView.Location = new System.Drawing.Point(0, 0);
            this.москваDataGridView.Name = "москваDataGridView";
            this.москваDataGridView.RowHeadersVisible = false;
            this.москваDataGridView.Size = new System.Drawing.Size(752, 116);
            this.москваDataGridView.TabIndex = 2;
            this.москваDataGridView.Visible = false;
            // 
            // рязаньBindingSource
            // 
            this.рязаньBindingSource.DataMember = "Рязань";
            this.рязаньBindingSource.DataSource = this.inscompDataSet;
            // 
            // рязаньTableAdapter
            // 
            this.рязаньTableAdapter.ClearBeforeFill = true;
            // 
            // рязаньDataGridView
            // 
            this.рязаньDataGridView.AutoGenerateColumns = false;
            this.рязаньDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.рязаньDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.рязаньDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.рязаньDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.рязаньDataGridView.DataSource = this.рязаньBindingSource;
            this.рязаньDataGridView.Location = new System.Drawing.Point(0, 0);
            this.рязаньDataGridView.Name = "рязаньDataGridView";
            this.рязаньDataGridView.RowHeadersVisible = false;
            this.рязаньDataGridView.Size = new System.Drawing.Size(752, 116);
            this.рязаньDataGridView.TabIndex = 3;
            this.рязаньDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn1.HeaderText = "Город";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер города";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Серия";
            this.dataGridViewTextBoxColumn4.HeaderText = "Серия";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Expr1";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn6.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn7.HeaderText = "Город";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn8.HeaderText = "Номер города";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn9.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Серия";
            this.dataGridViewTextBoxColumn10.HeaderText = "Серия";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Expr1";
            this.dataGridViewTextBoxColumn11.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn12.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn13.HeaderText = "Название";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn14.HeaderText = "Номер города";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn15.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 200;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Серия";
            this.dataGridViewTextBoxColumn16.HeaderText = "Серия";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Expr1";
            this.dataGridViewTextBoxColumn17.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn18.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 121);
            this.Controls.Add(this.рязаньDataGridView);
            this.Controls.Add(this.москваDataGridView);
            this.Controls.Add(this.липецкDataGridView);
            this.Name = "Form12";
            this.Text = "Сортировка по городу";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inscompDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.липецкBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.липецкDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.москваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.москваDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рязаньBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рязаньDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private inscompDataSet inscompDataSet;
        private System.Windows.Forms.BindingSource липецкBindingSource;
        private inscompDataSetTableAdapters.ЛипецкTableAdapter липецкTableAdapter;
        private inscompDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView липецкDataGridView;
        private System.Windows.Forms.BindingSource москваBindingSource;
        private inscompDataSetTableAdapters.МоскваTableAdapter москваTableAdapter;
        private System.Windows.Forms.DataGridView москваDataGridView;
        private System.Windows.Forms.BindingSource рязаньBindingSource;
        private inscompDataSetTableAdapters.РязаньTableAdapter рязаньTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView рязаньDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}