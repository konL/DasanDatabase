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
    public partial class FrmBm : Form
    {
        public FrmBm()
        {
            InitializeComponent();
        }

        private void FrmBm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“zgzyDataSet.t_zg”中。您可以根据需要移动或删除它。
            this.t_zgTableAdapter.Fill(this.zgzyDataSet.t_zg);
            // TODO: 这行代码将数据加载到表“zgzyDataSet.t_bm”中。您可以根据需要移动或删除它。


            if ("0".Equals(LoginInfo.Qx))
            {

                // TODO: 这行代码将数据加载到表“zgzyDataSet.t_zg”中。您可以根据需要移动或删除它。
                //.Fill填充(src:this.zgzyDataSet.t_zg
                this.t_bmTableAdapter.Fill(this.zgzyDataSet.t_bm);
            }
            else
            {

                this.t_bmTableAdapter.FillBybh(this.zgzyDataSet.t_bm, LoginInfo.Bmbh);
                //功能不可用
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                bhMaskedTextBox.Enabled = false;

            }
        }

        private void t_bmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                //可以设置权限
                this.Validate();
                this.t_bmBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.zgzyDataSet);
                MessageBox.Show("操作成功", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void t_bmDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bhLabel_Click(object sender, EventArgs e)
        {

        }

        private void bhMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            //是否已完成输入
            if (!bhMaskedTextBox.MaskCompleted)
            {
                errorProvider1.SetError(bhMaskedTextBox, "编号要求2位");
                e.Cancel = true;
            }
            else
            {
                //清除错误信息
                errorProvider1.SetError(bhMaskedTextBox, "");
            }
        }

        private void FrmBm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
