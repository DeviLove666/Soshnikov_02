
namespace Soshnikov
{
    partial class Form11
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
            this.серия_полисаВВВBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.серия_полисаВВВTableAdapter = new Soshnikov.inscompDataSetTableAdapters.серия_полисаВВВTableAdapter();
            this.tableAdapterManager = new Soshnikov.inscompDataSetTableAdapters.TableAdapterManager();
            this.серия_полисаВВВDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серия_полисаЕЕЕBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.серия_полисаЕЕЕTableAdapter = new Soshnikov.inscompDataSetTableAdapters.серия_полисаЕЕЕTableAdapter();
            this.серия_полисаЕЕЕDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серия_полисаСССBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.серия_полисаСССTableAdapter = new Soshnikov.inscompDataSetTableAdapters.серия_полисаСССTableAdapter();
            this.серия_полисаСССDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inscompDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.серия_полисаВВВBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.серия_полисаВВВDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.серия_полисаЕЕЕBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.серия_полисаЕЕЕDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.серия_полисаСССBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.серия_полисаСССDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inscompDataSet
            // 
            this.inscompDataSet.DataSetName = "inscompDataSet";
            this.inscompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // серия_полисаВВВBindingSource
            // 
            this.серия_полисаВВВBindingSource.DataMember = "серия_полисаВВВ";
            this.серия_полисаВВВBindingSource.DataSource = this.inscompDataSet;
            // 
            // серия_полисаВВВTableAdapter
            // 
            this.серия_полисаВВВTableAdapter.ClearBeforeFill = true;
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
            // серия_полисаВВВDataGridView
            // 
            this.серия_полисаВВВDataGridView.AutoGenerateColumns = false;
            this.серия_полисаВВВDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.серия_полисаВВВDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.серия_полисаВВВDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.серия_полисаВВВDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.серия_полисаВВВDataGridView.DataSource = this.серия_полисаВВВBindingSource;
            this.серия_полисаВВВDataGridView.Location = new System.Drawing.Point(0, 0);
            this.серия_полисаВВВDataGridView.Name = "серия_полисаВВВDataGridView";
            this.серия_полисаВВВDataGridView.RowHeadersVisible = false;
            this.серия_полисаВВВDataGridView.Size = new System.Drawing.Size(586, 157);
            this.серия_полисаВВВDataGridView.TabIndex = 1;
            this.серия_полисаВВВDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Серия";
            this.dataGridViewTextBoxColumn1.HeaderText = "Серия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn3.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn4.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // серия_полисаЕЕЕBindingSource
            // 
            this.серия_полисаЕЕЕBindingSource.DataMember = "серия_полисаЕЕЕ";
            this.серия_полисаЕЕЕBindingSource.DataSource = this.inscompDataSet;
            // 
            // серия_полисаЕЕЕTableAdapter
            // 
            this.серия_полисаЕЕЕTableAdapter.ClearBeforeFill = true;
            // 
            // серия_полисаЕЕЕDataGridView
            // 
            this.серия_полисаЕЕЕDataGridView.AutoGenerateColumns = false;
            this.серия_полисаЕЕЕDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.серия_полисаЕЕЕDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.серия_полисаЕЕЕDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.серия_полисаЕЕЕDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.серия_полисаЕЕЕDataGridView.DataSource = this.серия_полисаЕЕЕBindingSource;
            this.серия_полисаЕЕЕDataGridView.Location = new System.Drawing.Point(0, 0);
            this.серия_полисаЕЕЕDataGridView.Name = "серия_полисаЕЕЕDataGridView";
            this.серия_полисаЕЕЕDataGridView.RowHeadersVisible = false;
            this.серия_полисаЕЕЕDataGridView.Size = new System.Drawing.Size(586, 138);
            this.серия_полисаЕЕЕDataGridView.TabIndex = 2;
            this.серия_полисаЕЕЕDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Серия";
            this.dataGridViewTextBoxColumn5.HeaderText = "Серия";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn6.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn7.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn8.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // серия_полисаСССBindingSource
            // 
            this.серия_полисаСССBindingSource.DataMember = "серия_полисаССС";
            this.серия_полисаСССBindingSource.DataSource = this.inscompDataSet;
            // 
            // серия_полисаСССTableAdapter
            // 
            this.серия_полисаСССTableAdapter.ClearBeforeFill = true;
            // 
            // серия_полисаСССDataGridView
            // 
            this.серия_полисаСССDataGridView.AutoGenerateColumns = false;
            this.серия_полисаСССDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.серия_полисаСССDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.серия_полисаСССDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.серия_полисаСССDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.серия_полисаСССDataGridView.DataSource = this.серия_полисаСССBindingSource;
            this.серия_полисаСССDataGridView.Location = new System.Drawing.Point(0, 0);
            this.серия_полисаСССDataGridView.Name = "серия_полисаСССDataGridView";
            this.серия_полисаСССDataGridView.RowHeadersVisible = false;
            this.серия_полисаСССDataGridView.Size = new System.Drawing.Size(586, 123);
            this.серия_полисаСССDataGridView.TabIndex = 3;
            this.серия_полисаСССDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Серия";
            this.dataGridViewTextBoxColumn9.HeaderText = "Серия";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn10.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn11.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 120;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn12.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 143);
            this.Controls.Add(this.серия_полисаСССDataGridView);
            this.Controls.Add(this.серия_полисаЕЕЕDataGridView);
            this.Controls.Add(this.серия_полисаВВВDataGridView);
            this.Name = "Form11";
            this.Text = "Сортировка по серии страхового полиса";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inscompDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.серия_полисаВВВBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.серия_полисаВВВDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.серия_полисаЕЕЕBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.серия_полисаЕЕЕDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.серия_полисаСССBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.серия_полисаСССDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private inscompDataSet inscompDataSet;
        private System.Windows.Forms.BindingSource серия_полисаВВВBindingSource;
        private inscompDataSetTableAdapters.серия_полисаВВВTableAdapter серия_полисаВВВTableAdapter;
        private inscompDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView серия_полисаВВВDataGridView;
        private System.Windows.Forms.BindingSource серия_полисаЕЕЕBindingSource;
        private inscompDataSetTableAdapters.серия_полисаЕЕЕTableAdapter серия_полисаЕЕЕTableAdapter;
        private System.Windows.Forms.DataGridView серия_полисаЕЕЕDataGridView;
        private System.Windows.Forms.BindingSource серия_полисаСССBindingSource;
        private inscompDataSetTableAdapters.серия_полисаСССTableAdapter серия_полисаСССTableAdapter;
        private System.Windows.Forms.DataGridView серия_полисаСССDataGridView;
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
    }
}