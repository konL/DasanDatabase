using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginEx
{
    public partial class FrmKhGys : Form
    {
        public FrmKhGys()
        {
            InitializeComponent();
        }

        private void t_khgysBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_khgysBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zgzyDataSet);

        }

        private void FrmKhGys_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“zgzyDataSet.t_khgys”中。您可以根据需要移动或删除它。
            this.t_khgysTableAdapter.Fill(this.zgzyDataSet.t_khgys);

        }
    }
}
