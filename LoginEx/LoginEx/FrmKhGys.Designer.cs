namespace LoginEx
{
    partial class FrmKhGys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhGys));
            this.zgzyDataSet = new LoginEx.zgzyDataSet();
            this.t_khgysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_khgysTableAdapter = new LoginEx.zgzyDataSetTableAdapters.t_khgysTableAdapter();
            this.tableAdapterManager = new LoginEx.zgzyDataSetTableAdapters.TableAdapterManager();
            this.t_khgysBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.t_khgysBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.t_khgysDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zgzyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_khgysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_khgysBindingNavigator)).BeginInit();
            this.t_khgysBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_khgysDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // zgzyDataSet
            // 
            this.zgzyDataSet.DataSetName = "zgzyDataSet";
            this.zgzyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_khgysBindingSource
            // 
            this.t_khgysBindingSource.DataMember = "t_khgys";
            this.t_khgysBindingSource.DataSource = this.zgzyDataSet;
            // 
            // t_khgysTableAdapter
            // 
            this.t_khgysTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.t_bmTableAdapter = null;
            this.tableAdapterManager.t_csTableAdapter = null;
            this.tableAdapterManager.t_jhdTableAdapter = null;
            this.tableAdapterManager.t_jhmxTableAdapter = null;
            this.tableAdapterManager.t_kcTableAdapter = null;
            this.tableAdapterManager.t_khgysTableAdapter = this.t_khgysTableAdapter;
            this.tableAdapterManager.t_spTableAdapter = null;
            this.tableAdapterManager.t_xsdTableAdapter = null;
            this.tableAdapterManager.t_xsmxTableAdapter = null;
            this.tableAdapterManager.t_zg1TableAdapter = null;
            this.tableAdapterManager.t_zgTableAdapter = null;
            this.tableAdapterManager.t_zyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoginEx.zgzyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_khgysBindingNavigator
            // 
            this.t_khgysBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_khgysBindingNavigator.BindingSource = this.t_khgysBindingSource;
            this.t_khgysBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_khgysBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_khgysBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_khgysBindingNavigatorSaveItem});
            this.t_khgysBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_khgysBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_khgysBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_khgysBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_khgysBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_khgysBindingNavigator.Name = "t_khgysBindingNavigator";
            this.t_khgysBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_khgysBindingNavigator.Size = new System.Drawing.Size(515, 25);
            this.t_khgysBindingNavigator.TabIndex = 0;
            this.t_khgysBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 17);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // t_khgysBindingNavigatorSaveItem
            // 
            this.t_khgysBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_khgysBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_khgysBindingNavigatorSaveItem.Image")));
            this.t_khgysBindingNavigatorSaveItem.Name = "t_khgysBindingNavigatorSaveItem";
            this.t_khgysBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.t_khgysBindingNavigatorSaveItem.Text = "保存数据";
            this.t_khgysBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_khgysBindingNavigatorSaveItem_Click);
            // 
            // t_khgysDataGridView
            // 
            this.t_khgysDataGridView.AutoGenerateColumns = false;
            this.t_khgysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_khgysDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.t_khgysDataGridView.DataSource = this.t_khgysBindingSource;
            this.t_khgysDataGridView.Location = new System.Drawing.Point(12, 50);
            this.t_khgysDataGridView.Name = "t_khgysDataGridView";
            this.t_khgysDataGridView.RowTemplate.Height = 23;
            this.t_khgysDataGridView.Size = new System.Drawing.Size(444, 220);
            this.t_khgysDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bh";
            this.dataGridViewTextBoxColumn1.HeaderText = "bh";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn2.HeaderText = "mc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lxr";
            this.dataGridViewTextBoxColumn3.HeaderText = "lxr";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "lxdh";
            this.dataGridViewTextBoxColumn4.HeaderText = "lxdh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FrmKhGys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 308);
            this.Controls.Add(this.t_khgysDataGridView);
            this.Controls.Add(this.t_khgysBindingNavigator);
            this.Name = "FrmKhGys";
            this.Text = "FrmKhGys";
            this.Load += new System.EventHandler(this.FrmKhGys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zgzyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_khgysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_khgysBindingNavigator)).EndInit();
            this.t_khgysBindingNavigator.ResumeLayout(false);
            this.t_khgysBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_khgysDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private zgzyDataSet zgzyDataSet;
        private System.Windows.Forms.BindingSource t_khgysBindingSource;
        private zgzyDataSetTableAdapters.t_khgysTableAdapter t_khgysTableAdapter;
        private zgzyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_khgysBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_khgysBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView t_khgysDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}