﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginEx
{
    public partial class FrmSp : Form
    {
        public FrmSp()
        {
            InitializeComponent();
        }

        private void t_spBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_spBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zgzyDataSet);

        }

        private void FrmSp_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“zgzyDataSet.t_sp”中。您可以根据需要移动或删除它。
            this.t_spTableAdapter.Fill(this.zgzyDataSet.t_sp);

        }
    }
}
