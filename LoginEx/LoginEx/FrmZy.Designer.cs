namespace LoginEx
{
    partial class FrmZy
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
            System.Windows.Forms.Label bhLabel;
            System.Windows.Forms.Label mcLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZy));
            this.zgzyDataSet = new LoginEx.zgzyDataSet();
            this.t_zgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_zgTableAdapter = new LoginEx.zgzyDataSetTableAdapters.t_zgTableAdapter();
            this.tableAdapterManager = new LoginEx.zgzyDataSetTableAdapters.TableAdapterManager();
            this.t_zyTableAdapter = new LoginEx.zgzyDataSetTableAdapters.t_zyTableAdapter();
            this.t_zgBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.t_zgBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.t_zyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_zyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcTextBox = new System.Windows.Forms.TextBox();
            this.bhMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            bhLabel = new System.Windows.Forms.Label();
            mcLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zgzyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgBindingNavigator)).BeginInit();
            this.t_zgBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_zyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bhLabel
            // 
            bhLabel.AutoSize = true;
            bhLabel.Location = new System.Drawing.Point(399, 126);
            bhLabel.Name = "bhLabel";
            bhLabel.Size = new System.Drawing.Size(59, 12);
            bhLabel.TabIndex = 2;
            bhLabel.Text = "专业编号:";
            // 
            // mcLabel
            // 
            mcLabel.AutoSize = true;
            mcLabel.Location = new System.Drawing.Point(399, 155);
            mcLabel.Name = "mcLabel";
            mcLabel.Size = new System.Drawing.Size(59, 12);
            mcLabel.TabIndex = 4;
            mcLabel.Text = "专业名称:";
            // 
            // zgzyDataSet
            // 
            this.zgzyDataSet.DataSetName = "zgzyDataSet";
            this.zgzyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_zgBindingSource
            // 
            this.t_zgBindingSource.DataMember = "t_zg";
            this.t_zgBindingSource.DataSource = this.zgzyDataSet;
            // 
            // t_zgTableAdapter
            // 
            this.t_zgTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.t_bmTableAdapter = null;
            this.tableAdapterManager.t_zg1TableAdapter = null;
            this.tableAdapterManager.t_zgTableAdapter = this.t_zgTableAdapter;
            this.tableAdapterManager.t_zyTableAdapter = this.t_zyTableAdapter;
            this.tableAdapterManager.UpdateOrder = LoginEx.zgzyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_zyTableAdapter
            // 
            this.t_zyTableAdapter.ClearBeforeFill = true;
            // 
            // t_zgBindingNavigator
            // 
            this.t_zgBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_zgBindingNavigator.BindingSource = this.t_zgBindingSource;
            this.t_zgBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_zgBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_zgBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_zgBindingNavigatorSaveItem});
            this.t_zgBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_zgBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_zgBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_zgBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_zgBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_zgBindingNavigator.Name = "t_zgBindingNavigator";
            this.t_zgBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_zgBindingNavigator.Size = new System.Drawing.Size(711, 25);
            this.t_zgBindingNavigator.TabIndex = 0;
            this.t_zgBindingNavigator.Text = "bindingNavigator1";
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
            // t_zgBindingNavigatorSaveItem
            // 
            this.t_zgBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_zgBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_zgBindingNavigatorSaveItem.Image")));
            this.t_zgBindingNavigatorSaveItem.Name = "t_zgBindingNavigatorSaveItem";
            this.t_zgBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.t_zgBindingNavigatorSaveItem.Text = "保存数据";
            this.t_zgBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_zgBindingNavigatorSaveItem_Click);
            // 
            // t_zyBindingSource
            // 
            this.t_zyBindingSource.DataMember = "t_zy";
            this.t_zyBindingSource.DataSource = this.zgzyDataSet;
            // 
            // t_zyDataGridView
            // 
            this.t_zyDataGridView.AutoGenerateColumns = false;
            this.t_zyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_zyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.t_zyDataGridView.DataSource = this.t_zyBindingSource;
            this.t_zyDataGridView.Location = new System.Drawing.Point(51, 88);
            this.t_zyDataGridView.Name = "t_zyDataGridView";
            this.t_zyDataGridView.RowTemplate.Height = 23;
            this.t_zyDataGridView.Size = new System.Drawing.Size(243, 220);
            this.t_zyDataGridView.TabIndex = 1;
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
            // mcTextBox
            // 
            this.mcTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_zyBindingSource, "mc", true));
            this.mcTextBox.Location = new System.Drawing.Point(464, 152);
            this.mcTextBox.Name = "mcTextBox";
            this.mcTextBox.Size = new System.Drawing.Size(121, 21);
            this.mcTextBox.TabIndex = 5;
            // 
            // bhMaskedTextBox
            // 
            this.bhMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_zyBindingSource, "bh", true));
            this.bhMaskedTextBox.Location = new System.Drawing.Point(464, 125);
            this.bhMaskedTextBox.Mask = "0000";
            this.bhMaskedTextBox.Name = "bhMaskedTextBox";
            this.bhMaskedTextBox.Size = new System.Drawing.Size(121, 21);
            this.bhMaskedTextBox.TabIndex = 6;
            this.bhMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.bhMaskedTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmZy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 402);
            this.Controls.Add(this.bhMaskedTextBox);
            this.Controls.Add(bhLabel);
            this.Controls.Add(mcLabel);
            this.Controls.Add(this.mcTextBox);
            this.Controls.Add(this.t_zyDataGridView);
            this.Controls.Add(this.t_zgBindingNavigator);
            this.Name = "FrmZy";
            this.Text = "专业数据编辑窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmZy_FormClosing);
            this.Load += new System.EventHandler(this.FrmZy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zgzyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgBindingNavigator)).EndInit();
            this.t_zgBindingNavigator.ResumeLayout(false);
            this.t_zgBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_zyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private zgzyDataSet zgzyDataSet;
        private System.Windows.Forms.BindingSource t_zgBindingSource;
        private zgzyDataSetTableAdapters.t_zgTableAdapter t_zgTableAdapter;
        private zgzyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_zgBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_zgBindingNavigatorSaveItem;
        private zgzyDataSetTableAdapters.t_zyTableAdapter t_zyTableAdapter;
        private System.Windows.Forms.BindingSource t_zyBindingSource;
        private System.Windows.Forms.DataGridView t_zyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox mcTextBox;
        private System.Windows.Forms.MaskedTextBox bhMaskedTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}