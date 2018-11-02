namespace LoginEx
{
    partial class FrmZG
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
            System.Windows.Forms.Label xmLabel;
            System.Windows.Forms.Label xbLabel;
            System.Windows.Forms.Label csrqLabel;
            System.Windows.Forms.Label hfLabel;
            System.Windows.Forms.Label klLabel;
            System.Windows.Forms.Label qxLabel;
            System.Windows.Forms.Label zybhLabel;
            System.Windows.Forms.Label bmbhLabel;
            System.Windows.Forms.Label bhLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZG));
            this.zgzyDataSet = new LoginEx.zgzyDataSet();
            this.t_zgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_zgTableAdapter = new LoginEx.zgzyDataSetTableAdapters.t_zgTableAdapter();
            this.tableAdapterManager = new LoginEx.zgzyDataSetTableAdapters.TableAdapterManager();
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
            this.t_zgDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmTextBox = new System.Windows.Forms.TextBox();
            this.xbTextBox = new System.Windows.Forms.TextBox();
            this.csrqDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hfCheckBox = new System.Windows.Forms.CheckBox();
            this.klTextBox = new System.Windows.Forms.TextBox();
            this.qxTextBox = new System.Windows.Forms.TextBox();
            this.zybhComboBox = new System.Windows.Forms.ComboBox();
            this.tzyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bmbhComboBox = new System.Windows.Forms.ComboBox();
            this.tbmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tzyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_zyTableAdapter = new LoginEx.zgzyDataSetTableAdapters.t_zyTableAdapter();
            this.t_bmTableAdapter = new LoginEx.zgzyDataSetTableAdapters.t_bmTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bhMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            xmLabel = new System.Windows.Forms.Label();
            xbLabel = new System.Windows.Forms.Label();
            csrqLabel = new System.Windows.Forms.Label();
            hfLabel = new System.Windows.Forms.Label();
            klLabel = new System.Windows.Forms.Label();
            qxLabel = new System.Windows.Forms.Label();
            zybhLabel = new System.Windows.Forms.Label();
            bmbhLabel = new System.Windows.Forms.Label();
            bhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zgzyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgBindingNavigator)).BeginInit();
            this.t_zgBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // xmLabel
            // 
            xmLabel.AutoSize = true;
            xmLabel.Location = new System.Drawing.Point(498, 77);
            xmLabel.Name = "xmLabel";
            xmLabel.Size = new System.Drawing.Size(35, 12);
            xmLabel.TabIndex = 4;
            xmLabel.Text = "姓名:";
            // 
            // xbLabel
            // 
            xbLabel.AutoSize = true;
            xbLabel.Location = new System.Drawing.Point(498, 104);
            xbLabel.Name = "xbLabel";
            xbLabel.Size = new System.Drawing.Size(35, 12);
            xbLabel.TabIndex = 6;
            xbLabel.Text = "性别:";
            // 
            // csrqLabel
            // 
            csrqLabel.AutoSize = true;
            csrqLabel.Location = new System.Drawing.Point(498, 132);
            csrqLabel.Name = "csrqLabel";
            csrqLabel.Size = new System.Drawing.Size(59, 12);
            csrqLabel.TabIndex = 8;
            csrqLabel.Text = "出生日期:";
            // 
            // hfLabel
            // 
            hfLabel.AutoSize = true;
            hfLabel.Location = new System.Drawing.Point(498, 187);
            hfLabel.Name = "hfLabel";
            hfLabel.Size = new System.Drawing.Size(35, 12);
            hfLabel.TabIndex = 12;
            hfLabel.Text = "婚否:";
            // 
            // klLabel
            // 
            klLabel.AutoSize = true;
            klLabel.Location = new System.Drawing.Point(498, 242);
            klLabel.Name = "klLabel";
            klLabel.Size = new System.Drawing.Size(35, 12);
            klLabel.TabIndex = 16;
            klLabel.Text = "口令:";
            // 
            // qxLabel
            // 
            qxLabel.AutoSize = true;
            qxLabel.Location = new System.Drawing.Point(498, 269);
            qxLabel.Name = "qxLabel";
            qxLabel.Size = new System.Drawing.Size(35, 12);
            qxLabel.TabIndex = 18;
            qxLabel.Text = "权限:";
            // 
            // zybhLabel
            // 
            zybhLabel.AutoSize = true;
            zybhLabel.Location = new System.Drawing.Point(498, 163);
            zybhLabel.Name = "zybhLabel";
            zybhLabel.Size = new System.Drawing.Size(35, 12);
            zybhLabel.TabIndex = 19;
            zybhLabel.Text = "专业:";
            // 
            // bmbhLabel
            // 
            bmbhLabel.AutoSize = true;
            bmbhLabel.Location = new System.Drawing.Point(498, 209);
            bmbhLabel.Name = "bmbhLabel";
            bmbhLabel.Size = new System.Drawing.Size(35, 12);
            bmbhLabel.TabIndex = 20;
            bmbhLabel.Text = "部门:";
            bmbhLabel.Click += new System.EventHandler(this.bmbhLabel_Click);
            // 
            // bhLabel
            // 
            bhLabel.AutoSize = true;
            bhLabel.Location = new System.Drawing.Point(498, 50);
            bhLabel.Name = "bhLabel";
            bhLabel.Size = new System.Drawing.Size(35, 12);
            bhLabel.TabIndex = 2;
            bhLabel.Text = "编号:";
            bhLabel.Click += new System.EventHandler(this.bhLabel_Click);
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
            this.tableAdapterManager.t_zgTableAdapter = this.t_zgTableAdapter;
            this.tableAdapterManager.t_zyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoginEx.zgzyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.t_zgBindingNavigator.Size = new System.Drawing.Size(957, 25);
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
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // t_zgDataGridView
            // 
            this.t_zgDataGridView.AutoGenerateColumns = false;
            this.t_zgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_zgDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.xm,
            this.xb,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.t_zgDataGridView.DataSource = this.t_zgBindingSource;
            this.t_zgDataGridView.Location = new System.Drawing.Point(24, 50);
            this.t_zgDataGridView.Name = "t_zgDataGridView";
            this.t_zgDataGridView.RowTemplate.Height = 23;
            this.t_zgDataGridView.Size = new System.Drawing.Size(300, 220);
            this.t_zgDataGridView.TabIndex = 1;
            this.t_zgDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.t_zgDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bh";
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // xm
            // 
            this.xm.DataPropertyName = "xm";
            this.xm.HeaderText = "姓名";
            this.xm.Name = "xm";
            // 
            // xb
            // 
            this.xb.DataPropertyName = "xb";
            this.xb.HeaderText = "性别";
            this.xb.Name = "xb";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "bmbh";
            this.dataGridViewTextBoxColumn6.HeaderText = "部门编号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "kl";
            this.dataGridViewTextBoxColumn7.HeaderText = "口令";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "qx";
            this.dataGridViewTextBoxColumn8.HeaderText = "权限";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // xmTextBox
            // 
            this.xmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_zgBindingSource, "xm", true));
            this.xmTextBox.Location = new System.Drawing.Point(539, 74);
            this.xmTextBox.Name = "xmTextBox";
            this.xmTextBox.Size = new System.Drawing.Size(200, 21);
            this.xmTextBox.TabIndex = 5;
            // 
            // xbTextBox
            // 
            this.xbTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_zgBindingSource, "xb", true));
            this.xbTextBox.Location = new System.Drawing.Point(539, 101);
            this.xbTextBox.Name = "xbTextBox";
            this.xbTextBox.Size = new System.Drawing.Size(200, 21);
            this.xbTextBox.TabIndex = 7;
            // 
            // csrqDateTimePicker
            // 
            this.csrqDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_zgBindingSource, "csrq", true));
            this.csrqDateTimePicker.Location = new System.Drawing.Point(563, 128);
            this.csrqDateTimePicker.Name = "csrqDateTimePicker";
            this.csrqDateTimePicker.Size = new System.Drawing.Size(176, 21);
            this.csrqDateTimePicker.TabIndex = 9;
            // 
            // hfCheckBox
            // 
            this.hfCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.t_zgBindingSource, "hf", true));
            this.hfCheckBox.Location = new System.Drawing.Point(539, 182);
            this.hfCheckBox.Name = "hfCheckBox";
            this.hfCheckBox.Size = new System.Drawing.Size(200, 24);
            this.hfCheckBox.TabIndex = 13;
            this.hfCheckBox.UseVisualStyleBackColor = true;
            // 
            // klTextBox
            // 
            this.klTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_zgBindingSource, "kl", true));
            this.klTextBox.Location = new System.Drawing.Point(539, 239);
            this.klTextBox.Name = "klTextBox";
            this.klTextBox.Size = new System.Drawing.Size(200, 21);
            this.klTextBox.TabIndex = 17;
            // 
            // qxTextBox
            // 
            this.qxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_zgBindingSource, "qx", true));
            this.qxTextBox.Location = new System.Drawing.Point(539, 266);
            this.qxTextBox.Name = "qxTextBox";
            this.qxTextBox.Size = new System.Drawing.Size(200, 21);
            this.qxTextBox.TabIndex = 19;
            // 
            // zybhComboBox
            // 
            this.zybhComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.t_zgBindingSource, "zybh", true));
            this.zybhComboBox.DataSource = this.tzyBindingSource1;
            this.zybhComboBox.DisplayMember = "mc";
            this.zybhComboBox.FormattingEnabled = true;
            this.zybhComboBox.Location = new System.Drawing.Point(539, 160);
            this.zybhComboBox.Name = "zybhComboBox";
            this.zybhComboBox.Size = new System.Drawing.Size(121, 20);
            this.zybhComboBox.TabIndex = 20;
            this.zybhComboBox.ValueMember = "bh";
            // 
            // tzyBindingSource1
            // 
            this.tzyBindingSource1.DataMember = "t_zy";
            this.tzyBindingSource1.DataSource = this.zgzyDataSet;
            // 
            // bmbhComboBox
            // 
            this.bmbhComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.t_zgBindingSource, "bmbh", true));
            this.bmbhComboBox.DataSource = this.tbmBindingSource;
            this.bmbhComboBox.DisplayMember = "mc";
            this.bmbhComboBox.FormattingEnabled = true;
            this.bmbhComboBox.Location = new System.Drawing.Point(539, 206);
            this.bmbhComboBox.Name = "bmbhComboBox";
            this.bmbhComboBox.Size = new System.Drawing.Size(121, 20);
            this.bmbhComboBox.TabIndex = 21;
            this.bmbhComboBox.ValueMember = "bh";
            // 
            // tbmBindingSource
            // 
            this.tbmBindingSource.DataMember = "t_bm";
            this.tbmBindingSource.DataSource = this.zgzyDataSet;
            // 
            // tzyBindingSource
            // 
            this.tzyBindingSource.DataMember = "t_zy";
            this.tzyBindingSource.DataSource = this.zgzyDataSet;
            // 
            // t_zyTableAdapter
            // 
            this.t_zyTableAdapter.ClearBeforeFill = true;
            // 
            // t_bmTableAdapter
            // 
            this.t_bmTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bhMaskedTextBox
            // 
            this.bhMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_zgBindingSource, "bh", true));
            this.bhMaskedTextBox.Location = new System.Drawing.Point(539, 47);
            this.bhMaskedTextBox.Mask = "0000";
            this.bhMaskedTextBox.Name = "bhMaskedTextBox";
            this.bhMaskedTextBox.Size = new System.Drawing.Size(100, 21);
            this.bhMaskedTextBox.TabIndex = 23;
            this.bhMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.bhMaskedTextBox_Validating_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "按专业查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmZG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bhMaskedTextBox);
            this.Controls.Add(bmbhLabel);
            this.Controls.Add(this.bmbhComboBox);
            this.Controls.Add(zybhLabel);
            this.Controls.Add(this.zybhComboBox);
            this.Controls.Add(bhLabel);
            this.Controls.Add(xmLabel);
            this.Controls.Add(this.xmTextBox);
            this.Controls.Add(xbLabel);
            this.Controls.Add(this.xbTextBox);
            this.Controls.Add(csrqLabel);
            this.Controls.Add(this.csrqDateTimePicker);
            this.Controls.Add(hfLabel);
            this.Controls.Add(this.hfCheckBox);
            this.Controls.Add(klLabel);
            this.Controls.Add(this.klTextBox);
            this.Controls.Add(qxLabel);
            this.Controls.Add(this.qxTextBox);
            this.Controls.Add(this.t_zgDataGridView);
            this.Controls.Add(this.t_zgBindingNavigator);
            this.Name = "FrmZG";
            this.Text = "职工数据编辑窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmZG_FormClosing);
            this.Load += new System.EventHandler(this.FrmZG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zgzyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgBindingNavigator)).EndInit();
            this.t_zgBindingNavigator.ResumeLayout(false);
            this.t_zgBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzyBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView t_zgDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xm;
        private System.Windows.Forms.DataGridViewTextBoxColumn xb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox xmTextBox;
        private System.Windows.Forms.TextBox xbTextBox;
        private System.Windows.Forms.DateTimePicker csrqDateTimePicker;
        private System.Windows.Forms.CheckBox hfCheckBox;
        private System.Windows.Forms.TextBox klTextBox;
        private System.Windows.Forms.TextBox qxTextBox;
        private System.Windows.Forms.ComboBox zybhComboBox;
        private System.Windows.Forms.ComboBox bmbhComboBox;
        private System.Windows.Forms.BindingSource tzyBindingSource;
        private zgzyDataSetTableAdapters.t_zyTableAdapter t_zyTableAdapter;
        private System.Windows.Forms.BindingSource tzyBindingSource1;
        private System.Windows.Forms.BindingSource tbmBindingSource;
        private zgzyDataSetTableAdapters.t_bmTableAdapter t_bmTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox bhMaskedTextBox;
        private System.Windows.Forms.Button button1;
    }
}