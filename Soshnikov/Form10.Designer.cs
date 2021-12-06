
namespace Soshnikov
{
    partial class Form10
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
            this.транспортное_средство1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.транспортное_средство1TableAdapter = new Soshnikov.inscompDataSetTableAdapters.Транспортное_средство1TableAdapter();
            this.tableAdapterManager = new Soshnikov.inscompDataSetTableAdapters.TableAdapterManager();
            this.транспортное_средство1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inscompDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средство1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средство1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inscompDataSet
            // 
            this.inscompDataSet.DataSetName = "inscompDataSet";
            this.inscompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // транспортное_средство1BindingSource
            // 
            this.транспортное_средство1BindingSource.DataMember = "Транспортное_средство1";
            this.транспортное_средство1BindingSource.DataSource = this.inscompDataSet;
            // 
            // транспортное_средство1TableAdapter
            // 
            this.транспортное_средство1TableAdapter.ClearBeforeFill = true;
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
            // транспортное_средство1DataGridView
            // 
            this.транспортное_средство1DataGridView.AutoGenerateColumns = false;
            this.транспортное_средство1DataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.транспортное_средство1DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.транспортное_средство1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.транспортное_средство1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.транспортное_средство1DataGridView.DataSource = this.транспортное_средство1BindingSource;
            this.транспортное_средство1DataGridView.Location = new System.Drawing.Point(0, 0);
            this.транспортное_средство1DataGridView.Name = "транспортное_средство1DataGridView";
            this.транспортное_средство1DataGridView.RowHeadersVisible = false;
            this.транспортное_средство1DataGridView.Size = new System.Drawing.Size(612, 213);
            this.транспортное_средство1DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn1.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Гос_номер";
            this.dataGridViewTextBoxColumn2.HeaderText = "Гос. номер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ПТС";
            this.dataGridViewTextBoxColumn3.HeaderText = "ПТС";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Собственник";
            this.dataGridViewTextBoxColumn4.HeaderText = "Собственник";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 214);
            this.Controls.Add(this.транспортное_средство1DataGridView);
            this.Name = "Form10";
            this.Text = "Объект и его собственник";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inscompDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средство1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортное_средство1DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private inscompDataSet inscompDataSet;
        private System.Windows.Forms.BindingSource транспортное_средство1BindingSource;
        private inscompDataSetTableAdapters.Транспортное_средство1TableAdapter транспортное_средство1TableAdapter;
        private inscompDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView транспортное_средство1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}