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
    public partial class FrmZG : Form
    {
        public FrmZG()
        {
            InitializeComponent();
        }

        private void t_zgBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.t_zgBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.zgzyDataSet);
                MessageBox.Show("操作成功","提示");
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void FrmZG_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“zgzyDataSet.t_bm”中。您可以根据需要移动或删除它。
            this.t_bmTableAdapter.Fill(this.zgzyDataSet.t_bm);
            // TODO: 这行代码将数据加载到表“zgzyDataSet.t_zy”中。您可以根据需要移动或删除它。
            this.t_zyTableAdapter.Fill(this.zgzyDataSet.t_zy);
            // TODO: 这行代码将数据加载到表“zgzyDataSet.t_zg”中。您可以根据需要移动或删除它。
            this.t_zgTableAdapter.Fill(this.zgzyDataSet.t_zg);

        }

        private void t_zgDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bhLabel_Click(object sender, EventArgs e)
        {

        }

        private void bmbhLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            /*try
            {
               
                MessageBox.Show("点击保存删除即可生效", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           /* try
            {

                MessageBox.Show("点击保存添加即可生效", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void bhMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            //是否已完成输入
            if (!bhMaskedTextBox.MaskCompleted)
            {
                errorProvider1.SetError(bhMaskedTextBox, "编号要求4位");
                e.Cancel = true;
            }
            else {
                //清除错误信息
                errorProvider1.SetError(bhMaskedTextBox, "");
            }
        }

        private void bhMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmZG_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void bhMaskedTextBox_Validating_1(object sender, CancelEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_SearchByZymc fm = new Frm_SearchByZymc();
            fm.Show();
        }
    }
}
