namespace LoginEx
{
    partial class FrmBm
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
            System.Windows.Forms.Label fzrbhLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBm));
            this.zgzyDataSet = new LoginEx.zgzyDataSet();
            this.t_bmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_bmTableAdapter = new LoginEx.zgzyDataSetTableAdapters.t_bmTableAdapter();
            this.tableAdapterManager = new LoginEx.zgzyDataSetTableAdapters.TableAdapterManager();
            this.t_bmBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.t_bmBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.t_bmDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bhMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.mcTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fzrbhComboBox = new System.Windows.Forms.ComboBox();
            this.tzgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_zgTableAdapter = new LoginEx.zgzyDataSetTableAdapters.t_zgTableAdapter();
            bhLabel = new System.Windows.Forms.Label();
            mcLabel = new System.Windows.Forms.Label();
            fzrbhLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zgzyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmBindingNavigator)).BeginInit();
            this.t_bmBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bhLabel
            // 
            bhLabel.AutoSize = true;
            bhLabel.Location = new System.Drawing.Point(417, 71);
            bhLabel.Name = "bhLabel";
            bhLabel.Size = new System.Drawing.Size(59, 12);
            bhLabel.TabIndex = 2;
            bhLabel.Text = "部门编号:";
            bhLabel.Click += new System.EventHandler(this.bhLabel_Click);
            // 
            // mcLabel
            // 
            mcLabel.AutoSize = true;
            mcLabel.Location = new System.Drawing.Point(417, 117);
            mcLabel.Name = "mcLabel";
            mcLabel.Size = new System.Drawing.Size(59, 12);
            mcLabel.TabIndex = 4;
            mcLabel.Text = "部门名称:";
            // 
            // fzrbhLabel1
            // 
            fzrbhLabel1.AutoSize = true;
            fzrbhLabel1.Location = new System.Drawing.Point(422, 162);
            fzrbhLabel1.Name = "fzrbhLabel1";
            fzrbhLabel1.Size = new System.Drawing.Size(47, 12);
            fzrbhLabel1.TabIndex = 8;
            fzrbhLabel1.Text = "负责人:";
            // 
            // zgzyDataSet
            // 
            this.zgzyDataSet.DataSetName = "zgzyDataSet";
            this.zgzyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_bmBindingSource
            // 
            this.t_bmBindingSource.DataMember = "t_bm";
            this.t_bmBindingSource.DataSource = this.zgzyDataSet;
            // 
            // t_bmTableAdapter
            // 
            this.t_bmTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.t_bmTableAdapter = this.t_bmTableAdapter;
            this.tableAdapterManager.t_csTableAdapter = null;
            this.tableAdapterManager.t_jhdTableAdapter = null;
            this.tableAdapterManager.t_jhmxTableAdapter = null;
            this.tableAdapterManager.t_kcTableAdapter = null;
            this.tableAdapterManager.t_khgysTableAdapter = null;
            this.tableAdapterManager.t_spTableAdapter = null;
            this.tableAdapterManager.t_xsdTableAdapter = null;
            this.tableAdapterManager.t_xsmxTableAdapter = null;
            this.tableAdapterManager.t_zg1TableAdapter = null;
            this.tableAdapterManager.t_zgTableAdapter = null;
            this.tableAdapterManager.t_zyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoginEx.zgzyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_bmBindingNavigator
            // 
            this.t_bmBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_bmBindingNavigator.BindingSource = this.t_bmBindingSource;
            this.t_bmBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_bmBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_bmBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_bmBindingNavigatorSaveItem});
            this.t_bmBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_bmBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_bmBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_bmBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_bmBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_bmBindingNavigator.Name = "t_bmBindingNavigator";
            this.t_bmBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_bmBindingNavigator.Size = new System.Drawing.Size(631, 25);
            this.t_bmBindingNavigator.TabIndex = 0;
            this.t_bmBindingNavigator.Text = "bindingNavigator1";
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
            // t_bmBindingNavigatorSaveItem
            // 
            this.t_bmBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_bmBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_bmBindingNavigatorSaveItem.Image")));
            this.t_bmBindingNavigatorSaveItem.Name = "t_bmBindingNavigatorSaveItem";
            this.t_bmBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.t_bmBindingNavigatorSaveItem.Text = "保存数据";
            this.t_bmBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_bmBindingNavigatorSaveItem_Click);
            // 
            // t_bmDataGridView
            // 
            this.t_bmDataGridView.AutoGenerateColumns = false;
            this.t_bmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_bmDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.t_bmDataGridView.DataSource = this.t_bmBindingSource;
            this.t_bmDataGridView.Location = new System.Drawing.Point(27, 60);
            this.t_bmDataGridView.Name = "t_bmDataGridView";
            this.t_bmDataGridView.RowTemplate.Height = 23;
            this.t_bmDataGridView.Size = new System.Drawing.Size(241, 220);
            this.t_bmDataGridView.TabIndex = 1;
            this.t_bmDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.t_bmDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bh";
            this.dataGridViewTextBoxColumn1.HeaderText = "部门编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn2.HeaderText = "部门名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // bhMaskedTextBox
            // 
            this.bhMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_bmBindingSource, "bh", true));
            this.bhMaskedTextBox.Location = new System.Drawing.Point(477, 68);
            this.bhMaskedTextBox.Mask = "00";
            this.bhMaskedTextBox.Name = "bhMaskedTextBox";
            this.bhMaskedTextBox.Size = new System.Drawing.Size(89, 21);
            this.bhMaskedTextBox.TabIndex = 3;
            this.bhMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.bhMaskedTextBox_Validating);
            // 
            // mcTextBox
            // 
            this.mcTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_bmBindingSource, "mc", true));
            this.mcTextBox.Location = new System.Drawing.Point(477, 114);
            this.mcTextBox.Name = "mcTextBox";
            this.mcTextBox.Size = new System.Drawing.Size(113, 21);
            this.mcTextBox.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fzrbhComboBox
            // 
            this.fzrbhComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.t_bmBindingSource, "fzrbh", true));
            this.fzrbhComboBox.DataSource = this.tzgBindingSource;
            this.fzrbhComboBox.DisplayMember = "xm";
            this.fzrbhComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fzrbhComboBox.FormattingEnabled = true;
            this.fzrbhComboBox.Location = new System.Drawing.Point(477, 159);
            this.fzrbhComboBox.Name = "fzrbhComboBox";
            this.fzrbhComboBox.Size = new System.Drawing.Size(107, 20);
            this.fzrbhComboBox.TabIndex = 9;
            this.fzrbhComboBox.ValueMember = "bh";
            // 
            // tzgBindingSource
            // 
            this.tzgBindingSource.DataMember = "t_zg";
            this.tzgBindingSource.DataSource = this.zgzyDataSet;
            // 
            // tbmBindingSource
            // 
            this.tbmBindingSource.DataMember = "t_bm";
            this.tbmBindingSource.DataSource = this.zgzyDataSet;
            // 
            // t_zgTableAdapter
            // 
            this.t_zgTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 335);
            this.Controls.Add(fzrbhLabel1);
            this.Controls.Add(this.fzrbhComboBox);
            this.Controls.Add(mcLabel);
            this.Controls.Add(this.mcTextBox);
            this.Controls.Add(bhLabel);
            this.Controls.Add(this.bhMaskedTextBox);
            this.Controls.Add(this.t_bmDataGridView);
            this.Controls.Add(this.t_bmBindingNavigator);
            this.Name = "FrmBm";
            this.Text = "部门数据编辑窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBm_FormClosing);
            this.Load += new System.EventHandler(this.FrmBm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zgzyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmBindingNavigator)).EndInit();
            this.t_bmBindingNavigator.ResumeLayout(false);
            this.t_bmBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private zgzyDataSet zgzyDataSet;
        private System.Windows.Forms.BindingSource t_bmBindingSource;
        private zgzyDataSetTableAdapters.t_bmTableAdapter t_bmTableAdapter;
        private zgzyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_bmBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_bmBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView t_bmDataGridView;
        private System.Windows.Forms.MaskedTextBox bhMaskedTextBox;
        private System.Windows.Forms.TextBox mcTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox fzrbhComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource tbmBindingSource;
        private System.Windows.Forms.BindingSource tzgBindingSource;
        private zgzyDataSetTableAdapters.t_zgTableAdapter t_zgTableAdapter;
    }
}