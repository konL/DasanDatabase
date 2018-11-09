namespace LoginEx
{
    partial class FrmSp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSp));
            this.zgzyDataSet = new LoginEx.zgzyDataSet();
            this.t_spBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_spTableAdapter = new LoginEx.zgzyDataSetTableAdapters.t_spTableAdapter();
            this.tableAdapterManager = new LoginEx.zgzyDataSetTableAdapters.TableAdapterManager();
            this.t_spBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.t_spBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.t_spDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zgzyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_spBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_spBindingNavigator)).BeginInit();
            this.t_spBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_spDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // zgzyDataSet
            // 
            this.zgzyDataSet.DataSetName = "zgzyDataSet";
            this.zgzyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_spBindingSource
            // 
            this.t_spBindingSource.DataMember = "t_sp";
            this.t_spBindingSource.DataSource = this.zgzyDataSet;
            // 
            // t_spTableAdapter
            // 
            this.t_spTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.t_bmTableAdapter = null;
            this.tableAdapterManager.t_csTableAdapter = null;
            this.tableAdapterManager.t_jhdTableAdapter = null;
            this.tableAdapterManager.t_jhmxTableAdapter = null;
            this.tableAdapterManager.t_kcTableAdapter = null;
            this.tableAdapterManager.t_khgysTableAdapter = null;
            this.tableAdapterManager.t_spTableAdapter = this.t_spTableAdapter;
            this.tableAdapterManager.t_xsdTableAdapter = null;
            this.tableAdapterManager.t_xsmxTableAdapter = null;
            this.tableAdapterManager.t_zg1TableAdapter = null;
            this.tableAdapterManager.t_zgTableAdapter = null;
            this.tableAdapterManager.t_zyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoginEx.zgzyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_spBindingNavigator
            // 
            this.t_spBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_spBindingNavigator.BindingSource = this.t_spBindingSource;
            this.t_spBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_spBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_spBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_spBindingNavigatorSaveItem});
            this.t_spBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_spBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_spBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_spBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_spBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_spBindingNavigator.Name = "t_spBindingNavigator";
            this.t_spBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_spBindingNavigator.Size = new System.Drawing.Size(868, 25);
            this.t_spBindingNavigator.TabIndex = 0;
            this.t_spBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
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
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // t_spBindingNavigatorSaveItem
            // 
            this.t_spBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_spBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_spBindingNavigatorSaveItem.Image")));
            this.t_spBindingNavigatorSaveItem.Name = "t_spBindingNavigatorSaveItem";
            this.t_spBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.t_spBindingNavigatorSaveItem.Text = "保存数据";
            this.t_spBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_spBindingNavigatorSaveItem_Click);
            // 
            // t_spDataGridView
            // 
            this.t_spDataGridView.AutoGenerateColumns = false;
            this.t_spDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_spDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.t_spDataGridView.DataSource = this.t_spBindingSource;
            this.t_spDataGridView.Location = new System.Drawing.Point(39, 66);
            this.t_spDataGridView.Name = "t_spDataGridView";
            this.t_spDataGridView.RowTemplate.Height = 23;
            this.t_spDataGridView.Size = new System.Drawing.Size(642, 220);
            this.t_spDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn1.HeaderText = "商品名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "xh";
            this.dataGridViewTextBoxColumn2.HeaderText = "商品型号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "bh";
            this.dataGridViewTextBoxColumn3.HeaderText = "商品编号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gg";
            this.dataGridViewTextBoxColumn4.HeaderText = "商品规格";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dw";
            this.dataGridViewTextBoxColumn5.HeaderText = "单位";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "kcxx";
            this.dataGridViewTextBoxColumn6.HeaderText = "库存下限";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // FrmSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 344);
            this.Controls.Add(this.t_spDataGridView);
            this.Controls.Add(this.t_spBindingNavigator);
            this.Name = "FrmSp";
            this.Text = "FrmSp";
            this.Load += new System.EventHandler(this.FrmSp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zgzyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_spBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_spBindingNavigator)).EndInit();
            this.t_spBindingNavigator.ResumeLayout(false);
            this.t_spBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_spDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private zgzyDataSet zgzyDataSet;
        private System.Windows.Forms.BindingSource t_spBindingSource;
        private zgzyDataSetTableAdapters.t_spTableAdapter t_spTableAdapter;
        private zgzyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_spBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_spBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView t_spDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}