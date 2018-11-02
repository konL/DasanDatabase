namespace LoginEx
{
    partial class Frm_MD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MD));
            this.zgzyDataSet = new LoginEx.zgzyDataSet();
            this.t_zyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_zyTableAdapter = new LoginEx.zgzyDataSetTableAdapters.t_zyTableAdapter();
            this.tableAdapterManager = new LoginEx.zgzyDataSetTableAdapters.TableAdapterManager();
            this.t_zg1TableAdapter = new LoginEx.zgzyDataSetTableAdapters.t_zg1TableAdapter();
            this.t_zyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.t_zyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.t_zyDataGridView = new System.Windows.Forms.DataGridView();
            this.t_zg1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.bhToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.bhToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.t_zg1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zgzyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zyBindingNavigator)).BeginInit();
            this.t_zyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_zyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zg1BindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_zg1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // zgzyDataSet
            // 
            this.zgzyDataSet.DataSetName = "zgzyDataSet";
            this.zgzyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_zyBindingSource
            // 
            this.t_zyBindingSource.DataMember = "t_zy";
            this.t_zyBindingSource.DataSource = this.zgzyDataSet;
            // 
            // t_zyTableAdapter
            // 
            this.t_zyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.t_bmTableAdapter = null;
            this.tableAdapterManager.t_zg1TableAdapter = this.t_zg1TableAdapter;
            this.tableAdapterManager.t_zgTableAdapter = null;
            this.tableAdapterManager.t_zyTableAdapter = this.t_zyTableAdapter;
            this.tableAdapterManager.UpdateOrder = LoginEx.zgzyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_zg1TableAdapter
            // 
            this.t_zg1TableAdapter.ClearBeforeFill = true;
            // 
            // t_zyBindingNavigator
            // 
            this.t_zyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_zyBindingNavigator.BindingSource = this.t_zyBindingSource;
            this.t_zyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_zyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_zyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_zyBindingNavigatorSaveItem});
            this.t_zyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_zyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_zyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_zyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_zyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_zyBindingNavigator.Name = "t_zyBindingNavigator";
            this.t_zyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_zyBindingNavigator.Size = new System.Drawing.Size(1226, 25);
            this.t_zyBindingNavigator.TabIndex = 0;
            this.t_zyBindingNavigator.Text = "bindingNavigator1";
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
            // t_zyBindingNavigatorSaveItem
            // 
            this.t_zyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_zyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_zyBindingNavigatorSaveItem.Image")));
            this.t_zyBindingNavigatorSaveItem.Name = "t_zyBindingNavigatorSaveItem";
            this.t_zyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.t_zyBindingNavigatorSaveItem.Text = "保存数据";
            this.t_zyBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_zyBindingNavigatorSaveItem_Click);
            // 
            // t_zyDataGridView
            // 
            this.t_zyDataGridView.AutoGenerateColumns = false;
            this.t_zyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_zyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.t_zyDataGridView.DataSource = this.t_zyBindingSource;
            this.t_zyDataGridView.Location = new System.Drawing.Point(31, 57);
            this.t_zyDataGridView.Name = "t_zyDataGridView";
            this.t_zyDataGridView.RowTemplate.Height = 23;
            this.t_zyDataGridView.Size = new System.Drawing.Size(240, 286);
            this.t_zyDataGridView.TabIndex = 1;
            this.t_zyDataGridView.CurrentCellChanged += new System.EventHandler(this.t_zyDataGridView_CurrentCellChanged);
            // 
            // t_zg1BindingSource
            // 
            this.t_zg1BindingSource.DataMember = "t_zg1";
            this.t_zg1BindingSource.DataSource = this.zgzyDataSet;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bhToolStripLabel,
            this.bhToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1226, 25);
            this.fillToolStrip.TabIndex = 2;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // bhToolStripLabel
            // 
            this.bhToolStripLabel.Name = "bhToolStripLabel";
            this.bhToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.bhToolStripLabel.Text = "专业编号:";
            // 
            // bhToolStripTextBox
            // 
            this.bhToolStripTextBox.Name = "bhToolStripTextBox";
            this.bhToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(36, 22);
            this.fillToolStripButton.Text = "查询";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // t_zg1DataGridView
            // 
            this.t_zg1DataGridView.AutoGenerateColumns = false;
            this.t_zg1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_zg1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.t_zg1DataGridView.DataSource = this.t_zg1BindingSource;
            this.t_zg1DataGridView.Location = new System.Drawing.Point(359, 57);
            this.t_zg1DataGridView.Name = "t_zg1DataGridView";
            this.t_zg1DataGridView.RowTemplate.Height = 23;
            this.t_zg1DataGridView.Size = new System.Drawing.Size(542, 220);
            this.t_zg1DataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bh";
            this.dataGridViewTextBoxColumn1.HeaderText = "专业编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn2.HeaderText = "专业名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "bh";
            this.dataGridViewTextBoxColumn3.HeaderText = "编号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "xm";
            this.dataGridViewTextBoxColumn4.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "xb";
            this.dataGridViewTextBoxColumn5.HeaderText = "性别";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "csrq";
            this.dataGridViewTextBoxColumn6.HeaderText = "出生日期";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "zybh";
            this.dataGridViewTextBoxColumn7.HeaderText = "专业";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Frm_MD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 382);
            this.Controls.Add(this.t_zg1DataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.t_zyDataGridView);
            this.Controls.Add(this.t_zyBindingNavigator);
            this.Name = "Frm_MD";
            this.Text = "专业明细表";
            this.Load += new System.EventHandler(this.Frm_MD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zgzyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zyBindingNavigator)).EndInit();
            this.t_zyBindingNavigator.ResumeLayout(false);
            this.t_zyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_zyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zg1BindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_zg1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private zgzyDataSet zgzyDataSet;
        private System.Windows.Forms.BindingSource t_zyBindingSource;
        private zgzyDataSetTableAdapters.t_zyTableAdapter t_zyTableAdapter;
        private zgzyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_zyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_zyBindingNavigatorSaveItem;
        private zgzyDataSetTableAdapters.t_zg1TableAdapter t_zg1TableAdapter;
        private System.Windows.Forms.DataGridView t_zyDataGridView;
        private System.Windows.Forms.BindingSource t_zg1BindingSource;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel bhToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox bhToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView t_zg1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}