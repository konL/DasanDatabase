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
    public partial class FrmZy : Form
    {
        public FrmZy()
        {
            InitializeComponent();
        }

        private void t_zgBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_zgBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zgzyDataSet);

        }

        private void FrmZy_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“zgzyDataSet.t_zy”中。您可以根据需要移动或删除它。
            this.t_zyTableAdapter.Fill(this.zgzyDataSet.t_zy);
            // TODO: 这行代码将数据加载到表“zgzyDataSet.t_zg”中。您可以根据需要移动或删除它。
            this.t_zgTableAdapter.Fill(this.zgzyDataSet.t_zg);

        }

        private void bhMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            //是否已完成输入
            if (!bhMaskedTextBox.MaskCompleted)
            {
                errorProvider1.SetError(bhMaskedTextBox, "编号要求4位");
                e.Cancel = true;
            }
            else
            {
                //清除错误信息
                errorProvider1.SetError(bhMaskedTextBox, "");
            }
        }

        private void FrmZy_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
